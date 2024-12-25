namespace CommonForms.Components
{
    partial class FilesListSettingsDialog
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
            btnCancel = new Button();
            btnSave = new Button();
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
            // btnCancel
            // 
            btnCancel.Location = new Point(369, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(269, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FilesListSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 266);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(chkParseSubfolders);
            Controls.Add(chkAddFolders);
            Margin = new Padding(2);
            Name = "FilesListSettingsDialog";
            Text = "List Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAddFolders;
        private CheckBox chkParseSubfolders;
        private Button btnCancel;
        private Button btnSave;
    }
}
