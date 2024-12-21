namespace CommonForms
{
    partial class EditorHasExtension
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
            lblAddExtension = new Label();
            txtExt = new TextBox();
            btnAddExt = new Button();
            btnClearExt = new Button();
            lstExtensions = new ListBox();
            lblExtensionList = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPdf = new Button();
            btnMd = new Button();
            btnTxt = new Button();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddExtension
            // 
            lblAddExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddExtension.AutoSize = true;
            lblAddExtension.Location = new Point(11, 5);
            lblAddExtension.Name = "lblAddExtension";
            lblAddExtension.Size = new Size(87, 25);
            lblAddExtension.TabIndex = 0;
            lblAddExtension.Text = "Extension";
            // 
            // txtExt
            // 
            txtExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtExt.Location = new Point(11, 33);
            txtExt.Name = "txtExt";
            txtExt.Size = new Size(144, 31);
            txtExt.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(161, 33);
            btnAddExt.Name = "btnAddExt";
            btnAddExt.Size = new Size(65, 24);
            btnAddExt.TabIndex = 2;
            btnAddExt.Text = "ADD";
            btnAddExt.UseVisualStyleBackColor = true;
            btnAddExt.Click += btnAddExt_Click;
            // 
            // btnClearExt
            // 
            btnClearExt.Dock = DockStyle.Fill;
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(3, 185);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(59, 29);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // lstExtensions
            // 
            lstExtensions.Dock = DockStyle.Fill;
            lstExtensions.FormattingEnabled = true;
            lstExtensions.ItemHeight = 25;
            lstExtensions.Location = new Point(11, 92);
            lstExtensions.Name = "lstExtensions";
            lstExtensions.Size = new Size(144, 217);
            lstExtensions.TabIndex = 4;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(11, 64);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(118, 25);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extension List";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel.Controls.Add(lstExtensions, 1, 3);
            tableLayoutPanel.Controls.Add(lblExtensionList, 1, 2);
            tableLayoutPanel.Controls.Add(lblAddExtension, 1, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 3);
            tableLayoutPanel.Controls.Add(btnAddExt, 2, 1);
            tableLayoutPanel.Controls.Add(txtExt, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel.Size = new Size(276, 338);
            tableLayoutPanel.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnClearExt, 0, 4);
            tableLayoutPanel1.Controls.Add(btnPdf, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMd, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTxt, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(161, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(65, 217);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnPdf
            // 
            btnPdf.Dock = DockStyle.Fill;
            btnPdf.Font = new Font("Segoe UI", 7F);
            btnPdf.Location = new Point(3, 73);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(59, 29);
            btnPdf.TabIndex = 8;
            btnPdf.Text = "pdf";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnMd
            // 
            btnMd.Dock = DockStyle.Fill;
            btnMd.Font = new Font("Segoe UI", 7F);
            btnMd.Location = new Point(3, 38);
            btnMd.Name = "btnMd";
            btnMd.Size = new Size(59, 29);
            btnMd.TabIndex = 7;
            btnMd.Text = "md";
            btnMd.UseVisualStyleBackColor = true;
            btnMd.Click += btnMd_Click;
            // 
            // btnTxt
            // 
            btnTxt.Dock = DockStyle.Fill;
            btnTxt.Font = new Font("Segoe UI", 7F);
            btnTxt.Location = new Point(3, 3);
            btnTxt.Name = "btnTxt";
            btnTxt.Size = new Size(59, 29);
            btnTxt.TabIndex = 6;
            btnTxt.Text = "txt";
            btnTxt.UseVisualStyleBackColor = true;
            btnTxt.Click += btnTxt_Click;
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutPanel);
            Name = "EditorHasExtension";
            Size = new Size(276, 338);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAddExtension;
        private TextBox txtExt;
        private Button btnAddExt;
        private Button btnClearExt;
        private ListBox lstExtensions;
        private Label lblExtensionList;
        private TableLayoutPanel tableLayoutPanel;
        private Button btnTxt;
        private Button btnMd;
        private Button btnPdf;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
