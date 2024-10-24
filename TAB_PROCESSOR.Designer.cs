namespace CS_Yaml_Parser.UserControls
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            btnProcess = new Button();
            lstProcessor = new ListBox();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 202);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(999, 40);
            tableLayoutPanel1.TabIndex = 48;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(2, 2);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(106, 2);
            btnEdit.Margin = new Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(897, 2);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 36);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            btnProcess.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProcess.Location = new Point(2, 490);
            btnProcess.Margin = new Padding(2);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(999, 43);
            btnProcess.TabIndex = 47;
            btnProcess.Text = "RUN PROCESSOR";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // lstProcessor
            // 
            lstProcessor.Dock = DockStyle.Fill;
            lstProcessor.FormattingEnabled = true;
            lstProcessor.Location = new Point(3, 4);
            lstProcessor.Margin = new Padding(3, 4, 3, 4);
            lstProcessor.Name = "lstProcessor";
            lstProcessor.Size = new Size(997, 192);
            lstProcessor.TabIndex = 35;
            lstProcessor.SelectedIndexChanged += lstProcessor_SelectedIndexChanged;
            lstProcessor.DoubleClick += lstProcessor_DoubleClick;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(lstProcessor, 0, 0);
            tableLayoutMain.Controls.Add(btnProcess, 0, 3);
            tableLayoutMain.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutMain.Size = new Size(1003, 536);
            tableLayoutMain.TabIndex = 43;
            // 
            // TAB_Processor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "TAB_Processor";
            Size = new Size(1003, 536);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnClear;
        private Button btnProcess;
        private ListBox lstProcessor;
        private TableLayoutPanel tableLayoutMain;
    }
}
