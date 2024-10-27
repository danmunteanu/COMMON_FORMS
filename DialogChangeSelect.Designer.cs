namespace CommonForms
{
    partial class DialogChangeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutAction = new TableLayoutPanel();
            lblSelAct = new Label();
            cmbAction = new ComboBox();
            tableLayoutCondition = new TableLayoutPanel();
            lblSelCond = new Label();
            cmbCondition = new ComboBox();
            panelAction = new Panel();
            panelCondition = new Panel();
            flowLayoutButtons = new FlowLayoutPanel();
            btnAddOrEdit = new Button();
            btnClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutAction.SuspendLayout();
            tableLayoutCondition.SuspendLayout();
            flowLayoutButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutAction, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutCondition, 0, 0);
            tableLayoutPanel1.Controls.Add(panelAction, 1, 1);
            tableLayoutPanel1.Controls.Add(panelCondition, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutButtons, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(979, 550);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutAction
            // 
            tableLayoutAction.ColumnCount = 1;
            tableLayoutAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAction.Controls.Add(lblSelAct, 0, 0);
            tableLayoutAction.Controls.Add(cmbAction, 0, 1);
            tableLayoutAction.Dock = DockStyle.Fill;
            tableLayoutAction.Location = new Point(491, 2);
            tableLayoutAction.Margin = new Padding(2);
            tableLayoutAction.Name = "tableLayoutAction";
            tableLayoutAction.RowCount = 2;
            tableLayoutAction.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutAction.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutAction.Size = new Size(486, 61);
            tableLayoutAction.TabIndex = 46;
            // 
            // lblSelAct
            // 
            lblSelAct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelAct.AutoSize = true;
            lblSelAct.Location = new Point(4, 0);
            lblSelAct.Margin = new Padding(4, 0, 4, 0);
            lblSelAct.Name = "lblSelAct";
            lblSelAct.Size = new Size(96, 21);
            lblSelAct.TabIndex = 37;
            lblSelAct.Text = "Do Action:";
            // 
            // cmbAction
            // 
            cmbAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(4, 26);
            cmbAction.Margin = new Padding(4, 5, 4, 5);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(478, 33);
            cmbAction.TabIndex = 40;
            cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
            // 
            // tableLayoutCondition
            // 
            tableLayoutCondition.ColumnCount = 1;
            tableLayoutCondition.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCondition.Controls.Add(lblSelCond, 0, 0);
            tableLayoutCondition.Controls.Add(cmbCondition, 0, 1);
            tableLayoutCondition.Dock = DockStyle.Fill;
            tableLayoutCondition.Location = new Point(2, 2);
            tableLayoutCondition.Margin = new Padding(2);
            tableLayoutCondition.Name = "tableLayoutCondition";
            tableLayoutCondition.RowCount = 2;
            tableLayoutCondition.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutCondition.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutCondition.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutCondition.Size = new Size(485, 61);
            tableLayoutCondition.TabIndex = 45;
            // 
            // lblSelCond
            // 
            lblSelCond.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelCond.AutoSize = true;
            lblSelCond.Location = new Point(4, 0);
            lblSelCond.Margin = new Padding(4, 0, 4, 0);
            lblSelCond.Name = "lblSelCond";
            lblSelCond.Size = new Size(123, 21);
            lblSelCond.TabIndex = 36;
            lblSelCond.Text = "On Condition:";
            // 
            // cmbCondition
            // 
            cmbCondition.Dock = DockStyle.Fill;
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(4, 26);
            cmbCondition.Margin = new Padding(4, 5, 4, 5);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(477, 33);
            cmbCondition.TabIndex = 39;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // panelAction
            // 
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(491, 67);
            panelAction.Margin = new Padding(2);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(486, 416);
            panelAction.TabIndex = 42;
            // 
            // panelCondition
            // 
            panelCondition.Dock = DockStyle.Fill;
            panelCondition.Location = new Point(2, 67);
            panelCondition.Margin = new Padding(2);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(485, 416);
            panelCondition.TabIndex = 43;
            // 
            // flowLayoutButtons
            // 
            flowLayoutButtons.Controls.Add(btnAddOrEdit);
            flowLayoutButtons.Controls.Add(btnClose);
            flowLayoutButtons.Dock = DockStyle.Fill;
            flowLayoutButtons.Location = new Point(491, 487);
            flowLayoutButtons.Margin = new Padding(2);
            flowLayoutButtons.Name = "flowLayoutButtons";
            flowLayoutButtons.Size = new Size(486, 61);
            flowLayoutButtons.TabIndex = 47;
            // 
            // btnAddOrEdit
            // 
            btnAddOrEdit.Location = new Point(2, 2);
            btnAddOrEdit.Margin = new Padding(2);
            btnAddOrEdit.Name = "btnAddOrEdit";
            btnAddOrEdit.Size = new Size(188, 34);
            btnAddOrEdit.TabIndex = 47;
            btnAddOrEdit.Text = "ADD / EDIT";
            btnAddOrEdit.UseVisualStyleBackColor = true;
            btnAddOrEdit.Click += btnAddOrEdit_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Location = new Point(194, 2);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(182, 34);
            btnClose.TabIndex = 48;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DialogChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 550);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "DialogChangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DIALOG_ADD_CHANGE";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutAction.ResumeLayout(false);
            tableLayoutAction.PerformLayout();
            tableLayoutCondition.ResumeLayout(false);
            tableLayoutCondition.PerformLayout();
            flowLayoutButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelAction;
        private Panel panelCondition;
        private TableLayoutPanel tableLayoutCondition;
        private Label lblSelCond;
        private ComboBox cmbCondition;
        private TableLayoutPanel tableLayoutAction;
        private Label lblSelAct;
        private ComboBox cmbAction;
        private Button btnAddOrEdit;
        private Button btnClose;
        private FlowLayoutPanel flowLayoutButtons;
    }
}