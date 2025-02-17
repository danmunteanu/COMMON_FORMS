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
        public UpdateUI_Delegate? Callback_UpdateUI { get; set; }

        //  this is called when the progress bar needs to be updated
        //  the list component updates the local progress bar first 
        //  but if you need to update progress somewhere else, be my guest
        public UpdateProgress_Delegate? Callback_UpdateProgress { get; set; } = null;

        //  this is called everytime the list selection is changed
        public SelectionChanged_Delegate? Callback_SelectionChanged { get; set; } = null;

        private void Call_UpdateUI()
        {
            if (Callback_UpdateUI != null)
                Callback_UpdateUI();
        }

        // A wrapper to the UpdateProgress call, checking for null before the call.
        private void CallDelegate_UpdateProgress(int percent)
        {
            if (Callback_UpdateProgress != null)
                Callback_UpdateProgress(percent);
        }

        // This is called when the list's selection changes to pass the 
        // selected item's value as string to the assigned delegate.
        private void CallDelegate_OnSelectionChanged(string item)
        {
            if (Callback_SelectionChanged != null)
                Callback_SelectionChanged(item);
        }

    }
}
