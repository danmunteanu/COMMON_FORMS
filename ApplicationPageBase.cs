using CommonForms.Components;
using RealityFrameworks;

namespace CommonForms
{
    public partial class ApplicationPageBase : UserControl//, IApplicationComponent
    {
        public delegate void UpdateStatusDelegate(string message);
        public UpdateStatusDelegate? UpdateStatusCallback { get; set; } = null;

        protected string DefaultOutputFolder = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TEMP");

        //  Reference to a FilesListComponent instance
        protected FilesListComponent? mFilesList = null;

        //  Reference to a FilesProcessor instance
        protected FilesProcessor? mFilesProcessor = null;


        public Components.FilesListComponent? FilesList 
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
            //  override and implement in derived classes
        }

        protected virtual void OnProcessorSet()
        {
            //  implement this in derived classes
        }

        //  Do PROVIDE empty implementations for the interface methods below, or else
        //  the C# compiler won't make these accessible to this class,
        //  although they have default implementations in the interface

        public virtual void UpdateUI()
        {
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
