using RealityFrameworks;
using System.Resources;

namespace CommonForms
{
    public partial class ApplicationPageBase : UserControl
    {
        public delegate void UpdateStatusDelegate(string message);
        public UpdateStatusDelegate? UpdateStatusCallback { get; set; } = null;

        protected string DefaultOutputFolder = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TEMP");

        protected ResourceManager? mResourceManager = null;
        protected Processor? mFilesProcessor = null;

        public ResourceManager? Resource
        {
            get { return mResourceManager; }
            set
            {
                mResourceManager = value;

                OnResourceSet();
            }
        }

        public Processor? Processor
        {
            get { return mFilesProcessor; }
            set
            {
                mFilesProcessor = value;

                OnProcessorSet();
            }
        }

        public FilesListComponent FilesListComponent { get; set; } = null;

        public ApplicationPageBase()
        {
        }

        protected virtual void OnResourceSet()
        {
            //  implement in derived class
        }

        protected virtual void OnProcessorSet()
        {
            //  implement in derived class
        }

        public virtual void UpdateUI()
        {
            //  implement in derived class
        }

        protected void CallUpdateStatus(string message)
        {
            if (UpdateStatusCallback != null)
                UpdateStatusCallback(message);
        }

        public virtual void StoreSettings(Dictionary<string, string> iniKeys)
        {

        }
    }
}
