using RealityFrameworks;
using System.Resources;

namespace CommonForms
{
    public partial class TAB_Base : UserControl
    {
        public delegate void DelegateUpdateStatus(string message);
        
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
            set { 
                mFilesProcessor = value;

                OnProcessorSet();
            }
        }

        public DelegateUpdateStatus UpdateStatus { get; set; } = null;

        public TAB_Base()
        {
        }

        protected virtual void OnResourceSet()
        {

        }

        protected virtual void OnProcessorSet()
        {

        }

        public virtual void ToggleUI()
        {

        }
    }
}
