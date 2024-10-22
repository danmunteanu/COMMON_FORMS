using RealityFrameworks;

namespace CommonForms
{
    public static class EditorFactory
    {
        public delegate UserControl EditorCreator();

        private static readonly Dictionary<Type, EditorCreator> _factoryByType =
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

        private static readonly Dictionary<string, EditorCreator> _factoryByName =
            new Dictionary<string, EditorCreator>
            {
                //  CONDITION Editors
                { "HasExtension", () => new EditorHasExtension() },
                { "IsFolder", () => new EditorIsFolder() },

                //  ACTION Editors
                //{ typeof(ActionAddYaml), () => new EditorAddYaml() },
                { "RenameFile", () => new EditorRenameFile() },
                //{ typeof(ActionUpdateYaml), () => new TAB_UpdateYaml() },
                { "MergeFiles", () => new EditorMergeFiles() },
                { "CopyFile", () => new EditorCopyFile() }
            };

        public static void RegisterEditor(string name, EditorCreator creator)
        {
            _factoryByName.Add(name, creator);
        }

        public static UserControl CreateActionEditor(RealityFrameworks.Action action)
        {
            if (_factoryByType.TryGetValue(action.GetType(), out var creator))
            {
                return creator();  // Call the method to create the editor
            }
            string message = string.Format("There is no editor registered for {0}.", action.Name);
            throw new InvalidOperationException(message);
        }

        public static UserControl CreateActionEditor(string actionName)
        {
            if (_factoryByName.TryGetValue(actionName, out var creator))
            {
                return creator();  // Call the method to create the editor
            }
            string message = string.Format("There is no editor registered for {0}.", actionName);
            throw new InvalidOperationException(message);
        }

        public static UserControl CreateConditionEditor(RealityFrameworks.Condition cond)
        {
            if (_factoryByType.TryGetValue(cond.GetType(), out var creator))
            {
                return creator();  // Call the method to create the editor
            }

            throw new InvalidOperationException("There is no editor registered for condition " + cond.Name);
        }

        public static UserControl CreateConditionEditor(string condName)
        {
            if (_factoryByName.TryGetValue(condName, out var creator))
            {
                return creator();  // Call the method to create the editor
            }
            string message = string.Format("There is no editor registered for {0}.", condName);
            throw new InvalidOperationException(message);
        }
    }
}
