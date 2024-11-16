namespace CommonForms
{
    public class EditorBase : UserControl
    {
        //  Saves UI state to Condition or Action, depending on Editor purpose
        public virtual void SaveState()
        {

        }

        public virtual bool ValidateState()
        {
            return true;
        }

        public virtual void LoadState(RealityFrameworks.Condition cond)
        {

        }

        public virtual void LoadState(RealityFrameworks.Action action)
        {

        }

        protected Stack<string> mErrorStack = new();

        public string PopError()
        {
            return mErrorStack.Pop();
        }

        public bool HasErrors()
        {
            return mErrorStack.Count > 0;
        }

        public void ClearErrors()
        {
            mErrorStack.Clear();
        }
    }
}
