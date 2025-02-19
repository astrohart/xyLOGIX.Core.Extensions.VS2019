<a name='assembly'></a>
# xyLOGIX.Core.Extensions.Tests

## Contents

- [NumberExtensionsTests](#T-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests')
  - [TestIsStrictlyInRangeWithLowerBound()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-TestIsStrictlyInRangeWithLowerBound 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.TestIsStrictlyInRangeWithLowerBound')
  - [TestIsStrictlyInRangeWithMiddleValue()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-TestIsStrictlyInRangeWithMiddleValue 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.TestIsStrictlyInRangeWithMiddleValue')
  - [TestIsStrictlyInRangeWithUpperBound()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-TestIsStrictlyInRangeWithUpperBound 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.TestIsStrictlyInRangeWithUpperBound')
  - [Test_IsNegative_ReturnsFalse_WhenPassed_PositiveQuantity()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsNegative_ReturnsFalse_WhenPassed_PositiveQuantity 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.Test_IsNegative_ReturnsFalse_WhenPassed_PositiveQuantity')
  - [Test_IsNegative_ReturnsFalse_WhenPassed_Zero()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsNegative_ReturnsFalse_WhenPassed_Zero 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.Test_IsNegative_ReturnsFalse_WhenPassed_Zero')
  - [Test_IsNegative_ReturnsTrue_WhenPassed_NegativeQuantity()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsNegative_ReturnsTrue_WhenPassed_NegativeQuantity 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.Test_IsNegative_ReturnsTrue_WhenPassed_NegativeQuantity')
  - [Test_IsPositive_ReturnsFalse_WhenPassed_NegativeQuantity()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsPositive_ReturnsFalse_WhenPassed_NegativeQuantity 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.Test_IsPositive_ReturnsFalse_WhenPassed_NegativeQuantity')
  - [Test_IsPositive_ReturnsFalse_WhenPassed_Zero()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsPositive_ReturnsFalse_WhenPassed_Zero 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.Test_IsPositive_ReturnsFalse_WhenPassed_Zero')
  - [Test_IsPositive_ReturnsTrue_WhenPassed_PositiveQuantity()](#M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsPositive_ReturnsTrue_WhenPassed_PositiveQuantity 'xyLOGIX.Core.Extensions.Tests.NumberExtensionsTests.Test_IsPositive_ReturnsTrue_WhenPassed_PositiveQuantity')
- [PreferTests](#T-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests')
  - [#ctor()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-#ctor 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.#ctor')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-#cctor 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.#cctor')
  - [BoolOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-BoolOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.BoolOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [BoolOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-BoolOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.BoolOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [ByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.ByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [ByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.ByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [CharOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-CharOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.CharOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [CharOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-CharOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.CharOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [DecimalOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DecimalOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.DecimalOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [DecimalOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DecimalOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.DecimalOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [DoubleOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DoubleOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.DoubleOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [DoubleOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DoubleOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.DoubleOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [FloatOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-FloatOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.FloatOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [FloatOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-FloatOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.FloatOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [IntOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.IntOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [IntOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.IntOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [IntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.IntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [IntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.IntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [LongOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-LongOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.LongOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [LongOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-LongOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.LongOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [NonZeroIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.NonZeroIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero')
  - [NonZeroIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.NonZeroIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero')
  - [NonZeroUIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroUIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.NonZeroUIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero')
  - [NonZeroUIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroUIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.NonZeroUIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero')
  - [ObjectOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ObjectOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.ObjectOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [ObjectOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ObjectOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.ObjectOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [SByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-SByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.SByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [SByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-SByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.SByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [ShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.ShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [ShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.ShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [StringOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-StringOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.StringOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [StringOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-StringOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.StringOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [UInt32OverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UInt32OverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.UInt32OverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [UInt32OverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UInt32OverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.UInt32OverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [UIntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UIntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.UIntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [UIntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UIntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.UIntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
  - [UShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.UShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull')
  - [UShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()](#M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests.UShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull')
- [Resources](#T-xyLOGIX-Core-Extensions-Tests-Properties-Resources 'xyLOGIX.Core.Extensions.Tests.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Tests-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Tests-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Tests.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests'></a>
## NumberExtensionsTests `type`

##### Namespace

xyLOGIX.Core.Extensions.Tests

##### Summary

Unit tests for the methods and properties of the
[NumberExtensions](#T-xyLOGIX-Core-Extensions-NumberExtensions 'xyLOGIX.Core.Extensions.NumberExtensions') class.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-TestIsStrictlyInRangeWithLowerBound'></a>
### TestIsStrictlyInRangeWithLowerBound() `method`

##### Summary

Asserts that `1` is NOT in the range `(1,100)`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-TestIsStrictlyInRangeWithMiddleValue'></a>
### TestIsStrictlyInRangeWithMiddleValue() `method`

##### Summary

Asserts that `10` is in the range `(1,100)`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-TestIsStrictlyInRangeWithUpperBound'></a>
### TestIsStrictlyInRangeWithUpperBound() `method`

##### Summary

Asserts that `100` is NOT in the range `(1,100)`, where the
rounded parentheses denote exclusive bounds.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsNegative_ReturnsFalse_WhenPassed_PositiveQuantity'></a>
### Test_IsNegative_ReturnsFalse_WhenPassed_PositiveQuantity() `method`

##### Summary

Asserts that the
[IsNegative](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNegative 'xyLOGIX.Core.Extensions.NumberExtensions.IsNegative') method
returns `false` when called ona  positive number.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsNegative_ReturnsFalse_WhenPassed_Zero'></a>
### Test_IsNegative_ReturnsFalse_WhenPassed_Zero() `method`

##### Summary

Asserts that the
[IsNegative](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNegative 'xyLOGIX.Core.Extensions.NumberExtensions.IsNegative') method
returns `false` when passed `0`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsNegative_ReturnsTrue_WhenPassed_NegativeQuantity'></a>
### Test_IsNegative_ReturnsTrue_WhenPassed_NegativeQuantity() `method`

##### Summary

Asserts that the
[IsNegative](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNegative 'xyLOGIX.Core.Extensions.NumberExtensions.IsNegative') method
returns `true` when passed `-1`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsPositive_ReturnsFalse_WhenPassed_NegativeQuantity'></a>
### Test_IsPositive_ReturnsFalse_WhenPassed_NegativeQuantity() `method`

##### Summary

Asserts that the
[IsPositive](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive 'xyLOGIX.Core.Extensions.NumberExtensions.IsPositive') method
returns `false` when passed `-1`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsPositive_ReturnsFalse_WhenPassed_Zero'></a>
### Test_IsPositive_ReturnsFalse_WhenPassed_Zero() `method`

##### Summary

Asserts that the
[IsPositive](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive 'xyLOGIX.Core.Extensions.NumberExtensions.IsPositive') method
returns `false` when passed `0`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-NumberExtensionsTests-Test_IsPositive_ReturnsTrue_WhenPassed_PositiveQuantity'></a>
### Test_IsPositive_ReturnsTrue_WhenPassed_PositiveQuantity() `method`

##### Summary

Asserts that the
[IsPositive](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive 'xyLOGIX.Core.Extensions.NumberExtensions.IsPositive') method
returns `true` when passed a positive number..

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests'></a>
## PreferTests `type`

##### Namespace

xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[Prefer](#T-xyLOGIX-Core-Extensions-Actions-Prefer 'xyLOGIX.Core.Extensions.Actions.Prefer') class.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new instance of
[PreferTests](#T-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[PreferTests](#T-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests 'xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-BoolOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### BoolOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [BoolOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-BoolOverNull-System-Nullable{System-Boolean},System-Boolean- 'xyLOGIX.Core.Extensions.Actions.Prefer.BoolOverNull(System.Nullable{System.Boolean},System.Boolean)') returns the nullable
value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-BoolOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### BoolOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [BoolOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-BoolOverNull-System-Nullable{System-Boolean},System-Boolean- 'xyLOGIX.Core.Extensions.Actions.Prefer.BoolOverNull(System.Nullable{System.Boolean},System.Boolean)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### ByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [ByteOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ByteOverNull-System-Nullable{System-Byte},System-Byte- 'xyLOGIX.Core.Extensions.Actions.Prefer.ByteOverNull(System.Nullable{System.Byte},System.Byte)') returns the nullable
value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### ByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [ByteOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ByteOverNull-System-Nullable{System-Byte},System-Byte- 'xyLOGIX.Core.Extensions.Actions.Prefer.ByteOverNull(System.Nullable{System.Byte},System.Byte)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-CharOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### CharOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [CharOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-CharOverNull-System-Nullable{System-Char},System-Char- 'xyLOGIX.Core.Extensions.Actions.Prefer.CharOverNull(System.Nullable{System.Char},System.Char)') returns the nullable
value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-CharOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### CharOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [CharOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-CharOverNull-System-Nullable{System-Char},System-Char- 'xyLOGIX.Core.Extensions.Actions.Prefer.CharOverNull(System.Nullable{System.Char},System.Char)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DecimalOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### DecimalOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [DecimalOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-DecimalOverNull-System-Nullable{System-Decimal},System-Decimal- 'xyLOGIX.Core.Extensions.Actions.Prefer.DecimalOverNull(System.Nullable{System.Decimal},System.Decimal)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DecimalOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### DecimalOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [DecimalOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-DecimalOverNull-System-Nullable{System-Decimal},System-Decimal- 'xyLOGIX.Core.Extensions.Actions.Prefer.DecimalOverNull(System.Nullable{System.Decimal},System.Decimal)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DoubleOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### DoubleOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [DoubleOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-DoubleOverNull-System-Nullable{System-Double},System-Double- 'xyLOGIX.Core.Extensions.Actions.Prefer.DoubleOverNull(System.Nullable{System.Double},System.Double)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-DoubleOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### DoubleOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [DoubleOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-DoubleOverNull-System-Nullable{System-Double},System-Double- 'xyLOGIX.Core.Extensions.Actions.Prefer.DoubleOverNull(System.Nullable{System.Double},System.Double)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-FloatOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### FloatOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [FloatOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-FloatOverNull-System-Nullable{System-Single},System-Single- 'xyLOGIX.Core.Extensions.Actions.Prefer.FloatOverNull(System.Nullable{System.Single},System.Single)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-FloatOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### FloatOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [FloatOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-FloatOverNull-System-Nullable{System-Single},System-Single- 'xyLOGIX.Core.Extensions.Actions.Prefer.FloatOverNull(System.Nullable{System.Single},System.Single)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### IntOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [IntOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-IntOverNull-System-Nullable{System-Int32},System-Int32- 'xyLOGIX.Core.Extensions.Actions.Prefer.IntOverNull(System.Nullable{System.Int32},System.Int32)') returns the nullable
value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### IntOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [IntOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-IntOverNull-System-Nullable{System-Int32},System-Int32- 'xyLOGIX.Core.Extensions.Actions.Prefer.IntOverNull(System.Nullable{System.Int32},System.Int32)') returns the preferred
value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### IntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [IntPtrOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-IntPtrOverNull-System-Nullable{System-IntPtr},System-IntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.IntPtrOverNull(System.Nullable{System.IntPtr},System.IntPtr)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-IntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### IntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [IntPtrOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-IntPtrOverNull-System-Nullable{System-IntPtr},System-IntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.IntPtrOverNull(System.Nullable{System.IntPtr},System.IntPtr)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-LongOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### LongOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [LongOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-LongOverNull-System-Nullable{System-Int64},System-Int64- 'xyLOGIX.Core.Extensions.Actions.Prefer.LongOverNull(System.Nullable{System.Int64},System.Int64)') returns the nullable
value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-LongOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### LongOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [LongOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-LongOverNull-System-Nullable{System-Int64},System-Int64- 'xyLOGIX.Core.Extensions.Actions.Prefer.LongOverNull(System.Nullable{System.Int64},System.Int64)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero'></a>
### NonZeroIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero() `method`

##### Summary

Tests that [NonZeroIntPtrOverZero](#M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroIntPtrOverZero-System-IntPtr,System-IntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.NonZeroIntPtrOverZero(System.IntPtr,System.IntPtr)') returns
the preferred value when the value to check is zero.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero'></a>
### NonZeroIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero() `method`

##### Summary

Tests that [NonZeroIntPtrOverZero](#M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroIntPtrOverZero-System-IntPtr,System-IntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.NonZeroIntPtrOverZero(System.IntPtr,System.IntPtr)') returns
the value to check when it is non-zero.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroUIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero'></a>
### NonZeroUIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero() `method`

##### Summary

Tests that [NonZeroUIntPtrOverZero](#M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroUIntPtrOverZero-System-UIntPtr,System-UIntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.NonZeroUIntPtrOverZero(System.UIntPtr,System.UIntPtr)')
returns the preferred value when the value to check is zero.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-NonZeroUIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero'></a>
### NonZeroUIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero() `method`

##### Summary

Tests that [NonZeroUIntPtrOverZero](#M-xyLOGIX-Core-Extensions-Actions-Prefer-NonZeroUIntPtrOverZero-System-UIntPtr,System-UIntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.NonZeroUIntPtrOverZero(System.UIntPtr,System.UIntPtr)')
returns the value to check when it is non-zero.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ObjectOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### ObjectOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [ObjectOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ObjectOverNull-System-Object,System-Object- 'xyLOGIX.Core.Extensions.Actions.Prefer.ObjectOverNull(System.Object,System.Object)') returns the
preferred value over the nullable value (since it is preferred, after all) when
it is both are not `null`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ObjectOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### ObjectOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [ObjectOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ObjectOverNull-System-Object,System-Object- 'xyLOGIX.Core.Extensions.Actions.Prefer.ObjectOverNull(System.Object,System.Object)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-SByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### SByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [SByteOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-SByteOverNull-System-Nullable{System-SByte},System-SByte- 'xyLOGIX.Core.Extensions.Actions.Prefer.SByteOverNull(System.Nullable{System.SByte},System.SByte)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-SByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### SByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [SByteOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-SByteOverNull-System-Nullable{System-SByte},System-SByte- 'xyLOGIX.Core.Extensions.Actions.Prefer.SByteOverNull(System.Nullable{System.SByte},System.SByte)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### ShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [ShortOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ShortOverNull-System-Nullable{System-Int16},System-Int16- 'xyLOGIX.Core.Extensions.Actions.Prefer.ShortOverNull(System.Nullable{System.Int16},System.Int16)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-ShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### ShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [ShortOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-ShortOverNull-System-Nullable{System-Int16},System-Int16- 'xyLOGIX.Core.Extensions.Actions.Prefer.ShortOverNull(System.Nullable{System.Int16},System.Int16)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-StringOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### StringOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [StringOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-StringOverNull-System-String,System-String- 'xyLOGIX.Core.Extensions.Actions.Prefer.StringOverNull(System.String,System.String)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-StringOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### StringOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [StringOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-StringOverNull-System-String,System-String- 'xyLOGIX.Core.Extensions.Actions.Prefer.StringOverNull(System.String,System.String)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UInt32OverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### UInt32OverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [UInt32OverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UInt32OverNull-System-Nullable{System-UInt32},System-UInt32- 'xyLOGIX.Core.Extensions.Actions.Prefer.UInt32OverNull(System.Nullable{System.UInt32},System.UInt32)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UInt32OverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### UInt32OverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [UInt32OverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UInt32OverNull-System-Nullable{System-UInt32},System-UInt32- 'xyLOGIX.Core.Extensions.Actions.Prefer.UInt32OverNull(System.Nullable{System.UInt32},System.UInt32)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UIntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### UIntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [UIntPtrOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UIntPtrOverNull-System-Nullable{System-UIntPtr},System-UIntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.UIntPtrOverNull(System.Nullable{System.UIntPtr},System.UIntPtr)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UIntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### UIntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [UIntPtrOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UIntPtrOverNull-System-Nullable{System-UIntPtr},System-UIntPtr- 'xyLOGIX.Core.Extensions.Actions.Prefer.UIntPtrOverNull(System.Nullable{System.UIntPtr},System.UIntPtr)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull'></a>
### UShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull() `method`

##### Summary

Tests that [UShortOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UShortOverNull-System-Nullable{System-UInt16},System-UInt16- 'xyLOGIX.Core.Extensions.Actions.Prefer.UShortOverNull(System.Nullable{System.UInt16},System.UInt16)') returns the
nullable value when it is not null.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-Tests-xyLOGIX-Core-Extensions-Tests-PreferTests-UShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull'></a>
### UShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull() `method`

##### Summary

Tests that [UShortOverNull](#M-xyLOGIX-Core-Extensions-Actions-Prefer-UShortOverNull-System-Nullable{System-UInt16},System-UInt16- 'xyLOGIX.Core.Extensions.Actions.Prefer.UShortOverNull(System.Nullable{System.UInt16},System.UInt16)') returns the
preferred value when the nullable value is null.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Core-Extensions-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Core.Extensions.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Core-Extensions-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Core-Extensions-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
