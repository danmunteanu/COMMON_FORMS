﻿namespace CommonForms
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
            components = new System.ComponentModel.Container();
            txtPrefix = new TextBox();
            txtExtension = new TextBox();
            txtCustom = new TextBox();
            chkAddPrefix = new CheckBox();
            chkChangeExtension = new CheckBox();
            chkCustomName = new CheckBox();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPrefix = new TableLayoutPanel();
            tableLayoutPanelExt = new TableLayoutPanel();
            btnClearExt = new Button();
            btnExtensions = new Button();
            tableLayoutDatePrefix = new TableLayoutPanel();
            dpDate = new DateTimePicker();
            btnUseDate = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            chkRemovePrefix = new CheckBox();
            menuStripExtensions = new ContextMenuStrip(components);
            tableLayoutMain.SuspendLayout();
            tableLayoutPrefix.SuspendLayout();
            tableLayoutPanelExt.SuspendLayout();
            tableLayoutDatePrefix.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            // chkAddPrefix
            // 
            chkAddPrefix.Anchor = AnchorStyles.Left;
            chkAddPrefix.AutoSize = true;
            chkAddPrefix.Location = new Point(3, 3);
            chkAddPrefix.Name = "chkAddPrefix";
            chkAddPrefix.Size = new Size(103, 24);
            chkAddPrefix.TabIndex = 6;
            chkAddPrefix.Text = "Add Prefix:";
            chkAddPrefix.UseVisualStyleBackColor = true;
            chkAddPrefix.CheckedChanged += chkAddPrefix_CheckedChanged;
            // 
            // chkChangeExtension
            // 
            chkChangeExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkChangeExtension.AutoSize = true;
            chkChangeExtension.Location = new Point(3, 148);
            chkChangeExtension.Name = "chkChangeExtension";
            chkChangeExtension.Size = new Size(151, 24);
            chkChangeExtension.TabIndex = 7;
            chkChangeExtension.Text = "Change Extension:";
            chkChangeExtension.UseVisualStyleBackColor = true;
            chkChangeExtension.CheckedChanged += chkNewExt_CheckedChanged;
            // 
            // chkCustomName
            // 
            chkCustomName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkCustomName.AutoSize = true;
            chkCustomName.Location = new Point(3, 243);
            chkCustomName.Name = "chkCustomName";
            chkCustomName.Size = new Size(128, 24);
            chkCustomName.TabIndex = 8;
            chkCustomName.Text = "Custom Name:";
            chkCustomName.UseVisualStyleBackColor = true;
            chkCustomName.CheckedChanged += chkCustom_CheckedChanged;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutPrefix, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutPanelExt, 0, 4);
            tableLayoutMain.Controls.Add(chkChangeExtension, 0, 4);
            tableLayoutMain.Controls.Add(chkCustomName, 0, 7);
            tableLayoutMain.Controls.Add(txtCustom, 0, 8);
            tableLayoutMain.Controls.Add(tableLayoutDatePrefix, 0, 2);
            tableLayoutMain.Controls.Add(flowLayoutPanel1, 0, 0);
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
            tableLayoutPanelExt.ColumnCount = 4;
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanelExt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelExt.Controls.Add(txtExtension, 0, 0);
            tableLayoutPanelExt.Controls.Add(btnClearExt, 1, 0);
            tableLayoutPanelExt.Controls.Add(btnExtensions, 2, 0);
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
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(173, 3);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(31, 28);
            btnClearExt.TabIndex = 11;
            btnClearExt.Text = "X";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // btnExtensions
            // 
            btnExtensions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnExtensions.Font = new Font("Segoe UI", 7F);
            btnExtensions.Location = new Point(210, 3);
            btnExtensions.Name = "btnExtensions";
            btnExtensions.Size = new Size(41, 28);
            btnExtensions.TabIndex = 14;
            btnExtensions.Text = "EXT";
            btnExtensions.UseVisualStyleBackColor = true;
            btnExtensions.Click += btnExtensions_Click;
            // 
            // tableLayoutDatePrefix
            // 
            tableLayoutDatePrefix.ColumnCount = 3;
            tableLayoutDatePrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutDatePrefix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 332F));
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
            dpDate.Location = new Point(128, 3);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(326, 27);
            dpDate.TabIndex = 14;
            // 
            // btnUseDate
            // 
            btnUseDate.Dock = DockStyle.Fill;
            btnUseDate.Font = new Font("Segoe UI", 8F);
            btnUseDate.Location = new Point(3, 3);
            btnUseDate.Name = "btnUseDate";
            btnUseDate.Size = new Size(119, 28);
            btnUseDate.TabIndex = 10;
            btnUseDate.Text = "USE DATE";
            btnUseDate.UseVisualStyleBackColor = true;
            btnUseDate.Click += btnUseDate_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(chkAddPrefix);
            flowLayoutPanel1.Controls.Add(chkRemovePrefix);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(586, 34);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // chkRemovePrefix
            // 
            chkRemovePrefix.AutoSize = true;
            chkRemovePrefix.Location = new Point(112, 3);
            chkRemovePrefix.Name = "chkRemovePrefix";
            chkRemovePrefix.Size = new Size(126, 24);
            chkRemovePrefix.TabIndex = 15;
            chkRemovePrefix.Text = "Remove Prefix";
            chkRemovePrefix.UseVisualStyleBackColor = true;
            chkRemovePrefix.CheckedChanged += chkRemovePrefix_CheckedChanged;
            // 
            // menuStripExtensions
            // 
            menuStripExtensions.ImageScalingSize = new Size(20, 20);
            menuStripExtensions.Name = "menuStripExtensions";
            menuStripExtensions.Size = new Size(61, 4);
            // 
            // EditorRenameFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPrefix;
        private TextBox txtExtension;
        private TextBox txtCustom;
        private CheckBox chkAddPrefix;
        private CheckBox chkChangeExtension;
        private CheckBox chkCustomName;
        private TableLayoutPanel tableLayoutMain;
        private Button btnUseDate;
        private Button btnClearExt;
        private DateTimePicker dpDate;
        private TableLayoutPanel tableLayoutPanelExt;
        private TableLayoutPanel tableLayoutPrefix;
        private TableLayoutPanel tableLayoutDatePrefix;
        private CheckBox chkRemovePrefix;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnExtensions;
        private ContextMenuStrip menuStripExtensions;
    }
}
