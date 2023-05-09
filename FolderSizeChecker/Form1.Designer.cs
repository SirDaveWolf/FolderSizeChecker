namespace FolderSizeChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.buttonOpenInExplorer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(12, 12);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(984, 23);
            this.textBoxLocation.TabIndex = 0;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(921, 694);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 3;
            this.buttonOpenFolder.Text = "Browse";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(12, 694);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.ItemHeight = 15;
            this.listBoxFolders.Items.AddRange(new object[] {
            "Click \"Browse\" to begin..."});
            this.listBoxFolders.Location = new System.Drawing.Point(12, 41);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(984, 634);
            this.listBoxFolders.TabIndex = 1;
            this.listBoxFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFolders_MouseDoubleClick);
            // 
            // buttonOpenInExplorer
            // 
            this.buttonOpenInExplorer.Enabled = false;
            this.buttonOpenInExplorer.Location = new System.Drawing.Point(785, 694);
            this.buttonOpenInExplorer.Name = "buttonOpenInExplorer";
            this.buttonOpenInExplorer.Size = new System.Drawing.Size(130, 23);
            this.buttonOpenInExplorer.TabIndex = 4;
            this.buttonOpenInExplorer.Text = "Open in Explorer";
            this.buttonOpenInExplorer.UseVisualStyleBackColor = true;
            this.buttonOpenInExplorer.Click += new System.EventHandler(this.buttonOpenInExplorer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonOpenInExplorer);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.textBoxLocation);
            this.Name = "Form1";
            this.Text = "FolderSizeChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLocation;
        private Button buttonOpenFolder;
        private Button buttonQuit;
        private ListBox listBoxFolders;
        private Button buttonOpenInExplorer;
    }
}