namespace CommonForms
{
    partial class EditorMergeFiles
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
            lblMergeFileName = new Label();
            txtMergeName = new TextBox();
            btnSelectName = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dlgSaveFile = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMergeFileName
            // 
            lblMergeFileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMergeFileName.AutoSize = true;
            lblMergeFileName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMergeFileName.Location = new Point(2, 25);
            lblMergeFileName.Margin = new Padding(2, 0, 2, 0);
            lblMergeFileName.Name = "lblMergeFileName";
            lblMergeFileName.Size = new Size(161, 20);
            lblMergeFileName.TabIndex = 1;
            lblMergeFileName.Text = "Select Merge File Name:";
            // 
            // txtMergeName
            // 
            txtMergeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMergeName.Enabled = false;
            txtMergeName.Location = new Point(2, 59);
            txtMergeName.Margin = new Padding(2);
            txtMergeName.Name = "txtMergeName";
            txtMergeName.ReadOnly = true;
            txtMergeName.Size = new Size(469, 27);
            txtMergeName.TabIndex = 2;
            // 
            // btnSelectName
            // 
            btnSelectName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectName.Font = new Font("Segoe UI", 7F);
            btnSelectName.Location = new Point(475, 59);
            btnSelectName.Margin = new Padding(2);
            btnSelectName.Name = "btnSelectName";
            btnSelectName.Size = new Size(71, 27);
            btnSelectName.TabIndex = 3;
            btnSelectName.Text = "SELECT";
            btnSelectName.UseVisualStyleBackColor = true;
            btnSelectName.Click += btnSelectMergeName_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnSelectName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtMergeName, 0, 1);
            tableLayoutPanel1.Controls.Add(lblMergeFileName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(548, 247);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // EditorMergeFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "EditorMergeFiles";
            Size = new Size(548, 247);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblMergeFileName;
        private TextBox txtMergeName;
        private Button btnSelectName;
        private TableLayoutPanel tableLayoutPanel1;
        private SaveFileDialog dlgSaveFile;
    }
}
