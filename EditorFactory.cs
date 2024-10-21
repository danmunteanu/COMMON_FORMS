using RealityFrameworks;

namespace CommonForms
{
    public static class EditorFactory
    {
        public delegate UserControl EditorCreator();

        private static readonly Dictionary<Type, EditorCreator> _factories =
            new Dictionary<Type, EditorCreator>
            {
                //  CONDITION Editors
                { typeof(ConditionHasExtension), () => new EditorHasExtension() },
                { typeof(ConditionIsFolder), () => new EditorIsFolder() },

                //  ACTION Editors
                //{ typeof(ActionAddYaml), () => new EditorAddYaml() },
                { typeof(ActionRenameFile), () => new EditorRenameFile() },
                //{ typeof(ActionUpdateYaml), () => new TAB_UpdateYaml() },
                { typeof(ActionMergeFiles), () => new EditorMergeFiles() },
                { typeof(ActionCopyFile), () => new EditorCopyFile() }
            };

        public static UserControl CreateActionEditor(RealityFrameworks.Action action)
        {
            if (_factories.TryGetValue(action.GetType(), out var creator))
            {
                return creator();  // Call the method to create the editor
            }
            string message = string.Format("There is no editor registered for {0}.", action.Name);
            throw new InvalidOperationException(message);
        }

        public static UserControl CreateConditionEditor(RealityFrameworks.Condition cond)
        {
            if (_factories.TryGetValue(cond.GetType(), out var creator))
            {
                return creator();  // Call the method to create the editor
            }

            throw new InvalidOperationException("There is no editor registered for condition " + cond.Name);
        }
    }
}
