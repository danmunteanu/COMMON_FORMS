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

        protected Stack<string> mErrors = new();

        public string PopError()
        {
            return mErrors.Pop();
        }

        public bool HasErrors()
        {
            return mErrors.Count > 0;
        }

        public void ClearErrors()
        {
            mErrors.Clear();
        }
    }
}
