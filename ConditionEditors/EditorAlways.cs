﻿namespace CommonForms.ConditionEditors
{
    public class EditorAlways : EditorBase2
    {
        public EditorAlways()
        {
            const string text = "Always evaluates to TRUE";
            // Create a Windows Forms label
            var label = new System.Windows.Forms.Label
            {
                Text = text,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter, // Center the text
                Dock = System.Windows.Forms.DockStyle.Fill,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0)

            };

            // Add the label to the UserControl's controls collection
            this.Controls.Add(label);
        }

        public override void SaveState(object cond)
        {
            //  nothing to do, but keep this method
            //  else, the base method will throw
        }

        private void InitializeComponent()
        {

        }

        public override void LoadState(object cond)
        {
            //  nothing to do here, but keep this method
            //  else the base method will throw
        }
        private TableLayoutPanel tableLayoutMain;
        private Label lblMessage;
    }
}
