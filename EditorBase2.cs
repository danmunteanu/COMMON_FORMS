namespace CommonForms
{
    public partial class EditorBase2: UserControl
    {
        //  ERROR STACK
        protected Stack<string> mErrorStack = new();

        public EditorBase2()
        {
            InitializeComponent();
        }

        public virtual void LoadState(object item)
            => throw new NotImplementedException();

        public virtual void SaveState(object item)
            => throw new NotImplementedException();

        //  Resets the editor state - override in derived classes
        public virtual void ResetState() {}

        public virtual bool ValidateState()
            => true;

        public void PushError(string error)
            => mErrorStack.Push(error);

        public string PopError()
            => mErrorStack.Pop();

        public bool HasErrors()
            => mErrorStack.Count > 0;

        public void ClearErrors()
            => mErrorStack.Clear();
    }
}
