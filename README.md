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
**Inherits**: *UserControl*
<br>
**Methods**:
```cs
// override in derived classes to implement validation of the editor fields 
public virtual bool ValidateState()

// override in derived classes to load the state of a Condition into the editor
public virtual void LoadState(RealityFrameworks.Conditons.Condition cond)

// override in derived classes to save the state of the condition editor into a  Condition  
public virtual void SaveState(RealityFrameworks.Conditions.Condition cond)

// override in derived classes to load the state of an Action into the editor
public virtual void LoadState(RealityFrameworks.Actions.Action action)

// override in derived classes to save the state of the action editor into an Action  
public virtual void SaveState(RealityFrameworks.Actions.Action action)
```
This base class also includes an error stack to be used during the actual editor validation in derived classes.

## ApplicationPageBase

**Inherits**: *UserControl*

**Methods**

When your application logic must take action immediately after setting the Processor value, you will override: 
```cs
protected virtual void OnProcessorSet()
```

Override this to implement user interface updates.
```cs
public virtual void UpdateUI()
```

Override this to implement locale updates.
```cs
public virtual void UpdateLocale()
```

Two methods for saving / loading ini settings.
```cs
public virtual void StoreSettings()
public virtual void LoadSettings()
```

*..more coming soon..*
<br>
This project depends heavily on REALITY_FRAMEWORKS_DLL, which is not public (yet!).

But many parts of the code can be repurposed at will or serve as inspiration for you, dear visitor.

Re-use anything you'd like, but be warned: this work is in progress and will surely change over time.

That's it! 
I might come back and add some additional details. Or not, who knows. Since this is my project, I rule here (and do as I like).

Ciao ;)