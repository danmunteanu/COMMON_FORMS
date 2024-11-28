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
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddExtension
            // 
            lblAddExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddExtension.AutoSize = true;
            lblAddExtension.Location = new Point(68, 10);
            lblAddExtension.Name = "lblAddExtension";
            lblAddExtension.Size = new Size(87, 25);
            lblAddExtension.TabIndex = 0;
            lblAddExtension.Text = "Extension";
            // 
            // txtExt
            // 
            txtExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtExt.Location = new Point(68, 42);
            txtExt.Name = "txtExt";
            txtExt.Size = new Size(372, 31);
            txtExt.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(446, 43);
            btnAddExt.Name = "btnAddExt";
            btnAddExt.Size = new Size(59, 29);
            btnAddExt.TabIndex = 2;
            btnAddExt.Text = "ADD";
            btnAddExt.UseVisualStyleBackColor = true;
            btnAddExt.Click += btnAddExt_Click;
            // 
            // btnClearExt
            // 
            btnClearExt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(446, 118);
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
            lstExtensions.Location = new Point(68, 118);
            lstExtensions.Name = "lstExtensions";
            lstExtensions.Size = new Size(372, 307);
            lstExtensions.TabIndex = 4;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(68, 90);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(118, 25);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extension List";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel.Controls.Add(btnAddExt, 2, 1);
            tableLayoutPanel.Controls.Add(lstExtensions, 1, 3);
            tableLayoutPanel.Controls.Add(lblExtensionList, 1, 2);
            tableLayoutPanel.Controls.Add(lblAddExtension, 1, 0);
            tableLayoutPanel.Controls.Add(btnClearExt, 2, 3);
            tableLayoutPanel.Controls.Add(txtExt, 1, 1);
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
            tableLayoutPanel.Size = new Size(573, 473);
            tableLayoutPanel.TabIndex = 6;
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutPanel);
            Name = "EditorHasExtension";
            Size = new Size(573, 473);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
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
    }
}
