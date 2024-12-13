namespace CommonForms.Components
{
    partial class FilesListSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkAddFolders = new CheckBox();
            chkParseSubfolders = new CheckBox();
            SuspendLayout();
            // 
            // chkAddFolders
            // 
            chkAddFolders.Anchor = AnchorStyles.Left;
            chkAddFolders.AutoSize = true;
            chkAddFolders.Location = new Point(48, 42);
            chkAddFolders.Margin = new Padding(2);
            chkAddFolders.Name = "chkAddFolders";
            chkAddFolders.Size = new Size(174, 24);
            chkAddFolders.TabIndex = 1;
            chkAddFolders.Text = "Allow Adding Folders";
            chkAddFolders.UseVisualStyleBackColor = true;
            chkAddFolders.CheckedChanged += chkAddFolders_CheckedChanged;
            // 
            // chkParseSubfolders
            // 
            chkParseSubfolders.Anchor = AnchorStyles.Left;
            chkParseSubfolders.AutoSize = true;
            chkParseSubfolders.Location = new Point(48, 70);
            chkParseSubfolders.Margin = new Padding(2);
            chkParseSubfolders.Name = "chkParseSubfolders";
            chkParseSubfolders.Size = new Size(173, 24);
            chkParseSubfolders.TabIndex = 2;
            chkParseSubfolders.Text = "Also Parse Subfolders";
            chkParseSubfolders.UseVisualStyleBackColor = true;
            chkParseSubfolders.CheckedChanged += chkParseSubfolders_CheckedChanged;
            // 
            // FilesListSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 266);
            Controls.Add(chkParseSubfolders);
            Controls.Add(chkAddFolders);
            Margin = new Padding(2);
            Name = "FilesListSettings";
            Text = "List Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAddFolders;
        private CheckBox chkParseSubfolders;
    }
}
