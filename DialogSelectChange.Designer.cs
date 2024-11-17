namespace CommonForms
{
    partial class DialogSelectChange
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
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutAction = new TableLayoutPanel();
            lblSelAct = new Label();
            cmbAction = new ComboBox();
            tableLayoutCondition = new TableLayoutPanel();
            lblSelCond = new Label();
            cmbCondition = new ComboBox();
            panelAction = new Panel();
            panelCondition = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnClose = new Button();
            btnSubmit = new Button();
            label1 = new Label();
            tableLayoutPanel.SuspendLayout();
            tableLayoutAction.SuspendLayout();
            tableLayoutCondition.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(tableLayoutAction, 1, 1);
            tableLayoutPanel.Controls.Add(tableLayoutCondition, 0, 1);
            tableLayoutPanel.Controls.Add(panelAction, 1, 3);
            tableLayoutPanel.Controls.Add(panelCondition, 0, 3);
            tableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel.Controls.Add(label1, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(1);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 4F));
            tableLayoutPanel.Size = new Size(685, 330);
            tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutAction
            // 
            tableLayoutAction.ColumnCount = 1;
            tableLayoutAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAction.Controls.Add(lblSelAct, 0, 0);
            tableLayoutAction.Controls.Add(cmbAction, 0, 1);
            tableLayoutAction.Dock = DockStyle.Fill;
            tableLayoutAction.Location = new Point(343, 12);
            tableLayoutAction.Margin = new Padding(1);
            tableLayoutAction.Name = "tableLayoutAction";
            tableLayoutAction.RowCount = 2;
            tableLayoutAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutAction.Size = new Size(341, 47);
            tableLayoutAction.TabIndex = 46;
            // 
            // lblSelAct
            // 
            lblSelAct.Anchor = AnchorStyles.Left;
            lblSelAct.AutoSize = true;
            lblSelAct.Location = new Point(3, 2);
            lblSelAct.Name = "lblSelAct";
            lblSelAct.Size = new Size(51, 15);
            lblSelAct.TabIndex = 37;
            lblSelAct.Text = "Execute:";
            // 
            // cmbAction
            // 
            cmbAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(3, 22);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(335, 23);
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
            tableLayoutCondition.Location = new Point(1, 12);
            tableLayoutCondition.Margin = new Padding(1);
            tableLayoutCondition.Name = "tableLayoutCondition";
            tableLayoutCondition.RowCount = 2;
            tableLayoutCondition.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutCondition.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutCondition.Size = new Size(340, 47);
            tableLayoutCondition.TabIndex = 45;
            // 
            // lblSelCond
            // 
            lblSelCond.Anchor = AnchorStyles.Left;
            lblSelCond.AutoSize = true;
            lblSelCond.Location = new Point(3, 2);
            lblSelCond.Name = "lblSelCond";
            lblSelCond.Size = new Size(26, 15);
            lblSelCond.TabIndex = 36;
            lblSelCond.Text = "On:";
            // 
            // cmbCondition
            // 
            cmbCondition.Dock = DockStyle.Fill;
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(3, 22);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(334, 23);
            cmbCondition.TabIndex = 39;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // panelAction
            // 
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(343, 87);
            panelAction.Margin = new Padding(1);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(341, 199);
            panelAction.TabIndex = 42;
            // 
            // panelCondition
            // 
            panelCondition.Dock = DockStyle.Fill;
            panelCondition.Location = new Point(1, 87);
            panelCondition.Margin = new Padding(1);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(340, 199);
            panelCondition.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.Controls.Add(btnClose, 2, 0);
            tableLayoutPanel2.Controls.Add(btnSubmit, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(345, 289);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(337, 35);
            tableLayoutPanel2.TabIndex = 48;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Location = new Point(234, 2);
            btnClose.Margin = new Padding(1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(102, 30);
            btnClose.TabIndex = 48;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(128, 1);
            btnSubmit.Margin = new Padding(1);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(102, 30);
            btnSubmit.TabIndex = 47;
            btnSubmit.Text = "ADD / EDIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 65);
            label1.Name = "label1";
            label1.Size = new Size(274, 15);
            label1.TabIndex = 49;
            label1.Text = "Checks if a file's extension appears in the list below";
            // 
            // DialogSelectChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 330);
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "DialogSelectChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DIALOG_ADD_CHANGE";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tableLayoutAction.ResumeLayout(false);
            tableLayoutAction.PerformLayout();
            tableLayoutCondition.ResumeLayout(false);
            tableLayoutCondition.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel panelAction;
        private Panel panelCondition;
        private TableLayoutPanel tableLayoutAction;
        private Label lblSelAct;
        private ComboBox cmbAction;
        private Button btnSubmit;
        private Button btnClose;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutCondition;
        private Label lblSelCond;
        private ComboBox cmbCondition;
        private Label label1;
    }
}