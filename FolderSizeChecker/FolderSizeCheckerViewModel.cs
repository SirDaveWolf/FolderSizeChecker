using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSizeChecker
{
    internal class FolderSizeCheckerViewModel
    {
        public void OpenInExplorer(string path)
        {
            var startInfo = new ProcessStartInfo("explorer");
            startInfo.Arguments = path;
            Process.Start(startInfo);
        }

        public string GetFormattedSizeEntryForDirectory(DirectoryInfo directory)
        {
            var size = GetDirectorySizeAsString(directory);
            return String.Format("{0,-200}\t{1}", directory.Name, "[" + GetFileSizeAsString(size) + "]");
        }

        public long GetDirectorySizeAsString(DirectoryInfo directory)
        {
            var directorySize = 0L;

            try
            {
                foreach (var file in directory.GetFiles())
                {
                    directorySize += file.Length;
                }

                foreach (var folder in directory.GetDirectories())
                {
                    directorySize += GetDirectorySizeAsString(folder);
                }
            }
            catch
            { }

            return directorySize;
        }

        public string GetFileSizeAsString(long size)
        {
            var result = size.ToString() + " b";

            if (size > 1024)
            {
                result = (size / 1024.0f).ToString() + " kb";
            }

            if (size > 1024 * 1024)
            {
                result = (size / (1024.0f * 1024.0f)).ToString() + " mb";
            }

            if (size > 1024 * 1024 * 1024)
            {
                result = (size / (1024.0f * 1024.0f * 1024.0f)).ToString() + " gb";
            }

            return result;
        }

        public string BrowsePathUp(string path)
        {
            return Path.GetFullPath(Path.Combine(path, @"..\"));
        }

        public string GetFolderNameFromFormattedSizeEntry(string sizeEntry)
        {
            return sizeEntry.Substring(0, sizeEntry.IndexOf('\t')).Trim();
        }
    }
}
