namespace CommonForms.ConditionEditors
{
    public class EditorAlways : EditorBase<string>
    {
        public EditorAlways()
        {
            // Create a Windows Forms label
            var label = new System.Windows.Forms.Label
            {
                Text = "ALWAYS",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter, // Center the text
                Dock = System.Windows.Forms.DockStyle.Fill // Fill the UserControl with the label
            };

            // Add the label to the UserControl's controls collection
            this.Controls.Add(label);
        }
    }
}
