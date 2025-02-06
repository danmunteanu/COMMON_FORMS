using RealityFrameworks.Conditions;

namespace CommonForms
{
    /*
     * The base class for all Condition and Action editors
     */
    public abstract class EditorBase<T> : UserControl
    {
        //  override this in derived classes to validate the state of the  UI
        public virtual bool ValidateState()
        {
            return true;
        }

        public virtual void LoadState(Condition<T> cond)
            //  loads the editor state from a concrete condition
            //  must override in derived classes
            => throw new NotImplementedException();
        
        public virtual void SaveState(Condition<T> cond)
        {
            //  Saves the editor's state into the condition
            throw new NotImplementedException();
        }

        public virtual void LoadState(RealityFrameworks.Actions.Action<T> action)
        {
            //  Loads the state of the editor based on a concrete Action - override in derived classes
            throw new NotImplementedException();
        }

        public virtual void SaveState(RealityFrameworks.Actions.Action<T> action)
        {
            //  Saves the state of the editor to an Action instance - override in derived classes
            throw new NotImplementedException();
        }

        //  ERROR STACK
        protected Stack<string> mErrorStack = new();

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
