namespace CommonForms
{
    public interface IApplicationComponent
	{
        public void UpdateUI();

        public void UpdateLocale();

        public void SaveSettings(ref Dictionary<string, string> iniKeys);

        public void LoadSettings(Dictionary<string, string> iniKeys);

    }
}
