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
            txtDesc = new TextBox();
            lblSelAct = new Label();
            cmbAction = new ComboBox();
            lblSelCond = new Label();
            cmbCondition = new ComboBox();
            panelAction = new Panel();
            panelCondition = new Panel();
            tableLayoutButtons = new TableLayoutPanel();
            btnClose = new Button();
            btnSubmit = new Button();
            chkEnabled = new CheckBox();
            lblConditionDesc = new Label();
            lblActionDesc = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutChangeDesc = new TableLayoutPanel();
            chkDesc = new CheckBox();
            tableLayoutEditors = new TableLayoutPanel();
            tableLayoutButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutChangeDesc.SuspendLayout();
            tableLayoutEditors.SuspendLayout();
            SuspendLayout();
            // 
            // txtDesc
            // 
            txtDesc.Dock = DockStyle.Fill;
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(157, 12);
            txtDesc.Margin = new Padding(2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(680, 84);
            txtDesc.TabIndex = 51;
            // 
            // lblSelAct
            // 
            lblSelAct.Anchor = AnchorStyles.Left;
            lblSelAct.AutoSize = true;
            lblSelAct.Location = new Point(587, 5);
            lblSelAct.Margin = new Padding(4, 0, 4, 0);
            lblSelAct.Name = "lblSelAct";
            lblSelAct.Size = new Size(75, 25);
            lblSelAct.TabIndex = 37;
            lblSelAct.Text = "Execute:";
            // 
            // cmbAction
            // 
            cmbAction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(587, 40);
            cmbAction.Margin = new Padding(4, 5, 4, 5);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(310, 33);
            cmbAction.TabIndex = 40;
            cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
            // 
            // lblSelCond
            // 
            lblSelCond.Anchor = AnchorStyles.Left;
            lblSelCond.AutoSize = true;
            lblSelCond.Location = new Point(69, 5);
            lblSelCond.Margin = new Padding(4, 0, 4, 0);
            lblSelCond.Name = "lblSelCond";
            lblSelCond.Size = new Size(40, 25);
            lblSelCond.TabIndex = 36;
            lblSelCond.Text = "On:";
            // 
            // cmbCondition
            // 
            cmbCondition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(69, 40);
            cmbCondition.Margin = new Padding(4, 5, 4, 5);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(310, 33);
            cmbCondition.TabIndex = 39;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // panelAction
            // 
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(484, 1);
            panelAction.Margin = new Padding(1);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(482, 433);
            panelAction.TabIndex = 42;
            // 
            // panelCondition
            // 
            panelCondition.Dock = DockStyle.Fill;
            panelCondition.Location = new Point(1, 1);
            panelCondition.Margin = new Padding(1);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(481, 433);
            panelCondition.TabIndex = 43;
            // 
            // tableLayoutButtons
            // 
            tableLayoutButtons.ColumnCount = 3;
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutButtons.Controls.Add(btnClose, 2, 0);
            tableLayoutButtons.Controls.Add(btnSubmit, 1, 0);
            tableLayoutButtons.Dock = DockStyle.Fill;
            tableLayoutButtons.Location = new Point(4, 690);
            tableLayoutButtons.Margin = new Padding(4);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.RowCount = 1;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutButtons.Size = new Size(963, 47);
            tableLayoutButtons.TabIndex = 48;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClose.Location = new Point(814, 1);
            btnClose.Margin = new Padding(1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 45);
            btnClose.TabIndex = 48;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.Location = new Point(664, 1);
            btnSubmit.Margin = new Padding(1);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(148, 45);
            btnSubmit.TabIndex = 47;
            btnSubmit.Text = "UPDATE";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(841, 12);
            chkEnabled.Margin = new Padding(2);
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
            lblConditionDesc.Location = new Point(4, 7);
            lblConditionDesc.Margin = new Padding(4, 0, 4, 0);
            lblConditionDesc.Name = "lblConditionDesc";
            lblConditionDesc.Size = new Size(412, 25);
            lblConditionDesc.TabIndex = 49;
            lblConditionDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActionDesc
            // 
            lblActionDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblActionDesc.AutoSize = true;
            lblActionDesc.Location = new Point(423, 7);
            lblActionDesc.Name = "lblActionDesc";
            lblActionDesc.Size = new Size(415, 25);
            lblActionDesc.TabIndex = 50;
            lblActionDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutChangeDesc, 0, 4);
            tableLayoutMain.Controls.Add(tableLayoutEditors, 0, 3);
            tableLayoutMain.Controls.Add(tableLayoutButtons, 0, 5);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 7;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutMain.Size = new Size(971, 756);
            tableLayoutMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Controls.Add(lblSelAct, 3, 0);
            tableLayoutPanel1.Controls.Add(cmbCondition, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbAction, 3, 1);
            tableLayoutPanel1.Controls.Add(lblSelCond, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 17);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(967, 71);
            tableLayoutPanel1.TabIndex = 47;
            // 
            // tableLayoutChangeDesc
            // 
            tableLayoutChangeDesc.ColumnCount = 3;
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tableLayoutChangeDesc.Controls.Add(txtDesc, 1, 1);
            tableLayoutChangeDesc.Controls.Add(chkDesc, 0, 1);
            tableLayoutChangeDesc.Controls.Add(chkEnabled, 2, 1);
            tableLayoutChangeDesc.Dock = DockStyle.Fill;
            tableLayoutChangeDesc.Location = new Point(2, 576);
            tableLayoutChangeDesc.Margin = new Padding(2);
            tableLayoutChangeDesc.Name = "tableLayoutChangeDesc";
            tableLayoutChangeDesc.RowCount = 3;
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutChangeDesc.Size = new Size(967, 108);
            tableLayoutChangeDesc.TabIndex = 52;
            // 
            // chkDesc
            // 
            chkDesc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkDesc.AutoSize = true;
            chkDesc.Location = new Point(19, 14);
            chkDesc.Margin = new Padding(4);
            chkDesc.Name = "chkDesc";
            chkDesc.Size = new Size(132, 29);
            chkDesc.TabIndex = 51;
            chkDesc.Text = "Description:";
            chkDesc.UseVisualStyleBackColor = true;
            chkDesc.CheckedChanged += chkDesc_CheckedChanged;
            // 
            // tableLayoutEditors
            // 
            tableLayoutEditors.ColumnCount = 2;
            tableLayoutEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutEditors.Controls.Add(panelCondition, 0, 0);
            tableLayoutEditors.Controls.Add(panelAction, 1, 0);
            tableLayoutEditors.Dock = DockStyle.Fill;
            tableLayoutEditors.Location = new Point(2, 137);
            tableLayoutEditors.Margin = new Padding(2);
            tableLayoutEditors.Name = "tableLayoutEditors";
            tableLayoutEditors.RowCount = 1;
            tableLayoutEditors.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutEditors.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutEditors.Size = new Size(967, 435);
            tableLayoutEditors.TabIndex = 0;
            // 
            // DialogSelectChange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 756);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "DialogSelectChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SELECT CHANGE";
            tableLayoutButtons.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutChangeDesc.ResumeLayout(false);
            tableLayoutChangeDesc.PerformLayout();
            tableLayoutEditors.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelAction;
        private Panel panelCondition;
        private Label lblSelAct;
        private ComboBox cmbAction;
        private Button btnSubmit;
        private Button btnClose;
        private TableLayoutPanel tableLayoutButtons;
        private Label lblSelCond;
        private ComboBox cmbCondition;
        private Label lblConditionDesc;
        private CheckBox chkEnabled;
        private Label lblActionDesc;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtDesc;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutEditors;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutChangeDesc;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox chkDesc;
    }
}