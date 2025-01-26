**Inherits**: *UserControl*

## Methods

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
