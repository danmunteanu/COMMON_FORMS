using Guna.UI2.WinForms;
using static CommonForms.PageButtonsFactory;

/*
	Creates buttons for tab pages
*/

namespace CommonForms
{
    public class PageButtonsFactory
    {
        public class ButtonConfig
        {
            public string? Name { get; set; }
            public string? Text { get; set; }
            public bool Checked { get; set; }
            public EventHandler? ClickHandler { get; set; }
        }

        public List<ButtonConfig> PageButtonsConfigs { get; set; } = new();

        //  Button font
        public Font Font { get; set; } = new("Roboto Slab", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);

        //  padding
        public int WidthPadding { get; set; } = 20;
        public int HeightPadding { get; set; } = 20;

        private Guna2Button CreatePageButton(string btnName, string btnText, EventHandler? eventHandler, bool buttonChecked = false)
        {
            Guna2Button button = new();
            button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            button.Checked = buttonChecked;
            button.CheckedState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            button.CheckedState.FillColor = Color.White;
            button.CustomBorderThickness = new Padding(0, 0, 0, 3);
            button.CustomizableEdges = new();
            button.DisabledState.BorderColor = Color.DarkGray;
            button.DisabledState.CustomBorderColor = Color.DarkGray;
            button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button.FillColor = Color.White;
            button.Font = Font;
            button.ForeColor = Color.Black;
            button.HoverState.CustomBorderColor = Color.Red;
            button.Location = new Point(3, 2);
            button.Margin = new Padding(3, 2, 3, 2);
            button.Name = btnName;
            button.ShadowDecoration.CustomizableEdges = new();
            button.Text = btnText;

            // Measure text size
            Size textSize = TextRenderer.MeasureText(btnText, Font);

            // Set the button size
            button.Size = new Size(textSize.Width + WidthPadding, textSize.Height + HeightPadding);

            // Add the event handler
            if (eventHandler != null)
                button.Click += eventHandler;

            return button;
        }

        public void CreateButtons(Panel panel, bool clearPanel = false)
        {
            if (clearPanel)
                panel.Controls.Clear();

            foreach (var cfg in PageButtonsConfigs)
            {
                panel.Controls.Add(
                    CreatePageButton(
                        cfg.Name, 
                        cfg.Text, 
                        cfg.ClickHandler, 
                        cfg.Checked
                    )
                );
            }
        }
    }
}
