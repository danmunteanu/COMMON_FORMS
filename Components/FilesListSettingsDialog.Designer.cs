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
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelButtons = new TableLayoutPanel();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // chkAddFolders
            // 
            chkAddFolders.Anchor = AnchorStyles.Left;
            chkAddFolders.AutoSize = true;
            chkAddFolders.Location = new Point(12, 15);
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
            chkParseSubfolders.Location = new Point(12, 50);
            chkParseSubfolders.Margin = new Padding(2);
            chkParseSubfolders.Name = "chkParseSubfolders";
            chkParseSubfolders.Size = new Size(173, 24);
            chkParseSubfolders.TabIndex = 2;
            chkParseSubfolders.Text = "Also Parse Subfolders";
            chkParseSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(255, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 33);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(165, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 33);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkShowStatus
            // 
            chkShowStatus.AutoSize = true;
            chkShowStatus.Location = new Point(13, 93);
            chkShowStatus.Name = "chkShowStatus";
            chkShowStatus.Size = new Size(125, 24);
            chkShowStatus.TabIndex = 5;
            chkShowStatus.Text = "Use Status Bar";
            chkShowStatus.UseVisualStyleBackColor = true;
            // 
            // chkShowProgressBar
            // 
            chkShowProgressBar.AutoSize = true;
            chkShowProgressBar.Location = new Point(13, 128);
            chkShowProgressBar.Name = "chkShowProgressBar";
            chkShowProgressBar.Size = new Size(141, 24);
            chkShowProgressBar.TabIndex = 6;
            chkShowProgressBar.Text = "Use Progress Bar";
            chkShowProgressBar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelButtons, 1, 7);
            tableLayoutPanelMain.Controls.Add(chkAddFolders, 1, 1);
            tableLayoutPanelMain.Controls.Add(chkShowProgressBar, 1, 5);
            tableLayoutPanelMain.Controls.Add(chkParseSubfolders, 1, 2);
            tableLayoutPanelMain.Controls.Add(chkShowStatus, 1, 4);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 9;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanelMain.Size = new Size(368, 243);
            tableLayoutPanelMain.TabIndex = 7;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 3;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelButtons.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnSave, 1, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(13, 191);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(342, 39);
            tableLayoutPanelButtons.TabIndex = 8;
            // 
            // FilesListSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 243);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(2);
            Name = "FilesListSettingsDialog";
            Text = "LIST Settings";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkAddFolders;
        private CheckBox chkParseSubfolders;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkShowStatus;
        private CheckBox chkShowProgressBar;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelButtons;
    }
}
