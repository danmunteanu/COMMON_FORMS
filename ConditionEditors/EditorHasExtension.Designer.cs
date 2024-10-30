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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddExtension
            // 
            lblAddExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddExtension.AutoSize = true;
            lblAddExtension.Location = new Point(8, 15);
            lblAddExtension.Name = "lblAddExtension";
            lblAddExtension.Size = new Size(72, 20);
            lblAddExtension.TabIndex = 0;
            lblAddExtension.Text = "Extension";
            // 
            // txtExt
            // 
            txtExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtExt.Location = new Point(3, 6);
            txtExt.Name = "txtExt";
            txtExt.Size = new Size(486, 27);
            txtExt.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(495, 5);
            btnAddExt.Name = "btnAddExt";
            btnAddExt.Size = new Size(59, 29);
            btnAddExt.TabIndex = 2;
            btnAddExt.Text = "ADD";
            btnAddExt.UseVisualStyleBackColor = true;
            btnAddExt.Click += btnAddExt_Click;
            // 
            // btnClearExt
            // 
            btnClearExt.Anchor = AnchorStyles.Right;
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(503, 433);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(62, 29);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // lstExtensions
            // 
            lstExtensions.Dock = DockStyle.Fill;
            lstExtensions.FormattingEnabled = true;
            lstExtensions.Location = new Point(8, 118);
            lstExtensions.Name = "lstExtensions";
            lstExtensions.Size = new Size(557, 307);
            lstExtensions.TabIndex = 4;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(8, 95);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(98, 20);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extension List";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel.Controls.Add(btnClearExt, 1, 4);
            tableLayoutPanel.Controls.Add(lstExtensions, 1, 3);
            tableLayoutPanel.Controls.Add(lblExtensionList, 1, 2);
            tableLayoutPanel.Controls.Add(lblAddExtension, 1, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(573, 473);
            tableLayoutPanel.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.Controls.Add(txtExt, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAddExt, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 38);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(557, 39);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutPanel);
            Name = "EditorHasExtension";
            Size = new Size(573, 473);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel2;
    }
}
