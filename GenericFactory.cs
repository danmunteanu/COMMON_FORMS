using RealityFrameworks;

namespace CommonForms
{
    public static class GenericFactory<BaseClass>
    {
        public delegate BaseClass Creator();

        private static readonly Dictionary<string, Creator> _factoryByName = new();

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

        public static int CountNames()
        {
            return _factoryByName.Count;
        }

        public static string GetNameAt(int idx)
        {
            return _factoryByName.ElementAt(idx).Key;
        }
    }
}
