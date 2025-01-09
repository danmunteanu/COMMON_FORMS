
namespace CommonForms.Components
{
    //  Everything delegate related for the FilesListComponent
    public partial class FilesListComponent
    {
        //  DELEGATE TYPES
        public delegate void UpdateUIDelegate();
        public delegate void UpdateProgressDelegate(int progress);
        public delegate void SelectionChangedDelegate(string item);

        //  this will be called when pages have to update their UI
        public UpdateUIDelegate? UpdateUICallback { get; set; } = null;

        //  this is called when the progress bar needs to be updated
        //  the list component updates the local progress bar first 
        //  but if you need to update progress somewhere else, be my guest
        public UpdateProgressDelegate? UpdateProgressCallback { get; set; } = null;

        //  this is called everytime the list selection is changed
        public SelectionChangedDelegate? SelectionChangedCallback { get; set; } = null;

        private void CallUpdateUI()
        {
            if (UpdateUICallback != null)
                UpdateUICallback();
        }

        // A wrapper to the UpdateProgress call, checking for null before the call.
        private void CallUpdateProgress(int percent)
        {
            if (UpdateProgressCallback != null)
                UpdateProgressCallback(percent);
        }

        // This is called when the list's selection changes to pass the 
        // selected item's value as string to the assigned delegate.
        private void CallOnSelectionChanged(string item)
        {
            if (SelectionChangedCallback != null)
                SelectionChangedCallback(item);
        }

    }
}
