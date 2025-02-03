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
            tableLayoutPanelLeft = new TableLayoutPanel();
            tableLayoutPanelBtn = new TableLayoutPanel();
            tableLayoutPanelExtensions = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanelRight = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            tableLayoutPanelBtn.SuspendLayout();
            tableLayoutPanelExtensions.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanelRight.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // chkAddFolders
            // 
            chkAddFolders.Anchor = AnchorStyles.Left;
            chkAddFolders.AutoSize = true;
            chkAddFolders.Location = new Point(2, 38);
            chkAddFolders.Margin = new Padding(2);
            chkAddFolders.Name = "chkAddFolders";
            chkAddFolders.Size = new Size(190, 29);
            chkAddFolders.TabIndex = 1;
            chkAddFolders.Text = "Allow Adding Folders";
            chkAddFolders.UseVisualStyleBackColor = true;
            chkAddFolders.CheckedChanged += chkAddFolders_CheckedChanged;
            // 
            // chkParseSubfolders
            // 
            chkParseSubfolders.Anchor = AnchorStyles.Left;
            chkParseSubfolders.AutoSize = true;
            chkParseSubfolders.Location = new Point(2, 148);
            chkParseSubfolders.Margin = new Padding(2);
            chkParseSubfolders.Name = "chkParseSubfolders";
            chkParseSubfolders.Size = new Size(170, 29);
            chkParseSubfolders.TabIndex = 2;
            chkParseSubfolders.Text = "Parse Subfolders";
            chkParseSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Segoe UI", 8F);
            btnCancel.Location = new Point(533, 4);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 32);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 8F);
            btnSave.Location = new Point(421, 4);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkShowStatus
            // 
            chkShowStatus.AutoSize = true;
            chkShowStatus.Location = new Point(4, 4);
            chkShowStatus.Margin = new Padding(4);
            chkShowStatus.Name = "chkShowStatus";
            chkShowStatus.Size = new Size(150, 27);
            chkShowStatus.TabIndex = 5;
            chkShowStatus.Text = "Use Status Bar";
            chkShowStatus.UseVisualStyleBackColor = true;
            // 
            // chkShowProgressBar
            // 
            chkShowProgressBar.AutoSize = true;
            chkShowProgressBar.Location = new Point(4, 114);
            chkShowProgressBar.Margin = new Padding(4);
            chkShowProgressBar.Name = "chkShowProgressBar";
            chkShowProgressBar.Size = new Size(171, 27);
            chkShowProgressBar.TabIndex = 6;
            chkShowProgressBar.Text = "Use Progress Bar";
            chkShowProgressBar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 3;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanelButtons.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnSave, 1, 0);
            tableLayoutPanelButtons.Location = new Point(26, 256);
            tableLayoutPanelButtons.Margin = new Padding(4);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(641, 40);
            tableLayoutPanelButtons.TabIndex = 8;
            // 
            // txtFileFilters
            // 
            txtFileFilters.Dock = DockStyle.Fill;
            txtFileFilters.Location = new Point(0, 0);
            txtFileFilters.Margin = new Padding(0);
            txtFileFilters.Multiline = true;
            txtFileFilters.Name = "txtFileFilters";
            txtFileFilters.ReadOnly = true;
            txtFileFilters.Size = new Size(262, 85);
            txtFileFilters.TabIndex = 11;
            // 
            // btnYaml
            // 
            btnYaml.Dock = DockStyle.Fill;
            btnYaml.Font = new Font("Segoe UI", 7F);
            btnYaml.Location = new Point(4, 4);
            btnYaml.Margin = new Padding(4);
            btnYaml.Name = "btnYaml";
            btnYaml.Size = new Size(61, 27);
            btnYaml.TabIndex = 12;
            btnYaml.Text = "YAML";
            btnYaml.UseVisualStyleBackColor = true;
            // 
            // btnImg
            // 
            btnImg.Dock = DockStyle.Fill;
            btnImg.Font = new Font("Segoe UI", 7F);
            btnImg.Location = new Point(4, 74);
            btnImg.Margin = new Padding(4);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(61, 27);
            btnImg.TabIndex = 13;
            btnImg.Text = "IMG";
            btnImg.UseVisualStyleBackColor = true;
            // 
            // btnArchives
            // 
            btnArchives.Dock = DockStyle.Fill;
            btnArchives.Font = new Font("Segoe UI", 7F);
            btnArchives.Location = new Point(4, 39);
            btnArchives.Margin = new Padding(4);
            btnArchives.Name = "btnArchives";
            btnArchives.Size = new Size(61, 27);
            btnArchives.TabIndex = 14;
            btnArchives.Text = "ARCH";
            btnArchives.UseVisualStyleBackColor = true;
            // 
            // lblFileFilters
            // 
            lblFileFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFileFilters.AutoSize = true;
            lblFileFilters.Location = new Point(79, 10);
            lblFileFilters.Margin = new Padding(4, 0, 4, 0);
            lblFileFilters.Name = "lblFileFilters";
            lblFileFilters.Size = new Size(93, 25);
            lblFileFilters.TabIndex = 15;
            lblFileFilters.Text = "File Filters:";
            // 
            // btnClearFilters
            // 
            btnClearFilters.Dock = DockStyle.Fill;
            btnClearFilters.Font = new Font("Segoe UI", 7F);
            btnClearFilters.Location = new Point(222, 0);
            btnClearFilters.Margin = new Padding(0);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(40, 35);
            btnClearFilters.TabIndex = 16;
            btnClearFilters.Text = "X";
            btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.ColumnCount = 1;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Controls.Add(chkShowStatus, 0, 0);
            tableLayoutPanelLeft.Controls.Add(chkAddFolders, 0, 1);
            tableLayoutPanelLeft.Controls.Add(chkParseSubfolders, 0, 4);
            tableLayoutPanelLeft.Controls.Add(chkShowProgressBar, 0, 3);
            tableLayoutPanelLeft.Dock = DockStyle.Fill;
            tableLayoutPanelLeft.Location = new Point(3, 3);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 6;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Size = new Size(194, 200);
            tableLayoutPanelLeft.TabIndex = 17;
            // 
            // tableLayoutPanelBtn
            // 
            tableLayoutPanelBtn.ColumnCount = 1;
            tableLayoutPanelBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBtn.Controls.Add(btnYaml, 0, 0);
            tableLayoutPanelBtn.Controls.Add(btnArchives, 0, 1);
            tableLayoutPanelBtn.Controls.Add(btnImg, 0, 2);
            tableLayoutPanelBtn.Dock = DockStyle.Fill;
            tableLayoutPanelBtn.Location = new Point(3, 38);
            tableLayoutPanelBtn.Name = "tableLayoutPanelBtn";
            tableLayoutPanelBtn.RowCount = 4;
            tableLayoutPanelBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBtn.Size = new Size(69, 159);
            tableLayoutPanelBtn.TabIndex = 18;
            // 
            // tableLayoutPanelExtensions
            // 
            tableLayoutPanelExtensions.ColumnCount = 1;
            tableLayoutPanelExtensions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelExtensions.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanelExtensions.Controls.Add(txtFileFilters, 0, 0);
            tableLayoutPanelExtensions.Dock = DockStyle.Fill;
            tableLayoutPanelExtensions.Location = new Point(78, 38);
            tableLayoutPanelExtensions.Name = "tableLayoutPanelExtensions";
            tableLayoutPanelExtensions.RowCount = 3;
            tableLayoutPanelExtensions.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanelExtensions.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelExtensions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelExtensions.Size = new Size(262, 159);
            tableLayoutPanelExtensions.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Controls.Add(btnClearFilters, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 85);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(262, 35);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // tableLayoutPanelRight
            // 
            tableLayoutPanelRight.ColumnCount = 2;
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Controls.Add(tableLayoutPanelBtn, 0, 1);
            tableLayoutPanelRight.Controls.Add(tableLayoutPanelExtensions, 1, 1);
            tableLayoutPanelRight.Controls.Add(lblFileFilters, 1, 0);
            tableLayoutPanelRight.Dock = DockStyle.Fill;
            tableLayoutPanelRight.Location = new Point(295, 3);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 2;
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Size = new Size(343, 200);
            tableLayoutPanelRight.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 349F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanelLeft, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanelRight, 2, 0);
            tableLayoutPanel3.Location = new Point(26, 29);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(641, 206);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // FilesListSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 316);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanelButtons);
            Margin = new Padding(2);
            Name = "FilesListSettingsDialog";
            Text = "FilesList Settings";
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelLeft.ResumeLayout(false);
            tableLayoutPanelLeft.PerformLayout();
            tableLayoutPanelBtn.ResumeLayout(false);
            tableLayoutPanelExtensions.ResumeLayout(false);
            tableLayoutPanelExtensions.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanelRight.ResumeLayout(false);
            tableLayoutPanelRight.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanelLeft;
        private TableLayoutPanel tableLayoutPanelBtn;
        private TableLayoutPanel tableLayoutPanelExtensions;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanelRight;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
