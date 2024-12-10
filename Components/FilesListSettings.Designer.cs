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
            chkAddFolders.Location = new Point(60, 53);
            chkAddFolders.Name = "chkAddFolders";
            chkAddFolders.Size = new Size(209, 29);
            chkAddFolders.TabIndex = 1;
            chkAddFolders.Text = "Allow Adding Folders";
            chkAddFolders.UseVisualStyleBackColor = true;
            chkAddFolders.CheckedChanged += chkAddFolders_CheckedChanged;
            // 
            // chkParseSubfolders
            // 
            chkParseSubfolders.Anchor = AnchorStyles.Left;
            chkParseSubfolders.AutoSize = true;
            chkParseSubfolders.Location = new Point(60, 100);
            chkParseSubfolders.Name = "chkParseSubfolders";
            chkParseSubfolders.Size = new Size(170, 29);
            chkParseSubfolders.TabIndex = 2;
            chkParseSubfolders.Text = "Parse Subfolders";
            chkParseSubfolders.UseVisualStyleBackColor = true;
            chkParseSubfolders.CheckedChanged += chkParseSubfolders_CheckedChanged;
            // 
            // FilesListSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkParseSubfolders);
            Controls.Add(chkAddFolders);
            Name = "FilesListSettings";
            Size = new Size(612, 379);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAddFolders;
        private CheckBox chkParseSubfolders;
    }
}
