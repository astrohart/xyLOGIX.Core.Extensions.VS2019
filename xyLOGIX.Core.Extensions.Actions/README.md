<a name='assembly'></a>
# xyLOGIX.Core.Extensions.Actions

## Contents

- [Resources](#T-xyLOGIX-Core-Extensions-Actions-Properties-Resources 'xyLOGIX.Core.Extensions.Actions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Actions-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Actions-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Actions.Properties.Resources.ResourceManager')
- [Round](#T-xyLOGIX-Core-Extensions-Actions-Round 'xyLOGIX.Core.Extensions.Actions.Round')
  - [ToNearestCent(value)](#M-xyLOGIX-Core-Extensions-Actions-Round-ToNearestCent-System-Decimal- 'xyLOGIX.Core.Extensions.Actions.Round.ToNearestCent(System.Decimal)')

<a name='T-xyLOGIX-Core-Extensions-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Core.Extensions.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Core-Extensions-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Core-Extensions-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Core-Extensions-Actions-Round'></a>
## Round `type`

##### Namespace

xyLOGIX.Core.Extensions.Actions

##### Summary

Exposes static methods to round various quantities to various values.

<a name='M-xyLOGIX-Core-Extensions-Actions-Round-ToNearestCent-System-Decimal-'></a>
### ToNearestCent(value) `method`

##### Summary

Rounds the specified `value` to the nearest cent, assuming
that the specified `value` is denominated in
`U.S. Dollars (USD)`.

##### Returns

Result of the rounding, using banker's rounding; or
[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') if not successful.



[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') is also returned if
[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') or less is passed as the argument of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) The [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value that
is to be rounded. |
