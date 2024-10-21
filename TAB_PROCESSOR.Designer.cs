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
            cmbAction = new ComboBox();
            cmbCondition = new ComboBox();
            btnAddPair = new Button();
            lblSelAct = new Label();
            lblSelCond = new Label();
            lstProcessor = new ListBox();
            panelCondition = new Panel();
            panelAction = new Panel();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableEditors = new TableLayoutPanel();
            btnProcess = new Button();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableEditors.SuspendLayout();
            SuspendLayout();
            // 
            // cmbAction
            // 
            cmbAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(4, 35);
            cmbAction.Margin = new Padding(4, 5, 4, 5);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(488, 33);
            cmbAction.TabIndex = 40;
            // 
            // cmbCondition
            // 
            cmbCondition.Dock = DockStyle.Fill;
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(4, 35);
            cmbCondition.Margin = new Padding(4, 5, 4, 5);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(488, 33);
            cmbCondition.TabIndex = 39;
            // 
            // btnAddPair
            // 
            btnAddPair.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddPair.Location = new Point(1004, 21);
            btnAddPair.Margin = new Padding(4, 5, 4, 5);
            btnAddPair.Name = "btnAddPair";
            btnAddPair.Size = new Size(242, 48);
            btnAddPair.TabIndex = 38;
            btnAddPair.Text = "ADD PAIR";
            btnAddPair.UseVisualStyleBackColor = true;
            // 
            // lblSelAct
            // 
            lblSelAct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelAct.AutoSize = true;
            lblSelAct.Location = new Point(4, 5);
            lblSelAct.Margin = new Padding(4, 0, 4, 0);
            lblSelAct.Name = "lblSelAct";
            lblSelAct.Size = new Size(96, 25);
            lblSelAct.TabIndex = 37;
            lblSelAct.Text = "Do Action:";
            // 
            // lblSelCond
            // 
            lblSelCond.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelCond.AutoSize = true;
            lblSelCond.Location = new Point(4, 5);
            lblSelCond.Margin = new Padding(4, 0, 4, 0);
            lblSelCond.Name = "lblSelCond";
            lblSelCond.Size = new Size(123, 25);
            lblSelCond.TabIndex = 36;
            lblSelCond.Text = "On Condition:";
            // 
            // lstProcessor
            // 
            lstProcessor.Dock = DockStyle.Fill;
            lstProcessor.FormattingEnabled = true;
            lstProcessor.ItemHeight = 25;
            lstProcessor.Location = new Point(4, 5);
            lstProcessor.Margin = new Padding(4, 5, 4, 5);
            lstProcessor.Name = "lstProcessor";
            lstProcessor.Size = new Size(1246, 240);
            lstProcessor.TabIndex = 35;
            lstProcessor.SelectedIndexChanged += lstProcessor_SelectedIndexChanged;
            // 
            // panelCondition
            // 
            panelCondition.Dock = DockStyle.Fill;
            panelCondition.Location = new Point(2, 2);
            panelCondition.Margin = new Padding(2);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(621, 257);
            panelCondition.TabIndex = 41;
            // 
            // panelAction
            // 
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(627, 2);
            panelAction.Margin = new Padding(2);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(621, 257);
            panelAction.TabIndex = 42;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutMain.Controls.Add(tableEditors, 0, 2);
            tableLayoutMain.Controls.Add(lstProcessor, 0, 0);
            tableLayoutMain.Controls.Add(btnProcess, 0, 3);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutMain.Size = new Size(1254, 670);
            tableLayoutMain.TabIndex = 43;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel4.Controls.Add(btnAddPair, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 252);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1250, 91);
            tableLayoutPanel4.TabIndex = 46;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lblSelAct, 0, 0);
            tableLayoutPanel3.Controls.Add(cmbAction, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(502, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Size = new Size(496, 87);
            tableLayoutPanel3.TabIndex = 45;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblSelCond, 0, 0);
            tableLayoutPanel2.Controls.Add(cmbCondition, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(496, 87);
            tableLayoutPanel2.TabIndex = 44;
            // 
            // tableEditors
            // 
            tableEditors.ColumnCount = 2;
            tableEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableEditors.Controls.Add(panelAction, 1, 0);
            tableEditors.Controls.Add(panelCondition, 0, 0);
            tableEditors.Dock = DockStyle.Fill;
            tableEditors.Location = new Point(2, 347);
            tableEditors.Margin = new Padding(2);
            tableEditors.Name = "tableEditors";
            tableEditors.RowCount = 1;
            tableEditors.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableEditors.Size = new Size(1250, 261);
            tableEditors.TabIndex = 44;
            // 
            // btnProcess
            // 
            btnProcess.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProcess.Location = new Point(2, 613);
            btnProcess.Margin = new Padding(2);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(1250, 54);
            btnProcess.TabIndex = 47;
            btnProcess.Text = "RUN PROCESSOR";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // TAB_Processor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(4);
            Name = "TAB_Processor";
            Size = new Size(1254, 670);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableEditors.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbAction;
        private ComboBox cmbCondition;
        private Button btnAddPair;
        private Label lblSelAct;
        private Label lblSelCond;
        private ListBox lstProcessor;
        private Panel panelCondition;
        private Panel panelAction;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableEditors;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnProcess;
    }
}
