namespace CommonForms
{
    partial class EditorRenameFile
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
            txtPrefix = new TextBox();
            txtExtension = new TextBox();
            txtCustom = new TextBox();
            chkAddPrefix = new CheckBox();
            chkExtension = new CheckBox();
            chkCustom = new CheckBox();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPrefix = new TableLayoutPanel();
            dpDate = new DateTimePicker();
            btnUseDate = new Button();
            tableLayoutPanelExt = new TableLayoutPanel();
            btnClearExt = new Button();
            btnTxt = new Button();
            btnMD = new Button();
            tableLayoutMain.SuspendLayout();
            tableLayoutPrefix.SuspendLayout();
            tableLayoutPanelExt.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrefix
            // 
            txtPrefix.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrefix.Location = new Point(98, 3);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(185, 31);
            txtPrefix.TabIndex = 1;
            // 
            // txtExtension
            // 
            txtExtension.Dock = DockStyle.Fill;
            txtExtension.Location = new Point(3, 3);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(164, 31);
            txtExtension.TabIndex = 3;
            // 
            // txtCustom
            // 
            txtCustom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustom.Location = new Point(3, 207);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(586, 31);
            txtCustom.TabIndex = 4;
            // 
            // chkAddPrefix
            // 
            chkAddPrefix.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkAddPrefix.AutoSize = true;
            chkAddPrefix.Location = new Point(3, 8);
            chkAddPrefix.Name = "chkAddPrefix";
            chkAddPrefix.Size = new Size(124, 29);
            chkAddPrefix.TabIndex = 6;
            chkAddPrefix.Text = "Add Prefix:";
            chkAddPrefix.UseVisualStyleBackColor = true;
            chkAddPrefix.CheckedChanged += chkAddPrefix_CheckedChanged;
            // 
            // chkExtension
            // 
            chkExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkExtension.AutoSize = true;
            chkExtension.Location = new Point(3, 88);
            chkExtension.Name = "chkExtension";
            chkExtension.Size = new Size(182, 29);
            chkExtension.TabIndex = 7;
            chkExtension.Text = "Change Extension:";
            chkExtension.UseVisualStyleBackColor = true;
            chkExtension.CheckedChanged += chkNewExt_CheckedChanged;
            // 
            // chkCustom
            // 
            chkCustom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkCustom.AutoSize = true;
            chkCustom.Location = new Point(3, 168);
            chkCustom.Name = "chkCustom";
            chkCustom.Size = new Size(104, 29);
            chkCustom.TabIndex = 8;
            chkCustom.Text = "Custom:";
            chkCustom.UseVisualStyleBackColor = true;
            chkCustom.CheckedChanged += chkCustom_CheckedChanged;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutPrefix, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutPanelExt, 0, 3);
            tableLayoutMain.Controls.Add(chkAddPrefix, 0, 0);
            tableLayoutMain.Controls.Add(chkExtension, 0, 2);
            tableLayoutMain.Controls.Add(chkCustom, 0, 4);
            tableLayoutMain.Controls.Add(txtCustom, 0, 5);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 7;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(592, 693);
            tableLayoutMain.TabIndex = 9;
            // 
            // tableLayoutPrefix
            // 
            tableLayoutPrefix.ColumnCount = 3;
            tableLayoutPrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPrefix.Controls.Add(dpDate, 2, 0);
            tableLayoutPrefix.Controls.Add(txtPrefix, 1, 0);
            tableLayoutPrefix.Controls.Add(btnUseDate, 0, 0);
            tableLayoutPrefix.Dock = DockStyle.Fill;
            tableLayoutPrefix.Location = new Point(3, 43);
            tableLayoutPrefix.Name = "tableLayoutPrefix";
            tableLayoutPrefix.RowCount = 1;
            tableLayoutPrefix.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPrefix.Size = new Size(586, 34);
            tableLayoutPrefix.TabIndex = 15;
            // 
            // dpDate
            // 
            dpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dpDate.Location = new Point(289, 3);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(294, 31);
            dpDate.TabIndex = 14;
            // 
            // btnUseDate
            // 
            btnUseDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUseDate.Font = new Font("Segoe UI", 8F);
            btnUseDate.Location = new Point(3, 3);
            btnUseDate.Name = "btnUseDate";
            btnUseDate.Size = new Size(89, 28);
            btnUseDate.TabIndex = 10;
            btnUseDate.Text = "USE DATE";
            btnUseDate.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelExt
            // 
            tableLayoutPanelExt.ColumnCount = 5;
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelExt.Controls.Add(txtExtension, 0, 0);
            tableLayoutPanelExt.Controls.Add(btnClearExt, 3, 0);
            tableLayoutPanelExt.Controls.Add(btnMD, 2, 0);
            tableLayoutPanelExt.Controls.Add(btnTxt, 1, 0);
            tableLayoutPanelExt.Dock = DockStyle.Fill;
            tableLayoutPanelExt.Location = new Point(3, 123);
            tableLayoutPanelExt.Name = "tableLayoutPanelExt";
            tableLayoutPanelExt.RowCount = 1;
            tableLayoutPanelExt.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelExt.Size = new Size(586, 34);
            tableLayoutPanelExt.TabIndex = 15;
            // 
            // btnClearExt
            // 
            btnClearExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClearExt.Font = new Font("Segoe UI", 8F);
            btnClearExt.Location = new Point(273, 3);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(49, 28);
            btnClearExt.TabIndex = 11;
            btnClearExt.Text = "X";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // btnTxt
            // 
            btnTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTxt.Font = new Font("Segoe UI", 8F);
            btnTxt.Location = new Point(173, 3);
            btnTxt.Name = "btnTxt";
            btnTxt.Size = new Size(39, 28);
            btnTxt.TabIndex = 12;
            btnTxt.Text = ".txt";
            btnTxt.UseVisualStyleBackColor = true;
            btnTxt.Click += btnTxt_Click;
            // 
            // btnMD
            // 
            btnMD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMD.Font = new Font("Segoe UI", 8F);
            btnMD.Location = new Point(218, 3);
            btnMD.Name = "btnMD";
            btnMD.Size = new Size(49, 28);
            btnMD.TabIndex = 13;
            btnMD.Text = ".md";
            btnMD.UseVisualStyleBackColor = true;
            btnMD.Click += btnMD_Click;
            // 
            // EditorRenameFile
            // 
            Controls.Add(tableLayoutMain);
            Name = "EditorRenameFile";
            Size = new Size(592, 693);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutPrefix.ResumeLayout(false);
            tableLayoutPrefix.PerformLayout();
            tableLayoutPanelExt.ResumeLayout(false);
            tableLayoutPanelExt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPrefix;
        private TextBox txtExtension;
        private TextBox txtCustom;
        private CheckBox chkAddPrefix;
        private CheckBox chkExtension;
        private CheckBox chkCustom;
        private TableLayoutPanel tableLayoutMain;
        private Button btnUseDate;
        private Button btnClearExt;
        private Button btnTxt;
        private Button btnMD;
        private DateTimePicker dpDate;
        private TableLayoutPanel tableLayoutPanelExt;
        private TableLayoutPanel tableLayoutPrefix;
    }
}
