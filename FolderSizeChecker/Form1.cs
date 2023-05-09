using System.IO;

namespace FolderSizeChecker
{
    public partial class Form1 : Form
    {
        private FolderSizeCheckerViewModel _viewModel;
        private bool _firstBrowse = true;

        public Form1()
        {
            InitializeComponent();
            _viewModel = new FolderSizeCheckerViewModel();
        }

        private void buttonQuit_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenFolder_Click(Object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.ShowDialog();
                ChangeFolder(folderBrowser.SelectedPath);
            }

            _firstBrowse = false;
            buttonOpenInExplorer.Enabled = true;
        }

        private void ChangeFolder(string newPath)
        {
            Cursor.Current = Cursors.WaitCursor;

            listBoxFolders.Items.Clear();

            var baseDirectory = new DirectoryInfo(newPath);

            if(baseDirectory.Parent != null)
            {
                listBoxFolders.Items.Add("..");
            }

            try
            {
                foreach (var directory in baseDirectory.GetDirectories())
                {
                    listBoxFolders.Items.Add(_viewModel.GetFormattedSizeEntryForDirectory(directory));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeFolder(textBoxLocation.Text);
                return;
            }

            textBoxLocation.Text = newPath;

            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            buttonOpenFolder.Select();
        }

        private void listBoxFolders_MouseDoubleClick(Object sender, MouseEventArgs e)
        {
            if (_firstBrowse)
            {
                buttonOpenFolder_Click(sender, e);
            }
            else
            {
                var selectedItem = listBoxFolders.SelectedItem as string;
                if (selectedItem == "..")
                {
                    textBoxLocation.Text = _viewModel.BrowsePathUp(textBoxLocation.Text);
                    ChangeFolder(textBoxLocation.Text);
                }
                else if (selectedItem != null)
                {
                    var folderName = _viewModel.GetFolderNameFromFormattedSizeEntry(selectedItem);
                    ChangeFolder(Path.Combine(textBoxLocation.Text, folderName));
                }
            }
        }

        private void buttonOpenInExplorer_Click(Object sender, EventArgs e)
        {
            _viewModel.OpenInExplorer(textBoxLocation.Text);
        }
    }
}