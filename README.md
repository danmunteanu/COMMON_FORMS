# COMMON_FORMS

This project contains all sorts of common utilities I use in two of my C# projects - MASS_YAML and MERGE_PDF.
## List of Components  
Some components can be found in the **Components** folder, while others are located in the root of the project.

### Main Components  
- **FilesListComponent**: A configurable list component for adding files to a C# application.  
- **FilesListSettings**: A configuration dialog for the `FilesListComponent`.  
- **DialogSelectChange**: Used to configure a Condition and Action pair (referred to as a "Change").  
- **ApplicationPageBase**: The base class for all application pages or tabs.  
- **EditorBase**: Serves as the base class for all Condition and Action editors.  
- **PageButtonsFactory**: Handles the configuration and creation of application page buttons.

---

### Condition Editors  
**Folder:** `ConditionEditors`  
- **EditorHasExtension**: Evaluates files based on their extensions.  
- **EditorIsFolder**: Checks whether a target is a folder.  
- **EditorConditionGroup**: Groups multiple conditions for composite evaluations.

---

### Action Editors  
**Folder:** `ActionEditors`  
- **EditorActionGroup**: Groups multiple actions to execute as a sequence.  
- **EditorCopyFile**: Facilitates copying files.  
- **EditorRenameFile**: Handles file renaming operations.  
- **EditorMergeFiles**: Combines multiple files into one.


## Classes  

### **EditorBase**  
**Inherits**: *UserControl*  

#### **Overview**  
`EditorBase` serves as the foundation for all editor components, providing methods to validate, load, and save the state of both Conditions and Actions. It also includes an **error stack** to assist with validation in derived classes.  

#### **Methods**  
```cs
// Validates the editor fields. Override in derived classes, if needed.
public virtual bool ValidateState()

// Loads the state of a Condition into the editor. Override in derived classes, if needed.
public virtual void LoadState(RealityFrameworks.Conditions.Condition cond)

// Saves the state of the Condition editor into a Condition. Override in derived classes, if needed.
public virtual void SaveState(RealityFrameworks.Conditions.Condition cond)

// Loads the state of an Action into the editor. Override in derived classes, if needed.
public virtual void LoadState(RealityFrameworks.Actions.Action action)

// Saves the state of the Action editor into an Action. Override in derived classes, if needed.
public virtual void SaveState(RealityFrameworks.Actions.Action action)

```

## ApplicationPageBase

**Inherits**: *UserControl*

**Methods**

```cs
//	Override when your application logic must take action immediately after setting the Processor value 
protected virtual void OnProcessorSet()

//	Override to implement user interface updates
public virtual void UpdateUI()

//	Override to implement locale updates.
public virtual void UpdateLocale()

//	Override to save and load ini settings.
public virtual void StoreSettings()
public virtual void LoadSettings()
```cs

*..more coming soon..*

<br>
This project depends heavily on REALITY_FRAMEWORKS_DLL, which is not public (yet!).

But many parts of the code can be repurposed at will or serve as inspiration for you, dear visitor.

Re-use anything you'd like, but be warned: this work is in progress and will surely change over time.

That's it! 
I might come back and add some additional details. Or not, who knows. Since this is my project, I rule here (and do as I like).

Ciao ;)