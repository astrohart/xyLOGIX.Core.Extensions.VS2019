<a name='assembly'></a>
# xyLOGIX.Core.Extensions.Providers.Interfaces

## Contents

- [IControlFormAssociationProvider](#T-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider 'xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider')
  - [Add(control)](#M-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider-Add-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider.Add(System.Windows.Forms.Control)')
  - [GetFormFor(control)](#M-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider-GetFormFor-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider.GetFormFor(System.Windows.Forms.Control)')
- [Resources](#T-xyLOGIX-Core-Extensions-Providers-Interfaces-Properties-Resources 'xyLOGIX.Core.Extensions.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Providers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Providers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider'></a>
## IControlFormAssociationProvider `type`

##### Namespace

xyLOGIX.Core.Extensions.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a provider of
associations between controls and the form(s) that contain them.

<a name='M-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider-Add-System-Windows-Forms-Control-'></a>
### Add(control) `method`

##### Summary

Adds an association between the specified `control` and the
specified `form`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | (Required.) A
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') for whom an association should be
created between it and its containing
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form'). |

<a name='M-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider-GetFormFor-System-Windows-Forms-Control-'></a>
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

<a name='T-xyLOGIX-Core-Extensions-Providers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Core.Extensions.Providers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Core-Extensions-Providers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Core-Extensions-Providers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
