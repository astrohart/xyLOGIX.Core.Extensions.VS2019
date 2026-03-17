<a name='assembly'></a>
# xyLOGIX.Core.Extensions.Dynamic

## Contents

- [DynamicPrefer](#T-xyLOGIX-Core-Extensions-Dynamic-DynamicPrefer 'xyLOGIX.Core.Extensions.Dynamic.DynamicPrefer')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-Dynamic-DynamicPrefer-#cctor 'xyLOGIX.Core.Extensions.Dynamic.DynamicPrefer.#cctor')
  - [DynamicOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Dynamic-DynamicPrefer-DynamicOverNull-System-Object,System-Object- 'xyLOGIX.Core.Extensions.Dynamic.DynamicPrefer.DynamicOverNull(System.Object,System.Object)')
- [Resources](#T-xyLOGIX-Core-Extensions-Dynamic-Properties-Resources 'xyLOGIX.Core.Extensions.Dynamic.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Dynamic-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Dynamic.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Dynamic-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Dynamic.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Core-Extensions-Dynamic-DynamicPrefer'></a>
## DynamicPrefer `type`

##### Namespace

xyLOGIX.Core.Extensions.Dynamic

##### Summary

Contains methods that allow you to prefer one type over another when working
with `dynamic` objects.

<a name='M-xyLOGIX-Core-Extensions-Dynamic-DynamicPrefer-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [DynamicPrefer](#T-xyLOGIX-Core-Extensions-Dynamic-DynamicPrefer 'xyLOGIX.Core.Extensions.Dynamic.DynamicPrefer') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-Dynamic-DynamicPrefer-DynamicOverNull-System-Object,System-Object-'></a>
### DynamicOverNull(nullableValue,preferredValue) `method`

##### Summary

Preferentially returns the specified `preferredValue` over
the `nullableValue`, if the specified
`nullableValue` is `null` or it does not
have a value; otherwise, the value of the `nullableValue` is
returned.

##### Returns

The specified `preferredValue` over the
`nullableValue`, if the specified
`nullableValue` is `null` or it does not
have a value; otherwise, the value of the `nullableValue` is
returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nullableValue | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) A [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') variable whose value is to be
returned if it indeed does have a non-`null`, non-blank value. |
| preferredValue | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) A [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object')
containing the preferred value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='T-xyLOGIX-Core-Extensions-Dynamic-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Core.Extensions.Dynamic.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Core-Extensions-Dynamic-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Core-Extensions-Dynamic-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
