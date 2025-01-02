namespace CommonForms
{
    public static class GenericFactory<TBase>
    {
        public delegate TBase Creator();

        private static readonly Dictionary<string, Creator> _creators = new();

        public static int Count => _creators.Count;

        //  Registers a creator delegate by id
        public static void Register(string id, Creator creator)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID cannot be null or empty.", nameof(id));

            if (creator == null)
                throw new ArgumentNullException(nameof(creator), "The creator delegate cannot be null.");

            if (!_creators.TryAdd(id, creator))
                throw new InvalidOperationException($"There is a creator already registered with ID \"{id}\"");
        }

        //  Calls the associated creator for the specified ID
        public static TBase Create(string id)
        {
            if (_creators.TryGetValue(id, out var creator))
                return creator();

            throw new KeyNotFoundException($"There is no creator registered with the ID \"{id}\".");
        }

        public static string GetNameAt(int idx)
        {
            return _creators.ElementAt(idx).Key;
        }
    }
}
