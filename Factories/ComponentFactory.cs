using RealityFrameworks;

namespace CommonForms
{
    public static class ComponentFactory<BaseClass>
    {
        public delegate BaseClass Creator();

        private static readonly Dictionary<Type, Creator> _factoryByType =
            new Dictionary<Type, Creator>
            {
                //  CONDITION Editors
                //{ typeof(ConditionHasExtension), () => new EditorHasExtension() },
                //{ typeof(ConditionIsFolder), () => new EditorIsFolder() },

                //  ACTION Editors
                //{ typeof(ActionAddYaml), () => new EditorAddYaml() },
                //{ typeof(ActionRenameFile), () => new EditorRenameFile() },
                //{ typeof(ActionUpdateYaml), () => new TAB_UpdateYaml() },
                //{ typeof(ActionMergeFiles), () => new EditorMergeFiles() },
                //{ typeof(ActionCopyFile), () => new EditorCopyFile() }
            };

        private static readonly Dictionary<string, Creator> _factoryByName =
            new Dictionary<string, Creator>
            {
                //  CONDITION Editors
                //{ "HasExtension", () => new EditorHasExtension() },
                //{ "IsFolder", () => new EditorIsFolder() },

                //  ACTION Editors
                //{ "RenameFile", () => new EditorRenameFile() },
                //{ "MergeFiles", () => new EditorMergeFiles() },
                //{ "CopyFile", () => new EditorCopyFile() }
            };

        public static void RegisterCreatorByName(string id, Creator creator)
        {
            _factoryByName.Add(id, creator);
        }

        public static BaseClass CreateByName(string id)
        {
            if (_factoryByName.TryGetValue(id, out var creator))
            {
                return creator();  // Call the method to create the editor
            }
            
            string message = string.Format("There is no editor registered for {0}.", id);
            throw new InvalidOperationException(message);
        }

        public static void RegisterEditorByName(string name, Creator creator)
        {
            _factoryByName.Add(name, creator);
        }

        public static void RegisterEditorByType(Type type, Creator creator)
        {
            _factoryByType.Add(type, creator);
        }


        public static BaseClass CreateActionEditor(RealityFrameworks.Action action)
        {
            if (_factoryByType.TryGetValue(action.GetType(), out var creator))
            {
                return creator();  // Call the method to create the editor
            }
            string message = string.Format("There is no editor registered for {0}.", action.Name);
            throw new InvalidOperationException(message);
        }

        public static BaseClass CreateActionEditor(string actionName)
        {
            if (_factoryByName.TryGetValue(actionName, out var creator))
            {
                return creator();  // Call the method to create the editor
            }
            string message = string.Format("There is no editor registered for {0}.", actionName);
            throw new InvalidOperationException(message);
        }

        public static BaseClass CreateConditionEditor(RealityFrameworks.Condition cond)
        {
            if (_factoryByType.TryGetValue(cond.GetType(), out var creator))
            {
                return creator();  // Call the method to create the editor
            }

            throw new InvalidOperationException("There is no editor registered for condition " + cond.Name);
        }

        public static BaseClass CreateConditionEditor(string condName)
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
