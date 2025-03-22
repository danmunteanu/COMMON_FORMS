using CommonForms.Components;
using RealityFrameworks;

namespace CommonForms
{
    public partial class ApplicationPageBase : UserControl
    {
        public delegate void UpdateStatusDelegate(string message);
        public UpdateStatusDelegate? UpdateStatusCallback { get; set; } = null;

        protected string DefaultOutputFolder = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TEMP");

        //  Reference to a FilesListComponent instance
        protected FilesListComponent? mFilesList = null;

        public Components.FilesListComponent? FilesList 
        { 
            get { return mFilesList; } 
            set
            {
                mFilesList = value;

                OnFilesListSet();
            }
        }

        //  Reference to a FilesProcessor instance
        protected FilesProcessor? mFilesProcessor = null;

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
            //  override and implement in derived classes
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
        }

        public virtual void SaveSettings(ref Dictionary<string, string> iniKeys)
        {         
        }

        public virtual void LoadSettings(Dictionary<string, string> iniKeys)
        {            
        }
    }
}
