namespace CommonForms
{
    public partial class EditorMergeFiles : EditorBase
    {
        RealityFrameworks.ActionMergeFiles Action { get; set; }

        public EditorMergeFiles()
        {
            InitializeComponent();
        }

        public override void SaveState()
        {
            //base.SaveState();

            //  UI -> Condition
        }
    }
}
