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
            chkPrefix = new CheckBox();
            chkExtension = new CheckBox();
            chkCustom = new CheckBox();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPrefix = new TableLayoutPanel();
            tableLayoutPanelExt = new TableLayoutPanel();
            btnClearExt = new Button();
            btnMD = new Button();
            btnTxt = new Button();
            tableLayoutDatePrefix = new TableLayoutPanel();
            dpDate = new DateTimePicker();
            btnUseDate = new Button();
            tableLayoutMain.SuspendLayout();
            tableLayoutPrefix.SuspendLayout();
            tableLayoutPanelExt.SuspendLayout();
            tableLayoutDatePrefix.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrefix
            // 
            txtPrefix.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrefix.Location = new Point(3, 3);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(580, 27);
            txtPrefix.TabIndex = 1;
            // 
            // txtExtension
            // 
            txtExtension.Dock = DockStyle.Fill;
            txtExtension.Location = new Point(3, 3);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(164, 27);
            txtExtension.TabIndex = 3;
            // 
            // txtCustom
            // 
            txtCustom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustom.Location = new Point(3, 279);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(586, 27);
            txtCustom.TabIndex = 4;
            // 
            // chkPrefix
            // 
            chkPrefix.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkPrefix.AutoSize = true;
            chkPrefix.Location = new Point(3, 13);
            chkPrefix.Name = "chkPrefix";
            chkPrefix.Size = new Size(103, 24);
            chkPrefix.TabIndex = 6;
            chkPrefix.Text = "Add Prefix:";
            chkPrefix.UseVisualStyleBackColor = true;
            chkPrefix.CheckedChanged += chkAddPrefix_CheckedChanged;
            // 
            // chkExtension
            // 
            chkExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkExtension.AutoSize = true;
            chkExtension.Location = new Point(3, 148);
            chkExtension.Name = "chkExtension";
            chkExtension.Size = new Size(151, 24);
            chkExtension.TabIndex = 7;
            chkExtension.Text = "Change Extension:";
            chkExtension.UseVisualStyleBackColor = true;
            chkExtension.CheckedChanged += chkNewExt_CheckedChanged;
            // 
            // chkCustom
            // 
            chkCustom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkCustom.AutoSize = true;
            chkCustom.Location = new Point(3, 243);
            chkCustom.Name = "chkCustom";
            chkCustom.Size = new Size(128, 24);
            chkCustom.TabIndex = 8;
            chkCustom.Text = "Custom Name:";
            chkCustom.UseVisualStyleBackColor = true;
            chkCustom.CheckedChanged += chkCustom_CheckedChanged;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutPrefix, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutPanelExt, 0, 4);
            tableLayoutMain.Controls.Add(chkPrefix, 0, 0);
            tableLayoutMain.Controls.Add(chkExtension, 0, 4);
            tableLayoutMain.Controls.Add(chkCustom, 0, 7);
            tableLayoutMain.Controls.Add(txtCustom, 0, 8);
            tableLayoutMain.Controls.Add(tableLayoutDatePrefix, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 10;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(592, 408);
            tableLayoutMain.TabIndex = 9;
            // 
            // tableLayoutPrefix
            // 
            tableLayoutPrefix.ColumnCount = 1;
            tableLayoutPrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPrefix.Controls.Add(txtPrefix, 0, 0);
            tableLayoutPrefix.Dock = DockStyle.Fill;
            tableLayoutPrefix.Location = new Point(3, 43);
            tableLayoutPrefix.Name = "tableLayoutPrefix";
            tableLayoutPrefix.RowCount = 1;
            tableLayoutPrefix.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPrefix.Size = new Size(586, 34);
            tableLayoutPrefix.TabIndex = 15;
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
            tableLayoutPanelExt.Location = new Point(3, 178);
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
            // tableLayoutDatePrefix
            // 
            tableLayoutDatePrefix.ColumnCount = 3;
            tableLayoutDatePrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutDatePrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 285F));
            tableLayoutDatePrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDatePrefix.Controls.Add(dpDate, 1, 0);
            tableLayoutDatePrefix.Controls.Add(btnUseDate, 0, 0);
            tableLayoutDatePrefix.Dock = DockStyle.Fill;
            tableLayoutDatePrefix.Location = new Point(3, 83);
            tableLayoutDatePrefix.Name = "tableLayoutDatePrefix";
            tableLayoutDatePrefix.RowCount = 1;
            tableLayoutDatePrefix.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDatePrefix.Size = new Size(586, 34);
            tableLayoutDatePrefix.TabIndex = 16;
            // 
            // dpDate
            // 
            dpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dpDate.Location = new Point(93, 3);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(279, 27);
            dpDate.TabIndex = 14;
            // 
            // btnUseDate
            // 
            btnUseDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUseDate.Font = new Font("Segoe UI", 8F);
            btnUseDate.Location = new Point(3, 3);
            btnUseDate.Name = "btnUseDate";
            btnUseDate.Size = new Size(84, 28);
            btnUseDate.TabIndex = 10;
            btnUseDate.Text = "USE DATE";
            btnUseDate.UseVisualStyleBackColor = true;
            btnUseDate.Click += btnUseDate_Click;
            // 
            // EditorRenameFile
            // 
            Controls.Add(tableLayoutMain);
            Name = "EditorRenameFile";
            Size = new Size(592, 408);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutPrefix.ResumeLayout(false);
            tableLayoutPrefix.PerformLayout();
            tableLayoutPanelExt.ResumeLayout(false);
            tableLayoutPanelExt.PerformLayout();
            tableLayoutDatePrefix.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPrefix;
        private TextBox txtExtension;
        private TextBox txtCustom;
        private CheckBox chkPrefix;
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
        private TableLayoutPanel tableLayoutDatePrefix;
    }
}
