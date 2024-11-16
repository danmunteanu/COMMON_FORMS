using RealityFrameworks;
using System.Resources;

namespace CommonForms
{
    public partial class ApplicationPageBase : UserControl
    {
        public delegate void UpdateStatusDelegate(string message);
        public UpdateStatusDelegate UpdateStatus { get; set; } = null;

        protected string DefaultOutputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TEMP");

        protected ResourceManager mResourceManager = null;
        protected FilesProcessor mFilesProcessor = null;

        public ResourceManager Resource
        {
            get { return mResourceManager; }
            set
            {
                mResourceManager = value;

                OnResourceSet();
            }
        }

        public FilesProcessor Processor
        {
            get { return mFilesProcessor; }
            set
            {
                mFilesProcessor = value;

                OnProcessorSet();
            }
        }

        public FilesListControl FilesListComponent { get; set; } = null;

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
            if (UpdateStatus != null)
                UpdateStatus(message);
        }
    }
}
