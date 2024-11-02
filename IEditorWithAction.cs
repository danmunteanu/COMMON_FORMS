namespace CommonForms
{
    public interface IEditorWithAction<TAction>        
    {
        //TAction _action = null;

        TAction Action { get; set; }
    }
}
