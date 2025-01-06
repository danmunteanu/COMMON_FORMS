namespace CommonForms
{
    /*
     * Stores creators of class instances derived from TBase
     */
    public static class GenericFactory<TBase>
    {
        public delegate TBase Creator();

        //  The dictionary of creators
        private static readonly Dictionary<string, Creator> mCreators = new();

        public static int Count => mCreators.Count;

        //  Registers a creator delegate by id
        public static void Register(string id, Creator creator)
        {
            //  TODO: Localize the exception messages
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID cannot be null or empty.", nameof(id));

            if (creator == null)
                throw new ArgumentNullException(nameof(creator), "The creator delegate cannot be null.");

            if (!mCreators.TryAdd(id, creator))
                throw new InvalidOperationException($"There is a creator already registered with ID \"{id}\"");
        }

        //  Calls the associated creator for the specified ID
        public static TBase Create(string id)
        {
            if (mCreators.TryGetValue(id, out var creator))
                return creator();

            //  TODO: Localize the exception messages
            throw new KeyNotFoundException($"There is no creator registered with the ID \"{id}\".");
        }

        //  returns the ID of the creator at the specified index
        public static string GetNameAt(int idx)
        {
            return mCreators.ElementAt(idx).Key;
        }
    }
}
