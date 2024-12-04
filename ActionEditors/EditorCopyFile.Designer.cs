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
            mFolderBrowserDialog = new FolderBrowserDialog();
            tableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // lblPath
            // 
            lblPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPath.AutoSize = true;
            lblPath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPath.Location = new Point(3, 25);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(102, 20);
            lblPath.TabIndex = 0;
            lblPath.Text = "Copy to folder:";
            // 
            // txtFolder
            // 
            txtFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Location = new Point(3, 54);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(536, 27);
            txtFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBrowse.Font = new Font("Segoe UI", 7F);
            btnBrowse.Location = new Point(545, 51);
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
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout.Controls.Add(txtFolder, 0, 1);
            tableLayout.Controls.Add(lblPath, 0, 0);
            tableLayout.Controls.Add(btnBrowse, 1, 1);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout.Size = new Size(627, 176);
            tableLayout.TabIndex = 3;
            // 
            // EditorCopyFile
            // 
            Controls.Add(tableLayout);
            Name = "EditorCopyFile";
            Size = new Size(627, 176);
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
    }
}
