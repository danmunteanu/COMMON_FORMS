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
            txtPath = new TextBox();
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
            lblPath.Location = new Point(3, 40);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(132, 25);
            lblPath.TabIndex = 0;
            lblPath.Text = "Copy to folder:";
            // 
            // txtPath
            // 
            txtPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPath.Location = new Point(3, 72);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(501, 31);
            txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBrowse.Location = new Point(510, 68);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(114, 39);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayout.Controls.Add(btnBrowse, 1, 1);
            tableLayout.Controls.Add(txtPath, 0, 1);
            tableLayout.Controls.Add(lblPath, 0, 0);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
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
        private TextBox txtPath;
        private Button btnBrowse;
        private TableLayoutPanel tableLayout;
        private FolderBrowserDialog mFolderBrowserDialog;
    }
}
