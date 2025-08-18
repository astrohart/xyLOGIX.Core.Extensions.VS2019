<a name='assembly'></a>
# xyLOGIX.Core.Extensions.Providers

## Contents

- [ControlFormAssociationProvider](#T-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider')
  - [#ctor()](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-#ctor 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.#ctor')
  - [Instance](#P-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-Instance 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.Instance')
  - [ParentFormDictionary](#P-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-ParentFormDictionary 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.ParentFormDictionary')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-#cctor 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.#cctor')
  - [Add(control)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-Add-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.Add(System.Windows.Forms.Control)')
  - [CleanupOnControlDestroyed(control)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-CleanupOnControlDestroyed-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.CleanupOnControlDestroyed(System.Windows.Forms.Control)')
  - [CleanupOnFormClosed(form)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-CleanupOnFormClosed-System-Windows-Forms-Form- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.CleanupOnFormClosed(System.Windows.Forms.Form)')
  - [DetachControl(control)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-DetachControl-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.DetachControl(System.Windows.Forms.Control)')
  - [DetachForm(form)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-DetachForm-System-Windows-Forms-Form- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.DetachForm(System.Windows.Forms.Form)')
  - [GetFormFor(control)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-GetFormFor-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.GetFormFor(System.Windows.Forms.Control)')
  - [OnMemberControlHandleDestroyed(sender,e)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-OnMemberControlHandleDestroyed-System-Object,System-EventArgs- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.OnMemberControlHandleDestroyed(System.Object,System.EventArgs)')
  - [OnMemberFormClosed(sender,e)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-OnMemberFormClosed-System-Object,System-Windows-Forms-FormClosedEventArgs- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.OnMemberFormClosed(System.Object,System.Windows.Forms.FormClosedEventArgs)')
  - [Remove(control)](#M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-Remove-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.Providers.ControlFormAssociationProvider.Remove(System.Windows.Forms.Control)')
- [Resources](#T-xyLOGIX-Core-Extensions-Providers-Properties-Resources 'xyLOGIX.Core.Extensions.Providers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Providers-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Providers-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Providers.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider'></a>
## ControlFormAssociationProvider `type`

##### Namespace

xyLOGIX.Core.Extensions.Providers

##### Summary

Defines associations between forms and their contained controls.

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of
this
class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IControlFormAssociationProvider](#T-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider 'xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider')
interface.

<a name='P-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-ParentFormDictionary'></a>
### ParentFormDictionary `property`

##### Summary

Reference to an instance of a dictionary that maps instances of
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control')s to the parent
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')s that contain them.

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of
this
class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-Add-System-Windows-Forms-Control-'></a>
### Add(control) `method`

##### Summary

Adds an association between the specified `control`
and the specified `form`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | (Required.) A
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') for whom an association should be
created between it and its containing
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form'). |

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-CleanupOnControlDestroyed-System-Windows-Forms-Control-'></a>
### CleanupOnControlDestroyed(control) `method`

##### Summary

Subscribes the
[](#E-System-Windows-Forms-Control-HandleDestroyed 'System.Windows.Forms.Control.HandleDestroyed') event of the
specified `control` to remove all the mappings for it from
our public dictionary.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | (Required.) A
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') for whom all the mappings should
be removed to its parent form(s) in our public dictionary. |

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-CleanupOnFormClosed-System-Windows-Forms-Form-'></a>
### CleanupOnFormClosed(form) `method`

##### Summary

Subscribes the [](#E-System-Windows-Forms-Form-FormClosed 'System.Windows.Forms.Form.FormClosed')
event of the specified `form` to un-associate it with all its
contained controls in our public dictionary.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | (Required.) A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
that should be un-associated with its contained controls in our internal
dictionary. |

##### Remarks

If the specified `form` is `null`
or disposed, or if the public dictionary has not been initialized, or if the
public dictionary contains no mappings for the specified
`form`, then this method does nothing.

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-DetachControl-System-Windows-Forms-Control-'></a>
### DetachControl(control) `method`

##### Summary

Removes the association(s) between the specified
`control` and its containing form(s).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | A [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that is
to be removed from our public dictionary. |

##### Remarks

This method is usually called as part of the handling of a
[](#E-System-Windows-Forms-Control-HandleDestroyed 'System.Windows.Forms.Control.HandleDestroyed') event for the
specified `control`.

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-DetachForm-System-Windows-Forms-Form-'></a>
### DetachForm(form) `method`

##### Summary

Called to remove all the key-value pairs that

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | (Required.) Reference to the instance of
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') whose associated controls are to be
removed. |

##### Remarks

This method is usually closed as part of the implementation of a
handler for the [](#E-System-Windows-Forms-Form-FormClosed 'System.Windows.Forms.Form.FormClosed') event for
the specified `form`.

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-GetFormFor-System-Windows-Forms-Control-'></a>
### GetFormFor(control) `method`

##### Summary

Given a reference to an instance of
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control'), tries to lookup the
corresponding parent [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that contains
the control in our dictionary.

##### Returns

If found, a reference to the instance of
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that contains the specified
`control`, or `null` if no such form was
found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | (Required.) An instance of
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') for whom the containing form is
to be obtained. |

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-OnMemberControlHandleDestroyed-System-Object,System-EventArgs-'></a>
### OnMemberControlHandleDestroyed(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-Control-HandleDestroyed 'System.Windows.Forms.Control.HandleDestroyed') event raised by a
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') in our public collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by removing the mapping between the
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that is the
`sender` of this event and the associated parent
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form').

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-OnMemberFormClosed-System-Object,System-Windows-Forms-FormClosedEventArgs-'></a>
### OnMemberFormClosed(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Form-FormClosed 'System.Windows.Forms.Form.FormClosed')
event raised by a form that has been associated with one or more control(s).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.Windows.Forms.FormClosedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosedEventArgs 'System.Windows.Forms.FormClosedEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by removing all the entries from our internal
dictionary that correspond to the specified form.

<a name='M-xyLOGIX-Core-Extensions-Providers-ControlFormAssociationProvider-Remove-System-Windows-Forms-Control-'></a>
### Remove(control) `method`

##### Summary

Removes the specified `control` and the corresponding
association to its containing [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form').

##### Returns

`true` if the specified operation(s) have completed
successfully; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | (Required.) Reference to an instance of
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that refers to the control that
is to be removed. |

<a name='T-xyLOGIX-Core-Extensions-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Core.Extensions.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Core-Extensions-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Core-Extensions-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
