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
            chkEnabled = new CheckBox();
            lblConditionDesc = new Label();
            lblActionDesc = new Label();
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
            tableLayoutPanel.Controls.Add(lblConditionDesc, 0, 2);
            tableLayoutPanel.Controls.Add(lblActionDesc, 1, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(1);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel.Size = new Size(979, 550);
            tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutAction
            // 
            tableLayoutAction.ColumnCount = 3;
            tableLayoutAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutAction.Controls.Add(lblSelAct, 1, 0);
            tableLayoutAction.Controls.Add(cmbAction, 1, 1);
            tableLayoutAction.Dock = DockStyle.Fill;
            tableLayoutAction.Location = new Point(490, 20);
            tableLayoutAction.Margin = new Padding(1);
            tableLayoutAction.Name = "tableLayoutAction";
            tableLayoutAction.RowCount = 2;
            tableLayoutAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutAction.Size = new Size(488, 79);
            tableLayoutAction.TabIndex = 46;
            // 
            // lblSelAct
            // 
            lblSelAct.Anchor = AnchorStyles.Left;
            lblSelAct.AutoSize = true;
            lblSelAct.Location = new Point(69, 3);
            lblSelAct.Margin = new Padding(4, 0, 4, 0);
            lblSelAct.Name = "lblSelAct";
            lblSelAct.Size = new Size(75, 25);
            lblSelAct.TabIndex = 37;
            lblSelAct.Text = "Execute:";
            // 
            // cmbAction
            // 
            cmbAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(69, 36);
            cmbAction.Margin = new Padding(4, 5, 4, 5);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(235, 33);
            cmbAction.TabIndex = 40;
            cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
            // 
            // tableLayoutCondition
            // 
            tableLayoutCondition.ColumnCount = 3;
            tableLayoutCondition.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutCondition.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCondition.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutCondition.Controls.Add(lblSelCond, 1, 0);
            tableLayoutCondition.Controls.Add(cmbCondition, 1, 1);
            tableLayoutCondition.Dock = DockStyle.Fill;
            tableLayoutCondition.Location = new Point(1, 20);
            tableLayoutCondition.Margin = new Padding(1);
            tableLayoutCondition.Name = "tableLayoutCondition";
            tableLayoutCondition.RowCount = 2;
            tableLayoutCondition.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutCondition.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutCondition.Size = new Size(487, 79);
            tableLayoutCondition.TabIndex = 45;
            // 
            // lblSelCond
            // 
            lblSelCond.Anchor = AnchorStyles.Left;
            lblSelCond.AutoSize = true;
            lblSelCond.Location = new Point(69, 3);
            lblSelCond.Margin = new Padding(4, 0, 4, 0);
            lblSelCond.Name = "lblSelCond";
            lblSelCond.Size = new Size(40, 25);
            lblSelCond.TabIndex = 36;
            lblSelCond.Text = "On:";
            // 
            // cmbCondition
            // 
            cmbCondition.Dock = DockStyle.Fill;
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(69, 36);
            cmbCondition.Margin = new Padding(4, 5, 4, 5);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(234, 33);
            cmbCondition.TabIndex = 39;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // panelAction
            // 
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(490, 145);
            panelAction.Margin = new Padding(1);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(488, 333);
            panelAction.TabIndex = 42;
            // 
            // panelCondition
            // 
            panelCondition.Dock = DockStyle.Fill;
            panelCondition.Location = new Point(1, 145);
            panelCondition.Margin = new Padding(1);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(487, 333);
            panelCondition.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Controls.Add(btnClose, 2, 0);
            tableLayoutPanel2.Controls.Add(btnSubmit, 1, 0);
            tableLayoutPanel2.Controls.Add(chkEnabled, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(493, 483);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(482, 57);
            tableLayoutPanel2.TabIndex = 48;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClose.Location = new Point(333, 3);
            btnClose.Margin = new Padding(1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 50);
            btnClose.TabIndex = 48;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.Location = new Point(183, 3);
            btnSubmit.Margin = new Padding(1);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(148, 50);
            btnSubmit.TabIndex = 47;
            btnSubmit.Text = "UPDATE";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(3, 14);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(101, 29);
            chkEnabled.TabIndex = 50;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // lblConditionDesc
            // 
            lblConditionDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblConditionDesc.AutoSize = true;
            lblConditionDesc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConditionDesc.Location = new Point(4, 109);
            lblConditionDesc.Margin = new Padding(4, 0, 4, 0);
            lblConditionDesc.Name = "lblConditionDesc";
            lblConditionDesc.Size = new Size(481, 25);
            lblConditionDesc.TabIndex = 49;
            lblConditionDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActionDesc
            // 
            lblActionDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblActionDesc.AutoSize = true;
            lblActionDesc.Location = new Point(492, 109);
            lblActionDesc.Name = "lblActionDesc";
            lblActionDesc.Size = new Size(484, 25);
            lblActionDesc.TabIndex = 50;
            lblActionDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DialogSelectChange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 550);
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
            tableLayoutPanel2.PerformLayout();
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
        private Label lblConditionDesc;
        private CheckBox chkEnabled;
        private Label lblActionDesc;
    }
}