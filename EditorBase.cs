﻿namespace CommonForms
{
    /*
     * The base class for all Condition and Action editors
     */
    public class EditorBase : UserControl
    {
        //  override this in derived classes to validate the state of the  UI
        public virtual bool ValidateState()
        {
            return true;
        }

        //  loads the editor state from a concrete condition
        //  must override in derived classes
        public virtual void LoadState(RealityFrameworks.Conditions.Condition<string> cond)
            => throw new NotImplementedException();
        
       //  Saves the editor's state into the condition
        public virtual void SaveState(RealityFrameworks.Conditions.Condition<string> cond)
            => throw new NotImplementedException();

        //  Loads the state of the editor from a concrete Action
        //  Override in derived classes
        public virtual void LoadState(RealityFrameworks.Actions.Action<string> action)
            => throw new NotImplementedException();

        //  Saves the state of the editor to an Action instance
        //  Override in derived classes
        public virtual void SaveState(RealityFrameworks.Actions.Action<string> action)
            => throw new NotImplementedException();

        //  Resets the editor state - implement in derived classes
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
