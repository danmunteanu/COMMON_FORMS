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
            chkShowStatus = new CheckBox();
            chkShowProgressBar = new CheckBox();
            tableLayoutPanelButtons = new TableLayoutPanel();
            txtFileFilters = new TextBox();
            btnYaml = new Button();
            btnImg = new Button();
            btnArchives = new Button();
            lblFileFilters = new Label();
            btnClearFilters = new Button();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // chkAddFolders
            // 
            chkAddFolders.Anchor = AnchorStyles.Left;
            chkAddFolders.AutoSize = true;
            chkAddFolders.Location = new Point(23, 36);
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
            chkParseSubfolders.Location = new Point(22, 64);
            chkParseSubfolders.Margin = new Padding(2);
            chkParseSubfolders.Name = "chkParseSubfolders";
            chkParseSubfolders.Size = new Size(140, 24);
            chkParseSubfolders.TabIndex = 2;
            chkParseSubfolders.Text = "Parse Subfolders";
            chkParseSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Segoe UI", 8F);
            btnCancel.Location = new Point(365, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 26);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 8F);
            btnSave.Location = new Point(275, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 26);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkShowStatus
            // 
            chkShowStatus.AutoSize = true;
            chkShowStatus.Location = new Point(22, 117);
            chkShowStatus.Name = "chkShowStatus";
            chkShowStatus.Size = new Size(125, 24);
            chkShowStatus.TabIndex = 5;
            chkShowStatus.Text = "Use Status Bar";
            chkShowStatus.UseVisualStyleBackColor = true;
            // 
            // chkShowProgressBar
            // 
            chkShowProgressBar.AutoSize = true;
            chkShowProgressBar.Location = new Point(22, 147);
            chkShowProgressBar.Name = "chkShowProgressBar";
            chkShowProgressBar.Size = new Size(141, 24);
            chkShowProgressBar.TabIndex = 6;
            chkShowProgressBar.Text = "Use Progress Bar";
            chkShowProgressBar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 3;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelButtons.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnSave, 1, 0);
            tableLayoutPanelButtons.Location = new Point(22, 200);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(452, 32);
            tableLayoutPanelButtons.TabIndex = 8;
            // 
            // txtFileFilters
            // 
            txtFileFilters.Location = new Point(249, 36);
            txtFileFilters.Multiline = true;
            txtFileFilters.Name = "txtFileFilters";
            txtFileFilters.ReadOnly = true;
            txtFileFilters.Size = new Size(225, 58);
            txtFileFilters.TabIndex = 11;
            // 
            // btnYaml
            // 
            btnYaml.Font = new Font("Segoe UI", 7F);
            btnYaml.Location = new Point(249, 100);
            btnYaml.Name = "btnYaml";
            btnYaml.Size = new Size(54, 28);
            btnYaml.TabIndex = 12;
            btnYaml.Text = "YAML";
            btnYaml.UseVisualStyleBackColor = true;
            // 
            // btnImg
            // 
            btnImg.Font = new Font("Segoe UI", 7F);
            btnImg.Location = new Point(365, 100);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(38, 28);
            btnImg.TabIndex = 13;
            btnImg.Text = "IMG";
            btnImg.UseVisualStyleBackColor = true;
            // 
            // btnArchives
            // 
            btnArchives.Font = new Font("Segoe UI", 7F);
            btnArchives.Location = new Point(309, 101);
            btnArchives.Name = "btnArchives";
            btnArchives.Size = new Size(50, 28);
            btnArchives.TabIndex = 14;
            btnArchives.Text = "ARCH";
            btnArchives.UseVisualStyleBackColor = true;
            // 
            // lblFileFilters
            // 
            lblFileFilters.AutoSize = true;
            lblFileFilters.Location = new Point(249, 13);
            lblFileFilters.Name = "lblFileFilters";
            lblFileFilters.Size = new Size(78, 20);
            lblFileFilters.TabIndex = 15;
            lblFileFilters.Text = "File Filters:";
            // 
            // btnClearFilters
            // 
            btnClearFilters.Font = new Font("Segoe UI", 7F);
            btnClearFilters.Location = new Point(442, 100);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(32, 29);
            btnClearFilters.TabIndex = 16;
            btnClearFilters.Text = "X";
            btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // FilesListSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 254);
            Controls.Add(chkAddFolders);
            Controls.Add(btnClearFilters);
            Controls.Add(chkParseSubfolders);
            Controls.Add(chkShowProgressBar);
            Controls.Add(chkShowStatus);
            Controls.Add(tableLayoutPanelButtons);
            Controls.Add(lblFileFilters);
            Controls.Add(btnArchives);
            Controls.Add(btnImg);
            Controls.Add(btnYaml);
            Controls.Add(txtFileFilters);
            Margin = new Padding(2);
            Name = "FilesListSettingsDialog";
            Text = "FilesList Settings";
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAddFolders;
        private CheckBox chkParseSubfolders;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkShowStatus;
        private CheckBox chkShowProgressBar;
        private TableLayoutPanel tableLayoutPanelButtons;
        private TextBox txtFileFilters;
        private Button btnYaml;
        private Button btnImg;
        private Button btnArchives;
        private Label lblFileFilters;
        private Button btnClearFilters;
    }
}
