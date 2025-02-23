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
            txtAddExtension = new TextBox();
            btnAddExt = new Button();
            lblExtensionList = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanelAdd = new TableLayoutPanel();
            lblExt = new Label();
            compListExtensions = new Components.ExtensionsList();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddExtension
            // 
            txtAddExtension.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddExtension.Font = new Font("Segoe UI", 7F);
            txtAddExtension.Location = new Point(665, 5);
            txtAddExtension.Name = "txtAddExtension";
            txtAddExtension.Size = new Size(64, 23);
            txtAddExtension.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Dock = DockStyle.Fill;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(735, 3);
            btnAddExt.Name = "btnAddExt";
            btnAddExt.Size = new Size(54, 28);
            btnAddExt.TabIndex = 2;
            btnAddExt.Text = "ADD";
            btnAddExt.UseVisualStyleBackColor = true;
            btnAddExt.Click += btnAddExt_Click;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(3, 7);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(81, 20);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extensions:";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutMain.Controls.Add(tableLayoutPanelAdd, 1, 1);
            tableLayoutMain.Controls.Add(compListExtensions, 1, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(798, 384);
            tableLayoutMain.TabIndex = 14;
            // 
            // tableLayoutPanelAdd
            // 
            tableLayoutPanelAdd.ColumnCount = 5;
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelAdd.Controls.Add(btnAddExt, 4, 0);
            tableLayoutPanelAdd.Controls.Add(txtAddExtension, 3, 0);
            tableLayoutPanelAdd.Controls.Add(lblExt, 2, 0);
            tableLayoutPanelAdd.Controls.Add(lblExtensionList, 0, 0);
            tableLayoutPanelAdd.Dock = DockStyle.Fill;
            tableLayoutPanelAdd.Location = new Point(3, 46);
            tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            tableLayoutPanelAdd.RowCount = 1;
            tableLayoutPanelAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.Size = new Size(792, 34);
            tableLayoutPanelAdd.TabIndex = 15;
            // 
            // lblExt
            // 
            lblExt.Anchor = AnchorStyles.Right;
            lblExt.AutoSize = true;
            lblExt.Font = new Font("Segoe UI", 9F);
            lblExt.Location = new Point(619, 7);
            lblExt.Name = "lblExt";
            lblExt.Size = new Size(40, 20);
            lblExt.TabIndex = 6;
            lblExt.Text = "Add:";
            // 
            // listExtensions
            // 
            compListExtensions.Dock = DockStyle.Fill;
            compListExtensions.Location = new Point(3, 86);
            compListExtensions.Name = "listExtensions";
            compListExtensions.Size = new Size(792, 194);
            compListExtensions.TabIndex = 17;
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutMain);
            Name = "EditorHasExtension";
            Size = new Size(798, 384);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanelAdd.ResumeLayout(false);
            tableLayoutPanelAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtAddExtension;
        private Button btnAddExt;
        private Label lblExtensionList;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutPanelAdd;
        private Label lblExt;
        private Components.ExtensionsList compListExtensions;
    }
}
