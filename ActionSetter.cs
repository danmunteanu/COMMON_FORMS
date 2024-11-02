using RealityFrameworks;
using static CommonForms.EditorFactory;

namespace CommonForms
{
    public class ActionSetter
    {
        public delegate bool ActionSetterDelegate(RealityFrameworks.Action action, EditorBase editor);

        private static bool Tester<TAction, TEditor> (RealityFrameworks.Action action, EditorBase editor)
            where TAction : RealityFrameworks.Action
            where TEditor : EditorBase
        {
            if (action == null || editor == null)
                return false;

            if (action is TAction && editor is TEditor)
            {
                //((TEditor)editor).Action = ((TAction)action);
                return true;
            }

            return false;
        }

        public static void TryLoadState(RealityFrameworks.Action action, EditorBase editor)
        {
            foreach (ActionSetterDelegate actionSetter in _actionSetters)
            {
                if (actionSetter(action, editor))
                    break;
            }
        }

        public static void RegisterSetter(ActionSetterDelegate actionSetter)
        {
            _actionSetters.Add(actionSetter);
        }

        private static readonly List<ActionSetterDelegate> _actionSetters =
            new ()
            {
                { 
                    //  CopyFile
                    bool (RealityFrameworks.Action action, EditorBase editor) => {
                        if (action == null || editor == null)
                            return false;

                        if (action is ActionCopyFile && editor is EditorCopyFile)
                        {
                            ((EditorCopyFile)editor).Action = ((ActionCopyFile) action);
                            return true;
                        }
                        return false;
                    }
                },

                {
                    //  RenameFile
                    bool (RealityFrameworks.Action action, EditorBase editor) => {
                        if (action == null || editor == null)
                            return false;

                        if (action is ActionRenameFile && editor is EditorRenameFile)
                        {
                            ((EditorRenameFile)editor).Action = ((ActionRenameFile) action);
                            return true;
                        }
                        return false;
                    }
                },


                {
                    //  MergeFiles
                    bool (RealityFrameworks.Action action, EditorBase editor) => {
                        if (action == null || editor == null)
                            return false;

                        if (action is ActionMergeFiles && editor is EditorMergeFiles)
                        {
                            ((EditorMergeFiles)editor).Action = ((ActionMergeFiles) action);
                            return true;
                        }
                        return false;
                    }
                },
            };


}
}
