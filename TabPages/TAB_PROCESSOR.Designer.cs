namespace CommonForms
{
    partial class TAB_Processor
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
            tableLayoutButtons = new TableLayoutPanel();
            btnDel = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            btnReload = new Button();
            btnEnableDisable = new Button();
            btnTemplates = new Button();
            btnProcess = new Button();
            lstProcessor = new ListBox();
            tableLayoutMain = new TableLayoutPanel();
            lblChangeList = new Label();
            menuStripTemplates = new ContextMenuStrip(components);
            tableLayoutButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutButtons
            // 
            tableLayoutButtons.ColumnCount = 8;
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutButtons.Controls.Add(btnDel, 3, 0);
            tableLayoutButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutButtons.Controls.Add(btnEdit, 1, 0);
            tableLayoutButtons.Controls.Add(btnClear, 7, 0);
            tableLayoutButtons.Controls.Add(btnReload, 4, 0);
            tableLayoutButtons.Controls.Add(btnEnableDisable, 2, 0);
            tableLayoutButtons.Controls.Add(btnTemplates, 5, 0);
            tableLayoutButtons.Dock = DockStyle.Fill;
            tableLayoutButtons.Location = new Point(2, 189);
            tableLayoutButtons.Margin = new Padding(2);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.RowCount = 1;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutButtons.Size = new Size(624, 32);
            tableLayoutButtons.TabIndex = 48;
            // 
            // btnDel
            // 
            btnDel.Dock = DockStyle.Fill;
            btnDel.Font = new Font("Segoe UI", 7F);
            btnDel.Location = new Point(146, 2);
            btnDel.Margin = new Padding(2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(48, 28);
            btnDel.TabIndex = 4;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 7F);
            btnAdd.Location = new Point(2, 2);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(48, 28);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Segoe UI", 7F);
            btnEdit.Location = new Point(54, 2);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(48, 28);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI", 7F);
            btnClear.Location = new Point(551, 2);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(71, 28);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReload
            // 
            btnReload.Dock = DockStyle.Fill;
            btnReload.Font = new Font("Segoe UI", 7F);
            btnReload.Location = new Point(199, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(34, 26);
            btnReload.TabIndex = 3;
            btnReload.Text = "↻";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnEnableDisable
            // 
            btnEnableDisable.Dock = DockStyle.Fill;
            btnEnableDisable.Font = new Font("Segoe UI", 7F);
            btnEnableDisable.Location = new Point(106, 2);
            btnEnableDisable.Margin = new Padding(2);
            btnEnableDisable.Name = "btnEnableDisable";
            btnEnableDisable.Size = new Size(36, 28);
            btnEnableDisable.TabIndex = 5;
            btnEnableDisable.Text = "*";
            btnEnableDisable.UseVisualStyleBackColor = true;
            btnEnableDisable.Click += btnEnableDisable_Click;
            // 
            // btnTemplates
            // 
            btnTemplates.Font = new Font("Segoe UI", 7F);
            btnTemplates.Location = new Point(239, 3);
            btnTemplates.Name = "btnTemplates";
            btnTemplates.Size = new Size(78, 26);
            btnTemplates.TabIndex = 6;
            btnTemplates.Text = "TEMPLATES";
            btnTemplates.UseVisualStyleBackColor = true;
            btnTemplates.Click += btnTemplates_Click;
            // 
            // btnProcess
            // 
            btnProcess.Dock = DockStyle.Fill;
            btnProcess.Location = new Point(1, 429);
            btnProcess.Margin = new Padding(1, 3, 1, 3);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(626, 42);
            btnProcess.TabIndex = 47;
            btnProcess.Text = "RUN PROCESSOR";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // lstProcessor
            // 
            lstProcessor.Dock = DockStyle.Fill;
            lstProcessor.FormattingEnabled = true;
            lstProcessor.Location = new Point(3, 39);
            lstProcessor.Margin = new Padding(3, 4, 3, 4);
            lstProcessor.Name = "lstProcessor";
            lstProcessor.Size = new Size(622, 144);
            lstProcessor.TabIndex = 35;
            lstProcessor.SelectedIndexChanged += lstProcessor_SelectedIndexChanged;
            lstProcessor.DoubleClick += lstProcessor_DoubleClick;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(lstProcessor, 0, 2);
            tableLayoutMain.Controls.Add(btnProcess, 0, 5);
            tableLayoutMain.Controls.Add(tableLayoutButtons, 0, 3);
            tableLayoutMain.Controls.Add(lblChangeList, 0, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 7;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 152F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 4F));
            tableLayoutMain.Size = new Size(628, 478);
            tableLayoutMain.TabIndex = 43;
            // 
            // lblChangeList
            // 
            lblChangeList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblChangeList.AutoSize = true;
            lblChangeList.Location = new Point(3, 7);
            lblChangeList.Name = "lblChangeList";
            lblChangeList.Size = new Size(622, 20);
            lblChangeList.TabIndex = 49;
            lblChangeList.Text = "Change List:";
            // 
            // menuStripTemplates
            // 
            menuStripTemplates.ImageScalingSize = new Size(20, 20);
            menuStripTemplates.Name = "menuStripTemplates";
            menuStripTemplates.Size = new Size(61, 4);
            // 
            // TAB_Processor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "TAB_Processor";
            Size = new Size(628, 478);
            tableLayoutButtons.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutButtons;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnClear;
        private Button btnProcess;
        private ListBox lstProcessor;
        private TableLayoutPanel tableLayoutMain;
        private Button btnReload;
        private Button btnDel;
        private Label lblChangeList;
        private Button btnEnableDisable;
        private Button btnTemplates;
        private ContextMenuStrip menuStripTemplates;
    }
}
