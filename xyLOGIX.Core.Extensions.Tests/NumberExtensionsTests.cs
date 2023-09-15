using NUnit.Framework;

namespace xyLOGIX.Core.Extensions.Tests
{
    /// <summary>
    /// Unit tests for the methods and properties of the
    /// <see cref="T:xyLOGIX.Core.Extensions.NumberExtensions" /> class.
    /// </summary>
    [TestFixture]
    public class NumberExtensionsTests
    {
        /// <summary>
        /// Asserts that the
        /// <see cref="M:xyLOGIX.Core.Extensions.NumberExtensions.IsNegative" /> method
        /// returns <see langword="false" /> when called ona  positive number.
        /// </summary>
        [Test]
        public void Test_IsNegative_ReturnsFalse_WhenPassed_PositiveQuantity()
            => Assert.IsFalse(10M.IsNegative());

        /// <summary>
        /// Asserts that the
        /// <see cref="M:xyLOGIX.Core.Extensions.NumberExtensions.IsNegative" /> method
        /// returns <see langword="false" /> when passed <c>0</c>.
        /// </summary>
        [Test]
        public void Test_IsNegative_ReturnsFalse_WhenPassed_Zero()
            => Assert.IsFalse(decimal.Zero.IsNegative());

        /// <summary>
        /// Asserts that the
        /// <see cref="M:xyLOGIX.Core.Extensions.NumberExtensions.IsNegative" /> method
        /// returns <see langword="true" /> when passed <c>-1</c>.
        /// </summary>
        [Test]
        public void Test_IsNegative_ReturnsTrue_WhenPassed_NegativeQuantity()
            => Assert.IsTrue(decimal.MinusOne.IsNegative());

        /// <summary>
        /// Asserts that the
        /// <see cref="M:xyLOGIX.Core.Extensions.NumberExtensions.IsPositive" /> method
        /// returns <see langword="false" /> when passed <c>-1</c>.
        /// </summary>
        [Test]
        public void Test_IsPositive_ReturnsFalse_WhenPassed_NegativeQuantity()
            => Assert.IsFalse(decimal.MinusOne.IsPositive());

        /// <summary>
        /// Asserts that the
        /// <see cref="M:xyLOGIX.Core.Extensions.NumberExtensions.IsPositive" /> method
        /// returns <see langword="false" /> when passed <c>0</c>.
        /// </summary>
        [Test]
        public void Test_IsPositive_ReturnsFalse_WhenPassed_Zero()
            => Assert.IsFalse(decimal.Zero.IsPositive());

        /// <summary>
        /// Asserts that the
        /// <see cref="M:xyLOGIX.Core.Extensions.NumberExtensions.IsPositive" /> method
        /// returns <see langword="true" /> when passed a positive number..
        /// </summary>
        [Test]
        public void Test_IsPositive_ReturnsTrue_WhenPassed_PositiveQuantity()
            => Assert.IsTrue(10M.IsPositive());

        /// <summary> Asserts that <c>1</c> is NOT in the range <c>(1,100)</c>. </summary>
        [Test]
        public void TestIsStrictlyInRangeWithLowerBound()
            => Assert.IsFalse(1M.IsStrictlyInRange(1M, 100M));

        /// <summary> Asserts that <c>10</c> is in the range <c>(1,100)</c>. </summary>
        [Test]
        public void TestIsStrictlyInRangeWithMiddleValue()
            => Assert.IsTrue(10M.IsStrictlyInRange(1M, 100M));

        /// <summary>
        /// Asserts that <c>100</c> is NOT in the range <c>(1,100)</c>, where the
        /// rounded parentheses denote exclusive bounds.
        /// </summary>
        [Test]
        public void TestIsStrictlyInRangeWithUpperBound()
            => Assert.IsFalse(100M.IsStrictlyInRange(1M, 100M));
    }
}