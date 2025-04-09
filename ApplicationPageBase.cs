using CommonForms.Components;
using RealityFrameworks;

namespace CommonForms
{
    public partial class ApplicationPageBase : UserControl
    {
        //  a delegate to update the status
        public delegate void UpdateStatusDelegate(string message);

        public UpdateStatusDelegate? UpdateStatusCallback { get; set; } = null;

        //  default to Desktop\TEMP, for now
        protected string DefaultOutputFolder = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TEMP");

        //  Reference to a FilesListComponent instance
        protected FilesListComponent? mFilesList = null;

        //  Reference to a FilesProcessor instance
        protected FilesProcessor? mFilesProcessor = null;

        public FilesListComponent? FilesList 
        { 
            get { return mFilesList; } 
            set
            {
                mFilesList = value;

                OnFilesListSet();
            }
        }

        public FilesProcessor? Processor
        {
            get { return mFilesProcessor; }
            set
            {
                mFilesProcessor = value;

                OnProcessorSet();
            }
        }

        public ApplicationPageBase()
        {
        }

        protected virtual void OnFilesListSet()
        {
            //  override and implement in derived classes for custom logic
            //  when setting the files list component
        }

        protected virtual void OnProcessorSet()
        {
            //  override and implement this in derived classes
            //  if something specific has to happen when setting the processor
        }

        public virtual void UpdateUI()
        {
            //  override and implement to force a custom UI update
            //  and reload the page's inner state
        }

        public virtual void UpdateLocale()
        {
            //  used to update localization strings in derived classes
        }

        public virtual void SaveSettings(ref Dictionary<string, string> iniKeys)
        {
            //  used to save custom settings to a dictionary
        }

        public virtual void LoadSettings(Dictionary<string, string> iniKeys)
        {
            //  used to load settings from a dictionary
        }

    }
}
