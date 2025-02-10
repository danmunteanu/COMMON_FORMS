namespace CommonForms
{
    partial class EditorCopyFile
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
            lblPath = new Label();
            txtFolder = new TextBox();
            btnBrowse = new Button();
            tableLayout = new TableLayoutPanel();
            cmbDuplicates = new ComboBox();
            lblPolicy = new Label();
            mFolderBrowserDialog = new FolderBrowserDialog();
            tableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // lblPath
            // 
            lblPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPath.AutoSize = true;
            lblPath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPath.Location = new Point(3, 110);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(128, 25);
            lblPath.TabIndex = 0;
            lblPath.Text = "Copy to folder:";
            // 
            // txtFolder
            // 
            txtFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Location = new Point(3, 142);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(536, 31);
            txtFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBrowse.Font = new Font("Segoe UI", 7F);
            btnBrowse.Location = new Point(545, 141);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(79, 33);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayout.Controls.Add(txtFolder, 0, 2);
            tableLayout.Controls.Add(btnBrowse, 1, 2);
            tableLayout.Controls.Add(lblPath, 0, 1);
            tableLayout.Controls.Add(cmbDuplicates, 0, 4);
            tableLayout.Controls.Add(lblPolicy, 0, 3);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 6;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.Size = new Size(627, 360);
            tableLayout.TabIndex = 3;
            // 
            // cmbDuplicates
            // 
            cmbDuplicates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuplicates.FormattingEnabled = true;
            cmbDuplicates.Items.AddRange(new object[] { "Overwrite", "AutoRename" });
            cmbDuplicates.Location = new Point(3, 228);
            cmbDuplicates.Name = "cmbDuplicates";
            cmbDuplicates.Size = new Size(182, 33);
            cmbDuplicates.TabIndex = 3;
            // 
            // lblPolicy
            // 
            lblPolicy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPolicy.AutoSize = true;
            lblPolicy.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPolicy.Location = new Point(3, 200);
            lblPolicy.Name = "lblPolicy";
            lblPolicy.Size = new Size(139, 25);
            lblPolicy.TabIndex = 4;
            lblPolicy.Text = "With duplicates:";
            // 
            // EditorCopyFile
            // 
            Controls.Add(tableLayout);
            Name = "EditorCopyFile";
            Size = new Size(627, 360);
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPath;
        private TextBox txtFolder;
        private Button btnBrowse;
        private TableLayoutPanel tableLayout;
        private FolderBrowserDialog mFolderBrowserDialog;
        private ComboBox cmbDuplicates;
        private Label lblPolicy;
    }
}
