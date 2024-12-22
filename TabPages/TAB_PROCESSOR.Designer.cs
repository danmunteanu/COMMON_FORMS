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
            tableLayoutButtons = new TableLayoutPanel();
            btnDel = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            btnReload = new Button();
            btnProcess = new Button();
            lstProcessor = new ListBox();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutButtons
            // 
            tableLayoutButtons.ColumnCount = 6;
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutButtons.Controls.Add(btnDel, 2, 0);
            tableLayoutButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutButtons.Controls.Add(btnEdit, 1, 0);
            tableLayoutButtons.Controls.Add(btnClear, 5, 0);
            tableLayoutButtons.Controls.Add(btnReload, 3, 0);
            tableLayoutButtons.Dock = DockStyle.Fill;
            tableLayoutButtons.Location = new Point(2, 292);
            tableLayoutButtons.Margin = new Padding(2);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.RowCount = 1;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutButtons.Size = new Size(1250, 36);
            tableLayoutButtons.TabIndex = 48;
            // 
            // btnDel
            // 
            btnDel.Dock = DockStyle.Fill;
            btnDel.Font = new Font("Segoe UI", 7F);
            btnDel.Location = new Point(132, 2);
            btnDel.Margin = new Padding(2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(61, 32);
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
            btnAdd.Size = new Size(61, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Segoe UI", 7F);
            btnEdit.Location = new Point(67, 2);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(61, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI", 7F);
            btnClear.Location = new Point(1158, 2);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 32);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReload
            // 
            btnReload.Font = new Font("Segoe UI", 7F);
            btnReload.Location = new Point(199, 4);
            btnReload.Margin = new Padding(4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(42, 28);
            btnReload.TabIndex = 3;
            btnReload.Text = "↻";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnProcess
            // 
            btnProcess.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProcess.Location = new Point(2, 608);
            btnProcess.Margin = new Padding(2);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(1250, 54);
            btnProcess.TabIndex = 47;
            btnProcess.Text = "RUN PROCESSOR";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // lstProcessor
            // 
            lstProcessor.Dock = DockStyle.Fill;
            lstProcessor.FormattingEnabled = true;
            lstProcessor.ItemHeight = 25;
            lstProcessor.Location = new Point(4, 45);
            lstProcessor.Margin = new Padding(4, 5, 4, 5);
            lstProcessor.Name = "lstProcessor";
            lstProcessor.Size = new Size(1246, 240);
            lstProcessor.TabIndex = 35;
            lstProcessor.SelectedIndexChanged += lstProcessor_SelectedIndexChanged;
            lstProcessor.DoubleClick += lstProcessor_DoubleClick;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(lstProcessor, 0, 1);
            tableLayoutMain.Controls.Add(btnProcess, 0, 4);
            tableLayoutMain.Controls.Add(tableLayoutButtons, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 6;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutMain.Size = new Size(1254, 670);
            tableLayoutMain.TabIndex = 43;
            // 
            // TAB_Processor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(4);
            Name = "TAB_Processor";
            Size = new Size(1254, 670);
            tableLayoutButtons.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
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
    }
}
