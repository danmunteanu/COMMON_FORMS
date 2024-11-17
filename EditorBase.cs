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
            throw new NotImplementedException();
        }

        public virtual void SaveState(RealityFrameworks.Condition cond)
        {
            //  Saves the editor's state into the condition
            throw new NotImplementedException();
        }

        public virtual void LoadState(RealityFrameworks.Action action)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveState(RealityFrameworks.Action action)
        {
            throw new NotImplementedException();
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
