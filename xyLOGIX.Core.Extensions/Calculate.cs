using System;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static methods to perform various mathematical calculations, such as
    /// percentage change.
    /// </summary>
    public static class Calculate
    {
        /// <summary>
        /// Returns the delta, or where you <paramref name="end" /> up, minus
        /// where you <paramref name="start" />.
        /// <para />
        /// If the values are retrieved from time-series data, then <paramref name="end" />
        /// is the value from the time closest to now, and <paramref name="start" /> is
        /// from back in the past.
        /// </summary>
        /// <param name="end">(Required.) Current, or more recent, value.</param>
        /// <param name="start">(Required.) Starting value.</param>
        /// <returns>
        /// Zero if <paramref name="end" /> and <paramref name="start" /> are
        /// identically equal to each other; otherwise, the difference between
        /// <paramref name="end" /> and <paramref name="start" />.
        /// </returns>
        public static decimal DeltaBetween(decimal end, decimal start)
        {
            var result = decimal.Zero;

            try
            {
                if (end == start) return result; // obviously

                result = end - start;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Given an <paramref name="end" /> and a <paramref name="start" />
        /// value, where <paramref name="end" /> is further back in the past than
        /// <paramref name="start" />, computes the fractional average rate of change
        /// between the two.
        /// </summary>
        /// <param name="end">(Required.) Current, or more recent, value.</param>
        /// <param name="start">(Required.) Starting value.</param>
        /// <remarks>
        /// The result of calling this method, in the event that
        /// <paramref name="start" /> is set equal to zero, is defined to be zero.
        /// </remarks>
        /// <returns>
        /// Average fractional rate of the change from <paramref name="start" />
        /// to <paramref name="end" />.
        /// </returns>
        public static decimal FractionalChangeBetween(
            decimal end,
            decimal start
        )
        {
            var result = decimal.Zero;

            try
            {
                if (end == start) return result; // obviously
                if (start.IsZero())
                    return
                        result; // can't divide by zero; define result to be zero

                // formula for fractional change
                result = (end - start) / start;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Calculates the percentage change between an <paramref name="initialValue" />
        /// and a <paramref name="finalValue" />.
        /// </summary>
        /// <param name="initialValue">The initial value.  Must not be equal to zero.</param>
        /// <param name="finalValue">The final value.</param>
        /// <returns>
        /// The percentage change between the <paramref name="initialValue" /> and
        /// <paramref name="finalValue" />.
        /// </returns>
        /// <exception cref="DivideByZeroException">
        /// Thrown when the specified
        /// <paramref name="initialValue" /> is equal to zero.
        /// </exception>
        public static double PercentageChangeOf(
            long initialValue,
            long finalValue
        )
        {
            if (0L.Equals(initialValue)) // cannot divide by zero.
                throw new DivideByZeroException(
                    "Initial value cannot be zero."
                );

            double change = finalValue - initialValue;
            var percentageChange =
                change / initialValue * 100D; // Cast to double for precision

            return percentageChange;
        }

        /// <summary>
        /// Calculates the percentage change between an <paramref name="initialValue" />
        /// and a <paramref name="finalValue" />.
        /// </summary>
        /// <param name="initialValue">The initial value.  Must not be equal to zero.</param>
        /// <param name="finalValue">The final value.</param>
        /// <returns>
        /// The percentage change between the <paramref name="initialValue" /> and
        /// <paramref name="finalValue" />.
        /// </returns>
        /// <exception cref="DivideByZeroException">
        /// Thrown when the specified
        /// <paramref name="initialValue" /> is equal to zero.
        /// </exception>
        public static double PercentageChangeOf(
            int initialValue,
            int finalValue
        )
        {
            if (0.Equals(initialValue)) // cannot divide by zero.
                throw new DivideByZeroException(
                    "Initial value cannot be zero."
                );

            double change = finalValue - initialValue;
            var percentageChange =
                change / initialValue * 100D; // Cast to double for precision

            return percentageChange;
        }

        /// <summary>
        /// Calculates the percentage change between an <paramref name="initialValue" />
        /// and a <paramref name="finalValue" />.
        /// </summary>
        /// <param name="initialValue">The initial value.  Must not be equal to zero.</param>
        /// <param name="finalValue">The final value.</param>
        /// <returns>
        /// The percentage change between the <paramref name="initialValue" /> and
        /// <paramref name="finalValue" />.
        /// </returns>
        /// <exception cref="DivideByZeroException">
        /// Thrown when the specified
        /// <paramref name="initialValue" /> is equal to zero.
        /// </exception>
        public static double PercentageChangeOf(
            double initialValue,
            double finalValue
        )
        {
            if (0D.Equals(initialValue)) // cannot divide by zero.
                throw new DivideByZeroException(
                    "Initial value cannot be zero."
                );

            var change = finalValue - initialValue;
            var percentageChange =
                change / initialValue * 100D; // Cast to double for precision

            return percentageChange;
        }

        /// <summary>
        /// Calculates the percentage change between an <paramref name="initialValue" />
        /// and a <paramref name="finalValue" />.
        /// </summary>
        /// <param name="initialValue">The initial value.  Must not be equal to zero.</param>
        /// <param name="finalValue">The final value.</param>
        /// <returns>
        /// The percentage change between the <paramref name="initialValue" /> and
        /// <paramref name="finalValue" />.
        /// </returns>
        /// <exception cref="DivideByZeroException">
        /// Thrown when the specified
        /// <paramref name="initialValue" /> is equal to zero.
        /// </exception>
        public static decimal PercentageChangeOf(
            decimal initialValue,
            decimal finalValue
        )
        {
            if (0M.Equals(initialValue)) // cannot divide by zero.
                throw new DivideByZeroException(
                    "Initial value cannot be zero."
                );

            var change = finalValue - initialValue;
            var percentageChange =
                change / initialValue * 100M; // Cast to decimal for precision

            return percentageChange;
        }

        /// <summary>
        /// Calculates the percentage difference between two given numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The percentage difference between the two numbers.</returns>
        /// <remarks>
        /// The formula used to calculate the percentage difference is:
        /// (|a - b| / ((a + b) / 2)) * 100
        /// </remarks>
        public static double PercentageDifference(double a, double b)
        {
            var absoluteDifference = Math.Abs(a - b);
            var average = (a + b) / 2.0;
            if (0D.Equals(average)) return 0D;
            var relativeDifference = absoluteDifference / average;
            return relativeDifference * 100;
        }

        /// <summary>
        /// Calculates the percentage difference between two given numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The percentage difference between the two numbers.</returns>
        /// <remarks>
        /// The formula used to calculate the percentage difference is:
        /// (|a - b| / ((a + b) / 2)) * 100
        /// </remarks>
        public static decimal PercentageDifference(decimal a, decimal b)
        {
            var absoluteDifference = Math.Abs(a - b);
            var average = (a + b) / 2.0M;
            if (decimal.Zero.Equals(average)) return decimal.Zero;
            var relativeDifference = absoluteDifference / average;
            return relativeDifference * 100M;
        }

        /// <summary>
        /// Calculates the percentage difference between two given numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The percentage difference between the two numbers.</returns>
        /// <remarks>
        /// The formula used to calculate the percentage difference is:
        /// (|a - b| / ((a + b) / 2)) * 100
        /// </remarks>
        public static double PercentageDifference(int a, int b)
        {
            var absoluteDifference = Math.Abs(a - b);
            var average = (a + b) / 2.0D;
            if (0D.Equals(average)) return 0D;
            var relativeDifference = absoluteDifference / average;
            return relativeDifference * 100D;
        }

        /// <summary>
        /// Computes the n-ary product of all the specified
        /// <paramref name="factors" />.
        /// <para />
        /// If any one factor is zero, then this method does not even bother carrying out
        /// the multiplication; it simply returns zero.
        /// </summary>
        /// <param name="factors">
        /// (Required.) One or more <see langword="decimal" />
        /// values that will serve as the factors to be multiplied.
        /// </param>
        /// <returns>
        /// The n-ary product of the specified <paramref name="factors" />, or
        /// zero if any one factor is zero.
        /// <para />
        /// If no values are passed, then this method is defined to return zero also.
        /// </returns>
        public static decimal ProductOf(params decimal[] factors)
        {
            var result = decimal.Zero;

            try
            {
                /*
                 * Remember, when we multiply, if any one factor is zero, then
                 * the entire product is zero.
                 *
                 * If this is so, then let's save some processor cycles (multiplication
                 * is expensive) and simply return zero.
                 */
                if (factors == null || !factors.Any()) return result;
                if (factors.Any(factor => factor.Equals(decimal.Zero)))
                    return result;

                result = factors.Aggregate(
                    decimal.One,
                    (runningProduct, currentFactor)
                        => runningProduct * currentFactor
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Evaluates the quotient (i.e., the result when you divide two numbers)
        /// of the specified <paramref name="numerator" /> and
        /// <paramref name="denominator" />, provided the <paramref name="denominator" />
        /// is not equal to zero and neither is the <paramref name="numerator" />.
        /// </summary>
        /// <param name="numerator">
        /// (Required.) A <see cref="T:System.Decimal" /> value to
        /// serve as the divisor.
        /// </param>
        /// <param name="denominator">
        /// (Required.) A <see cref="T:System.Decimal" /> value
        /// to serve as the dividend.
        /// <para />
        /// Must not be identically equal to zero.
        /// </param>
        /// <remarks>
        /// Zero is returned in the event that either the
        /// <paramref name="numerator" /> or the <paramref name="denominator" /> are
        /// identically zero.
        /// <para />
        /// Zero is also returned in the event an exception is raised by the division
        /// operator.
        /// </remarks>
        /// <returns>
        /// The quotient of the <paramref name="numerator" /> divided by the
        /// <paramref name="denominator" />.
        /// </returns>
        public static decimal QuotientOf(decimal numerator, decimal denominator)
        {
            var result = decimal.Zero;

            try
            {
                if (numerator.IsZero()) return result;
                if (denominator.IsZero()) return result;

                result = numerator / denominator;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Computes the zero floor.  Meaning, if the specified
        /// <paramref name="value" /> is negative, then this method returns zero.
        /// <para />
        /// If the specified <paramref name="value" /> is zero or greater, then this method
        /// is the identity.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <returns>
        /// Zero if the specified <paramref name="value" /> is negative;
        /// otherwise, if the specified <paramref name="value" /> is zero or greater, then
        /// the method is the identity map.
        /// </returns>
        public static int ZeroFloorOf(int value)
            => value < 0 ? 0 : value;

        /// <summary>
        /// Computes the zero floor.  Meaning, if the specified
        /// <paramref name="value" /> is negative, then this method returns zero.
        /// <para />
        /// If the specified <paramref name="value" /> is zero or greater, then this method
        /// is the identity.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <returns>
        /// Zero if the specified <paramref name="value" /> is negative;
        /// otherwise, if the specified <paramref name="value" /> is zero or greater, then
        /// the method is the identity map.
        /// </returns>
        public static long ZeroFloorOf(long value)
            => value < 0L ? 0L : value;

        /// <summary>
        /// Computes the zero floor.  Meaning, if the specified
        /// <paramref name="value" /> is negative, then this method returns zero.
        /// <para />
        /// If the specified <paramref name="value" /> is zero or greater, then this method
        /// is the identity.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <returns>
        /// Zero if the specified <paramref name="value" /> is negative;
        /// otherwise, if the specified <paramref name="value" /> is zero or greater, then
        /// the method is the identity map.
        /// </returns>
        public static decimal ZeroFloorOf(decimal value)
            => value < 0M ? 0M : value;

        /// <summary>
        /// Computes the zero floor.  Meaning, if the specified
        /// <paramref name="value" /> is negative, then this method returns zero.
        /// <para />
        /// If the specified <paramref name="value" /> is zero or greater, then this method
        /// is the identity.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <returns>
        /// Zero if the specified <paramref name="value" /> is negative;
        /// otherwise, if the specified <paramref name="value" /> is zero or greater, then
        /// the method is the identity map.
        /// </returns>
        public static double ZeroFloorOf(double value)
            => value < 0D ? 0D : value;
    }
}