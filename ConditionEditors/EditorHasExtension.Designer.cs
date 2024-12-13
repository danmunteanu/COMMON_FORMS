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
            lblAddExtension.Anchor = AnchorStyles.Left;
            lblAddExtension.AutoSize = true;
            lblAddExtension.Location = new Point(3, 12);
            lblAddExtension.Name = "lblAddExtension";
            lblAddExtension.Size = new Size(72, 20);
            lblAddExtension.TabIndex = 0;
            lblAddExtension.Text = "Extension";
            // 
            // txtExt
            // 
            txtExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtExt.Location = new Point(3, 54);
            txtExt.Name = "txtExt";
            txtExt.Size = new Size(462, 27);
            txtExt.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(471, 53);
            btnAddExt.Name = "btnAddExt";
            btnAddExt.Size = new Size(59, 29);
            btnAddExt.TabIndex = 2;
            btnAddExt.Text = "ADD";
            btnAddExt.UseVisualStyleBackColor = true;
            btnAddExt.Click += btnAddExt_Click;
            // 
            // btnClearExt
            // 
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(3, 272);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(53, 22);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // lstExtensions
            // 
            lstExtensions.Dock = DockStyle.Fill;
            lstExtensions.FormattingEnabled = true;
            lstExtensions.Location = new Point(3, 128);
            lstExtensions.Name = "lstExtensions";
            lstExtensions.Size = new Size(462, 297);
            lstExtensions.TabIndex = 4;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(3, 105);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(98, 20);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extension List";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Controls.Add(btnAddExt, 1, 1);
            tableLayoutPanel.Controls.Add(lstExtensions, 0, 3);
            tableLayoutPanel.Controls.Add(lblExtensionList, 0, 2);
            tableLayoutPanel.Controls.Add(txtExt, 0, 1);
            tableLayoutPanel.Controls.Add(lblAddExtension, 0, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel.Size = new Size(573, 473);
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
            tableLayoutPanel1.Location = new Point(471, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(59, 297);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPdf.Font = new Font("Segoe UI", 7F);
            btnPdf.Location = new Point(3, 59);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(53, 22);
            btnPdf.TabIndex = 8;
            btnPdf.Text = "pdf";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnMd
            // 
            btnMd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMd.Font = new Font("Segoe UI", 7F);
            btnMd.Location = new Point(3, 31);
            btnMd.Name = "btnMd";
            btnMd.Size = new Size(53, 22);
            btnMd.TabIndex = 7;
            btnMd.Text = "md";
            btnMd.UseVisualStyleBackColor = true;
            btnMd.Click += btnMd_Click;
            // 
            // btnTxt
            // 
            btnTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTxt.Font = new Font("Segoe UI", 7F);
            btnTxt.Location = new Point(3, 3);
            btnTxt.Name = "btnTxt";
            btnTxt.Size = new Size(53, 22);
            btnTxt.TabIndex = 6;
            btnTxt.Text = "txt";
            btnTxt.UseVisualStyleBackColor = true;
            btnTxt.Click += btnTxt_Click;
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutPanel);
            Name = "EditorHasExtension";
            Size = new Size(573, 473);
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
