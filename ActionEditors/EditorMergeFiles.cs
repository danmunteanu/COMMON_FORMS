using RealityFrameworks;

namespace CommonForms
{
    public partial class EditorMergeFiles : EditorBase
    {
        private ActionMergeFiles _action = null;

        public RealityFrameworks.ActionMergeFiles Action { 
            get { return _action; }
            set { _action = value; LoadState(_action); }
        }

        public EditorMergeFiles()
        {
            InitializeComponent();
        }

        public override void SaveState()
        {
            //base.SaveState();

            //  UI -> Condition
        }

        private void LoadState(ActionMergeFiles amf)
        {
            //  Load Stuff from amf
        }
    }
}
