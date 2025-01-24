This project contains all sorts of common utilities I use in two of my projects - MASS_YAML and MERGE_PDF.

## List of Components
You will find some of them in the Components folder and others in the root of the project.
- **FilesListComponent** provides a configurable list component to add files to a C# application.
- **FilesListSettings** serves as a configuration dialog for FilesListComponent
- **DialogSelectChange** configures a Condition and Action pair (known as a Change)
- **ApplicationPageBase** - base class for all application pages / tabs
- **EditorBase** - serves as a base class for all Condition and Action editors
- **PageButtonsFactory** - responsible with the configuration and creation of application page buttons

### Condition Editors
*Folder:* ConditionEditors
- EditorHasExtension
- EditorIsFolder
- EditorConditionGroup

### Action Editors
*Folder*: ActionEditors
- EditorActionGroup
- EditorCopyFile
- EditorRenameFile
- EditorMergeFiles

## Classes
### EditorBase
Inherits: *UserControl*
Methods:
- virtual bool ValidateState() - override this in derived classes to implement validation of the editor fields 
- virtual LoadState(Condition) - override this in derived classes to load the state of a Condition into the condition editor
- virtual SaveState(Condition) - override this in derived classes to save the state of the condition editor into a  Condition  
- virtual LoadState(Action) - override this in derived classes to load the internal state of an Action into the action editor
- virtual SaveState(Action) - override this in derived classes to save the state of the action editor into an Action
Also includes an error stack to be used during actual validation in the concrete classes

*..more coming soon..*

This project depends heavily on REALITY_FRAMEWORKS_DLL, which is not public (yet!).

But many parts of the code can be re-used at will or serve as inspiration for you, dear visitor.

Re-use anything you'd like, but be warned: this work is in progress and will surely change over time.

That's it! I might come back and add some additional details. Or I might not, who knows. This is my project and I do as I like here. 

Ciao ;)