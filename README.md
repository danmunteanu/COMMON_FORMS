This project contains all sorts of common utilities I use in two of my projects - MASS_YAML and MERGE_PDF.

## List Of Components
- FilesListComponent provides a configurable component to add files to a C# application.
- FilesListSettings serves as a configuration dialog for FilesListComponent
- ApplicationPageBase - base class for all application pages / tabs
- DialogSelectChange configures a Condition and Action pair (known as a Change)
- EditorBase - a base class for all Condition and Action editors
- PageButtonsFactory - responsible with the configuration and creation of application page buttons

### Condition Editors
- EditorHasExtension
- EditorIsFolder
- EditorConditionGroup

### Action Editors
- EditorActionGroup
- EditorCopyFile
- EditorRenameFile
- EditorMergeFiles

The project depends on parts of the REALITY_FRAMEWORKS_DLL, which is not yet public.
But some part of the code can be re-used at will.

Re-use any of this code as you wish. 
But be warned, this is a work in progress and will change over time.

