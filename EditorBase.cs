using RealityFrameworks.Conditions;

namespace CommonForms
{
    public class EditorBase : UserControl
    {
        public virtual bool ValidateState()
        {
            return true;
        }

        public virtual void LoadState(Condition cond)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveState(Condition cond)
        {
            //  Saves the editor's state into the condition
            throw new NotImplementedException();
        }

        public virtual void LoadState(RealityFrameworks.Actions.Action action)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveState(RealityFrameworks.Actions.Action action)
        {
            throw new NotImplementedException();
        }

        protected Stack<string> mErrorStack = new();

        public void PushError(string error)
        {
            mErrorStack.Push(error);
        }

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
