namespace CommonForms.Components
{
    //  Everything delegate related for the FilesListComponent
    public partial class FilesListComponent
    {
        //  DELEGATE TYPES
        public delegate void UpdateUI_Delegate();
        public delegate void UpdateProgress_Delegate(int progress);
        public delegate void SelectionChanged_Delegate(string item);

        //  this will be called when pages have to update their UI
        public UpdateUI_Delegate? UpdateUI_Callback { get; set; }

        //  this is called when the progress bar needs to be updated
        //  the list component updates the local progress bar first 
        //  but if you need to update progress somewhere else, be my guest
        public UpdateProgress_Delegate? UpdateProgress_Callback { get; set; } = null;

        //  this is called everytime the list selection is changed
        public SelectionChanged_Delegate? SelectionChanged_Callback { get; set; } = null;

    }
}
