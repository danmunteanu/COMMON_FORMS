namespace CommonForms.Factories
{
    public class Factory<T>
    {
        private static Dictionary<string, Creator> _dictionary = new();
        
        public delegate T Creator (string actionName);

        public static void RegisterCreator(string id, Creator actionCreator)
        {
            _dictionary.Add(id, actionCreator);
        }

        public static Creator Create(string id)
        {
            throw new NotImplementedException();
        }
    }
}
