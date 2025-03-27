namespace CommonForms
{
    /*
     * The base class for all Condition and Action editors
     */
    public class EditorBase<T> : UserControl
    {
        //  override this in derived classes to validate the state of the UI
        public virtual bool ValidateState()
        {
            return true;
        }

        //  loads the editor state from a concrete condition, if it's a Condition editor
        public virtual void LoadState(RealityFrameworks.Conditions.Condition<T> cond)
            => throw new NotImplementedException();

        //  Saves the editor's state into the condition, if it's a Condition editor
         public virtual void SaveState(RealityFrameworks.Conditions.Condition<T> cond)
            => throw new NotImplementedException();

        //  Loads the state of the editor from a concrete Action, if it's an Action editor
        public virtual void LoadState(RealityFrameworks.Actions.Action<T> action)
            => throw new NotImplementedException();

        //  Saves the state of the editor to an Action instance, if it's an Action editor
        public virtual void SaveState(RealityFrameworks.Actions.Action<T> action)
            => throw new NotImplementedException();

        //  Resets the editor state - override in derived classes
        public virtual void ClearState()
        {
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
