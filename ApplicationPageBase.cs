using RealityFrameworks;

namespace CommonForms
{
    public partial class ApplicationPageBase : UserControl
    {
        public delegate void UpdateStatusDelegate(string message);
        public UpdateStatusDelegate? UpdateStatusCallback { get; set; } = null;

        protected string DefaultOutputFolder = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TEMP");

        //  FILESLIST link
        public Components.FilesListComponent? FilesList { get; set; } = null;

        //  PROCESSOR link
        protected Processor? mFilesProcessor = null;
        public Processor? Processor
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

        protected virtual void OnProcessorSet()
        {
            //  implement this in derived classes
        }

        public virtual void UpdateUI()
        {
            //  implement this in derived classes
        }

        public virtual void UpdateLocale()
        {
            //  implement this in derived classes
        }

        protected void CallUpdateStatus(string message)
        {
            if (UpdateStatusCallback != null)
                UpdateStatusCallback(message);
        }

        public virtual void StoreSettings(ref Dictionary<string, string> iniKeys)
        {
            //  implement this in derived classes
        }

        public virtual void LoadSettings(ref Dictionary<string, string> iniKeys)
        {
            //  implement this in derived classes
        }
    }
}
