using RealityFrameworks;

namespace CommonForms
{
    public static class GenericFactory<BaseClass>
    {
        public delegate BaseClass Creator();

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
            
            string message = string.Format("There is no creator registered for {0}.", id);
            throw new InvalidOperationException(message);
        }
    }
}
