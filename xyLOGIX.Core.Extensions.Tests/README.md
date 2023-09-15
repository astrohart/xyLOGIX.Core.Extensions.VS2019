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

Asserts that `100` is NOT in the range `(1,100)`, where the rounded
parentheses denote exclusive bounds.

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
