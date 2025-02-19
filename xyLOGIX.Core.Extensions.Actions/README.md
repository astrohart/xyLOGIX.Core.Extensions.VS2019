<a name='assembly'></a>
# xyLOGIX.Core.Extensions.Actions

## Contents

- [Prefer](#T-xyLOGIX-Core-Extensions-Actions-Prefer 'xyLOGIX.Core.Extensions.Actions.Prefer')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-Actions-Prefer-#cctor 'xyLOGIX.Core.Extensions.Actions.Prefer.#cctor')
  - [BoolOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-BoolOverNull-System-Nullable{System-Boolean},System-Boolean- 'xyLOGIX.Core.Extensions.Actions.Prefer.BoolOverNull(System.Nullable{System.Boolean},System.Boolean)')
  - [ByteOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ByteOverNull-System-Nullable{System-Byte},System-Byte- 'xyLOGIX.Core.Extensions.Actions.Prefer.ByteOverNull(System.Nullable{System.Byte},System.Byte)')
  - [CharOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-CharOverNull-System-Nullable{System-Char},System-Char- 'xyLOGIX.Core.Extensions.Actions.Prefer.CharOverNull(System.Nullable{System.Char},System.Char)')
  - [DecimalOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-DecimalOverNull-System-Nullable{System-Decimal},System-Decimal- 'xyLOGIX.Core.Extensions.Actions.Prefer.DecimalOverNull(System.Nullable{System.Decimal},System.Decimal)')
  - [DoubleOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-DoubleOverNull-System-Nullable{System-Double},System-Double- 'xyLOGIX.Core.Extensions.Actions.Prefer.DoubleOverNull(System.Nullable{System.Double},System.Double)')
  - [FloatOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-FloatOverNull-System-Nullable{System-Single},System-Single- 'xyLOGIX.Core.Extensions.Actions.Prefer.FloatOverNull(System.Nullable{System.Single},System.Single)')
  - [IntOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-IntOverNull-System-Nullable{System-Int32},System-Int32- 'xyLOGIX.Core.Extensions.Actions.Prefer.IntOverNull(System.Nullable{System.Int32},System.Int32)')
  - [IntPtrOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-IntPtrOverNull-System-Nullable{System-IntPtr},System-IntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.IntPtrOverNull(System.Nullable{System.IntPtr},System.IntPtr)')
  - [LongOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-LongOverNull-System-Nullable{System-Int64},System-Int64- 'xyLOGIX.Core.Extensions.Actions.Prefer.LongOverNull(System.Nullable{System.Int64},System.Int64)')
  - [LongOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-LongOverNull-System-Nullable{System-UInt64},System-UInt64- 'xyLOGIX.Core.Extensions.Actions.Prefer.LongOverNull(System.Nullable{System.UInt64},System.UInt64)')
  - [NonZeroIntPtrOverZero(valueToCheck,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroIntPtrOverZero-System-IntPtr,System-IntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.NonZeroIntPtrOverZero(System.IntPtr,System.IntPtr)')
  - [NonZeroUIntPtrOverZero(valueToCheck,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroUIntPtrOverZero-System-UIntPtr,System-UIntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.NonZeroUIntPtrOverZero(System.UIntPtr,System.UIntPtr)')
  - [ObjectOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ObjectOverNull-System-Object,System-Object- 'xyLOGIX.Core.Extensions.Actions.Prefer.ObjectOverNull(System.Object,System.Object)')
  - [SByteOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-SByteOverNull-System-Nullable{System-SByte},System-SByte- 'xyLOGIX.Core.Extensions.Actions.Prefer.SByteOverNull(System.Nullable{System.SByte},System.SByte)')
  - [ShortOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ShortOverNull-System-Nullable{System-Int16},System-Int16- 'xyLOGIX.Core.Extensions.Actions.Prefer.ShortOverNull(System.Nullable{System.Int16},System.Int16)')
  - [StringOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-StringOverNull-System-String,System-String- 'xyLOGIX.Core.Extensions.Actions.Prefer.StringOverNull(System.String,System.String)')
  - [UInt32OverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UInt32OverNull-System-Nullable{System-UInt32},System-UInt32- 'xyLOGIX.Core.Extensions.Actions.Prefer.UInt32OverNull(System.Nullable{System.UInt32},System.UInt32)')
  - [UIntPtrOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UIntPtrOverNull-System-Nullable{System-UIntPtr},System-UIntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.UIntPtrOverNull(System.Nullable{System.UIntPtr},System.UIntPtr)')
  - [UShortOverNull(nullableValue,preferredValue)](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UShortOverNull-System-Nullable{System-UInt16},System-UInt16- 'xyLOGIX.Core.Extensions.Actions.Prefer.UShortOverNull(System.Nullable{System.UInt16},System.UInt16)')
- [Resources](#T-xyLOGIX-Core-Extensions-Actions-Properties-Resources 'xyLOGIX.Core.Extensions.Actions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Actions-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Actions-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Actions.Properties.Resources.ResourceManager')
- [Round](#T-xyLOGIX-Core-Extensions-Actions-Round 'xyLOGIX.Core.Extensions.Actions.Round')
  - [ToNearestCent(value)](#M-xyLOGIX-Core-Extensions-Actions-Round-ToNearestCent-System-Decimal- 'xyLOGIX.Core.Extensions.Actions.Round.ToNearestCent(System.Decimal)')

<a name='T-xyLOGIX-Core-Extensions-Actions-Prefer'></a>
## Prefer `type`

##### Namespace

xyLOGIX.Core.Extensions.Actions

##### Summary

Provides a set of static methods that preferentially return a specified
preferred value over a nullable value, if the nullable value is
`null` or does not have a value.

##### Remarks

This class comes in particularly handy when the use-case is to merge
settings either specified on the command-line by the user or not specified,
with the config of the application.

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Prefer](#T-xyLOGIX-Core-Extensions-Actions-Prefer 'xyLOGIX.Core.Extensions.Actions.Prefer') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-BoolOverNull-System-Nullable{System-Boolean},System-Boolean-'></a>
### BoolOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Required.) A nullable
[Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) Reference to the preferred
[Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-ByteOverNull-System-Nullable{System-Byte},System-Byte-'></a>
### ByteOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | (Required.) A nullable
[Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | (Required.) Reference to the preferred
[Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-CharOverNull-System-Nullable{System-Char},System-Char-'></a>
### CharOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Char}') | (Required.) A nullable
[Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | (Required.) Reference to the preferred
[Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-DecimalOverNull-System-Nullable{System-Decimal},System-Decimal-'></a>
### DecimalOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | (Required.) A nullable
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Reference to the preferred
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-DoubleOverNull-System-Nullable{System-Double},System-Double-'></a>
### DoubleOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | (Required.) A nullable
[Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | (Required.) Reference to the preferred
[Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-FloatOverNull-System-Nullable{System-Single},System-Single-'></a>
### FloatOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | (Required.) A nullable
[Single](#T-Single 'Single') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | (Required.) Reference to the preferred
[Single](#T-Single 'Single') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-IntOverNull-System-Nullable{System-Int32},System-Int32-'></a>
### IntOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | (Required.) A nullable
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Reference to the preferred
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-IntPtrOverNull-System-Nullable{System-IntPtr},System-IntPtr-'></a>
### IntPtrOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.IntPtr}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.IntPtr}') | (Required.) A nullable
[IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | (Required.) Reference to the preferred
[IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-LongOverNull-System-Nullable{System-Int64},System-Int64-'></a>
### LongOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | (Required.) A nullable
[Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | (Required.) Reference to the preferred
[Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-LongOverNull-System-Nullable{System-UInt64},System-UInt64-'></a>
### LongOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | (Required.) A nullable
[UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | (Required.) Reference to the preferred
[UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroIntPtrOverZero-System-IntPtr,System-IntPtr-'></a>
### NonZeroIntPtrOverZero(valueToCheck,preferredValue) `method`

##### Summary

Preferentially returns the specified `preferredValue` over
the `valueToCheck`, if the specified
`valueToCheck` is `null` or it does not
have a value; otherwise, the value of the `valueToCheck` is
returned.

##### Returns

The specified `preferredValue` over the
`valueToCheck`, if the specified
`valueToCheck` is `null` or it does not
have a value; otherwise, the value of the `valueToCheck` is
returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueToCheck | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | (Required.) A nullable
[IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | (Required.) Reference to the preferred
[IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') value that is to be returned if the
`valueToCheck` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroUIntPtrOverZero-System-UIntPtr,System-UIntPtr-'></a>
### NonZeroUIntPtrOverZero(valueToCheck,preferredValue) `method`

##### Summary

Preferentially returns the specified `preferredValue` over
the `valueToCheck`, if the specified
`valueToCheck` is `null` or it does not
have a value; otherwise, the value of the `valueToCheck` is
returned.

##### Returns

The specified `preferredValue` over the
`valueToCheck`, if the specified
`valueToCheck` is `null` or it does not
have a value; otherwise, the value of the `valueToCheck` is
returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueToCheck | [System.UIntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UIntPtr 'System.UIntPtr') | (Required.) A nullable
[UIntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UIntPtr 'System.UIntPtr') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.UIntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UIntPtr 'System.UIntPtr') | (Required.) Reference to the preferred
[UIntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UIntPtr 'System.UIntPtr') value that is to be returned if the
`valueToCheck` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-ObjectOverNull-System-Object,System-Object-'></a>
### ObjectOverNull(nullableValue,preferredValue) `method`

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

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-SByteOverNull-System-Nullable{System-SByte},System-SByte-'></a>
### SByteOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.SByte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.SByte}') | (Required.) A nullable
[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte') | (Required.) Reference to the preferred
[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-ShortOverNull-System-Nullable{System-Int16},System-Int16-'></a>
### ShortOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.Int16}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int16}') | (Required.) A nullable
[Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | (Required.) Reference to the preferred
[Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-StringOverNull-System-String,System-String-'></a>
### StringOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') variable whose value is to be
returned if it indeed does have a non-`null`, non-blank value. |
| preferredValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the preferred value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-UInt32OverNull-System-Nullable{System-UInt32},System-UInt32-'></a>
### UInt32OverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | (Required.) A nullable
[UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | (Required.) Reference to the preferred
[UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-UIntPtrOverNull-System-Nullable{System-UIntPtr},System-UIntPtr-'></a>
### UIntPtrOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.UIntPtr}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UIntPtr}') | (Required.) A nullable
[UIntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UIntPtr 'System.UIntPtr') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.UIntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UIntPtr 'System.UIntPtr') | (Required.) Reference to the preferred
[UIntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UIntPtr 'System.UIntPtr') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

<a name='M-xyLOGIX-Core-Extensions-Actions-Prefer-UShortOverNull-System-Nullable{System-UInt16},System-UInt16-'></a>
### UShortOverNull(nullableValue,preferredValue) `method`

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
| nullableValue | [System.Nullable{System.UInt16}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt16}') | (Required.) A nullable
[UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') variable whose value is to be returned if it
indeed does have a value. |
| preferredValue | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | (Required.) Reference to the preferred
[UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') value that is to be returned if the
`nullableValue` is `null` or does not have a
value. |

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
