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
            tableLayoutPanelPrefixExt = new TableLayoutPanel();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelPrefixExt.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrefix
            // 
            txtPrefix.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrefix.Location = new Point(3, 42);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(174, 27);
            txtPrefix.TabIndex = 1;
            // 
            // txtExtension
            // 
            txtExtension.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtExtension.Location = new Point(183, 42);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(194, 27);
            txtExtension.TabIndex = 3;
            // 
            // txtCustom
            // 
            txtCustom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustom.Location = new Point(3, 129);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(596, 27);
            txtCustom.TabIndex = 4;
            // 
            // chkAddPrefix
            // 
            chkAddPrefix.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkAddPrefix.AutoSize = true;
            chkAddPrefix.Location = new Point(3, 10);
            chkAddPrefix.Name = "chkAddPrefix";
            chkAddPrefix.Size = new Size(103, 24);
            chkAddPrefix.TabIndex = 6;
            chkAddPrefix.Text = "Add Prefix:";
            chkAddPrefix.UseVisualStyleBackColor = true;
            chkAddPrefix.CheckedChanged += chkAddPrefix_CheckedChanged;
            // 
            // chkExtension
            // 
            chkExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkExtension.AutoSize = true;
            chkExtension.Location = new Point(183, 10);
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
            chkCustom.Location = new Point(3, 93);
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
            tableLayoutMain.Controls.Add(tableLayoutPanelPrefixExt, 1, 1);
            tableLayoutMain.Controls.Add(chkCustom, 0, 2);
            tableLayoutMain.Controls.Add(txtCustom, 0, 3);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(602, 260);
            tableLayoutMain.TabIndex = 9;
            // 
            // tableLayoutPanelPrefixExt
            // 
            tableLayoutPanelPrefixExt.ColumnCount = 3;
            tableLayoutPanelPrefixExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanelPrefixExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanelPrefixExt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrefixExt.Controls.Add(chkAddPrefix, 0, 0);
            tableLayoutPanelPrefixExt.Controls.Add(txtPrefix, 0, 1);
            tableLayoutPanelPrefixExt.Controls.Add(chkExtension, 1, 0);
            tableLayoutPanelPrefixExt.Controls.Add(txtExtension, 1, 1);
            tableLayoutPanelPrefixExt.Dock = DockStyle.Fill;
            tableLayoutPanelPrefixExt.Location = new Point(3, 3);
            tableLayoutPanelPrefixExt.Name = "tableLayoutPanelPrefixExt";
            tableLayoutPanelPrefixExt.RowCount = 2;
            tableLayoutPanelPrefixExt.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrefixExt.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrefixExt.Size = new Size(596, 74);
            tableLayoutPanelPrefixExt.TabIndex = 10;
            // 
            // EditorRenameFile
            // 
            Controls.Add(tableLayoutMain);
            Name = "EditorRenameFile";
            Size = new Size(602, 260);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutPanelPrefixExt.ResumeLayout(false);
            tableLayoutPanelPrefixExt.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanelPrefixExt;
    }
}
