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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMergeFileName
            // 
            lblMergeFileName.Anchor = AnchorStyles.Right;
            lblMergeFileName.AutoSize = true;
            lblMergeFileName.Location = new Point(2, 17);
            lblMergeFileName.Margin = new Padding(2, 0, 2, 0);
            lblMergeFileName.Name = "lblMergeFileName";
            lblMergeFileName.Size = new Size(126, 20);
            lblMergeFileName.TabIndex = 1;
            lblMergeFileName.Text = "Merge File Name:";
            // 
            // txtMergeName
            // 
            txtMergeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMergeName.Location = new Point(132, 14);
            txtMergeName.Margin = new Padding(2, 2, 2, 2);
            txtMergeName.Name = "txtMergeName";
            txtMergeName.Size = new Size(339, 27);
            txtMergeName.TabIndex = 2;
            // 
            // btnSelectName
            // 
            btnSelectName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectName.Font = new Font("Segoe UI", 7F);
            btnSelectName.Location = new Point(475, 14);
            btnSelectName.Margin = new Padding(2, 2, 2, 2);
            btnSelectName.Name = "btnSelectName";
            btnSelectName.Size = new Size(71, 27);
            btnSelectName.TabIndex = 3;
            btnSelectName.Text = "SELECT";
            btnSelectName.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Controls.Add(btnSelectName, 2, 0);
            tableLayoutPanel1.Controls.Add(txtMergeName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblMergeFileName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
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
    }
}
