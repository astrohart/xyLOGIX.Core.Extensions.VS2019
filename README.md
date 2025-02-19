# xyLOGIX.Core.Extensions `class library`

This C# class library, created in Visual Studio 2019 using C# 7.3 and the .NET Framework 4.8, exposes a repository of `*Extensions` static classes that provide helpful extension methods for use elsewhere in xyLOGIX software.

## Overview of Classes and Methods

### StringExtensions
- `IsNullOrEmpty(this string value)`: Checks if the string is null or empty.
- `IsNullOrWhiteSpace(this string value)`: Checks if the string is null or consists only of white-space characters.

### DateTimeExtensions
- `ToFormattedString(this DateTime dateTime, string format)`: Converts the DateTime to a formatted string.
- `IsWeekend(this DateTime dateTime)`: Checks if the DateTime falls on a weekend.

### EnumerableExtensions
- `IsNullOrEmpty<T>(this IEnumerable<T> enumerable)`: Checks if the enumerable is null or empty.
- `ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)`: Performs the specified action on each element of the enumerable.

### DictionaryExtensions
- `GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)`: Gets the value associated with the specified key or returns the default value if the key is not found.

## Overview of the `Prefer` Class

The `Prefer` class in the `xyLOGIX.Core.Extensions` namespace provides a set of static methods that preferentially return a specified value over a nullable value. These methods are useful for merging values supplied from different sources, such as command line arguments and application configuration settings.

### Use Case

The primary use case for the `Prefer` class is to handle scenarios where values may or may not be supplied by the user. If a value is provided (i.e., the nullable parameter is non-`null`), the methods return this value. Otherwise, they return a preferred value, typically sourced from application configuration settings. This allows for seamless integration of user-supplied values with default configuration settings.

### Methods

The `Prefer` class includes methods for various data types, including:

- `BoolOverNull`: Handles nullable `bool` values.
- `ByteOverNull`: Handles nullable `byte` values.
- `CharOverNull`: Handles nullable `char` values.
- `DecimalOverNull`: Handles nullable `decimal` values.
- `DoubleOverNull`: Handles nullable `double` values.
- `FloatOverNull`: Handles nullable `float` values.
- `IntOverNull`: Handles nullable `int` values.
- `IntPtrOverNull`: Handles nullable `IntPtr` values.
- `LongOverNull`: Handles nullable `long` values.
- `NonZeroIntPtrOverZero`: Handles `IntPtr` values, preferring non-`IntPtr.Zero` values.
- `NonZeroUIntPtrOverZero`: Handles `UIntPtr` values, preferring non-zero values.
- `ObjectOverNull`: Handles nullable `object` values.
- `SByteOverNull`: Handles nullable `sbyte` values.
- `ShortOverNull`: Handles nullable `short` values.
- `StringOverNull`: Handles nullable `string` values.
- `UInt32OverNull`: Handles nullable `uint` values.
- `UIntPtrOverNull`: Handles nullable `UIntPtr` values.
- `UShortOverNull`: Handles nullable `ushort` values.

Each method follows a similar pattern: if the nullable value is non-`null` and has a value, it is returned; otherwise, the preferred value is returned. This ensures that the application can gracefully handle missing or unspecified values by falling back to default settings.

## Code documentation
[Click here](https://github.com/astrohart/xyLOGIX.Core.Extensions.VS2019/blob/master/xyLOGIX.Core.Extensions/README.md) for class library code documentation.
