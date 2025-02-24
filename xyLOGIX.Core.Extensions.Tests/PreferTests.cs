using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Extensions.Actions;

namespace xyLOGIX.Core.Extensions.Tests
{
    namespace xyLOGIX.Core.Extensions.Tests
    {
        /// <summary>
        /// Provides unit tests for the methods, properties, and events of the
        /// <see cref="T:xyLOGIX.Core.Extensions.Actions.Prefer" /> class.
        /// </summary>
        [TestFixture]
        public class PreferTests
        {
            /// <summary>
            /// Initializes static data or performs actions that need to be performed once only
            /// for the
            /// <see
            ///     cref="T:xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests" />
            /// class.
            /// </summary>
            /// <remarks>
            /// This constructor is called automatically prior to the first instance being
            /// created or before any static members are referenced.
            /// </remarks>
            [Log(AttributeExclude = true)]
            static PreferTests() { }

            /// <summary>
            /// Creates a new instance of
            /// <see
            ///     cref="T:xyLOGIX.Core.Extensions.Tests.xyLOGIX.Core.Extensions.Tests.PreferTests" />
            /// and returns a reference to it.
            /// </summary>
            [Log(AttributeExclude = true)]
            public PreferTests() { }

            /// <summary>
            /// Tests that <see cref="Prefer.BoolOverNull(bool?, bool)" /> returns the nullable
            /// value when it is not null.
            /// </summary>
            [Test]
            public void
                BoolOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                bool? nullableValue = false;
                const bool preferredValue = true;

                var result = Prefer.BoolOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.BoolOverNull(bool?, bool)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                BoolOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                bool? nullableValue = null;
                const bool preferredValue = true;

                var result = Prefer.BoolOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.ByteOverNull(byte?, byte)" /> returns the nullable
            /// value when it is not null.
            /// </summary>
            [Test]
            public void
                ByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                byte? nullableValue = 5;
                const byte preferredValue = 10;

                var result = Prefer.ByteOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.ByteOverNull(byte?, byte)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                ByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                byte? nullableValue = null;
                const byte preferredValue = 10;

                var result = Prefer.ByteOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.CharOverNull(char?, char)" /> returns the nullable
            /// value when it is not null.
            /// </summary>
            [Test]
            public void
                CharOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                char? nullableValue = 'B';
                const char preferredValue = 'A';

                var result = Prefer.CharOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.CharOverNull(char?, char)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                CharOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                char? nullableValue = null;
                const char preferredValue = 'A';

                var result = Prefer.CharOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.DecimalOverNull(decimal?, decimal)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                DecimalOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                decimal? nullableValue = 5.5M;
                const decimal preferredValue = 10.5M;

                var result = Prefer.DecimalOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.DecimalOverNull(decimal?, decimal)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                DecimalOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                decimal? nullableValue = null;
                const decimal preferredValue = 10.5M;

                var result = Prefer.DecimalOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.DoubleOverNull(double?, double)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                DoubleOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                double? nullableValue = 5.5D;
                const double preferredValue = 10.5D;

                var result = Prefer.DoubleOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.DoubleOverNull(double?, double)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                DoubleOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                double? nullableValue = null;
                const double preferredValue = 10.5D;

                var result = Prefer.DoubleOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.FloatOverNull(float?, float)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                FloatOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                float? nullableValue = 5.5F;
                const float preferredValue = 10.5F;

                var result = Prefer.FloatOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.FloatOverNull(float?, float)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                FloatOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                float? nullableValue = null;
                const float preferredValue = 10.5F;

                var result = Prefer.FloatOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.IntOverNull(int?, int)" /> returns the nullable
            /// value when it is not null.
            /// </summary>
            [Test]
            public void
                IntOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                int? nullableValue = 5;
                const int preferredValue = 10;

                var result = Prefer.IntOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.IntOverNull(int?, int)" /> returns the preferred
            /// value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                IntOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                int? nullableValue = null;
                const int preferredValue = 10;

                var result = Prefer.IntOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.IntPtrOverNull(IntPtr?, IntPtr)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                IntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                IntPtr? nullableValue = new IntPtr(5);
                var preferredValue = new IntPtr(10);

                var result = Prefer.IntPtrOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.IntPtrOverNull(IntPtr?, IntPtr)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                IntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                IntPtr? nullableValue = null;
                var preferredValue = new IntPtr(10);

                var result = Prefer.IntPtrOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.LongOverNull(long?, long)" /> returns the nullable
            /// value when it is not null.
            /// </summary>
            [Test]
            public void
                LongOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                long? nullableValue = 5L;
                var preferredValue = 10L;

                var result = Prefer.LongOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.LongOverNull(long?, long)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                LongOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                long? nullableValue = null;
                const long preferredValue = 10L;

                var result = Prefer.LongOverNull(nullableValue, preferredValue);

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.NonZeroIntPtrOverZero(IntPtr, IntPtr)" /> returns
            /// the preferred value when the value to check is zero.
            /// </summary>
            [Test]
            public void
                NonZeroIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero()
            {
                var valueToCheck = IntPtr.Zero;
                var preferredValue = new IntPtr(10);

                var result = Prefer.NonZeroIntPtrOverZero(
                    valueToCheck, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.NonZeroIntPtrOverZero(IntPtr, IntPtr)" /> returns
            /// the value to check when it is non-zero.
            /// </summary>
            [Test]
            public void
                NonZeroIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero()
            {
                var valueToCheck = new IntPtr(5);
                var preferredValue = new IntPtr(10);

                var result = Prefer.NonZeroIntPtrOverZero(
                    valueToCheck, preferredValue
                );

                Assert.That(result, Is.EqualTo(valueToCheck));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.NonZeroUIntPtrOverZero(UIntPtr, UIntPtr)" />
            /// returns the preferred value when the value to check is zero.
            /// </summary>
            [Test]
            public void
                NonZeroUIntPtrOverZero_ReturnsPreferredValue_WhenValueToCheckIsZero()
            {
                var valueToCheck = UIntPtr.Zero;
                var preferredValue = new UIntPtr(10);

                var result = Prefer.NonZeroUIntPtrOverZero(
                    valueToCheck, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.NonZeroUIntPtrOverZero(UIntPtr, UIntPtr)" />
            /// returns the value to check when it is non-zero.
            /// </summary>
            [Test]
            public void
                NonZeroUIntPtrOverZero_ReturnsValueToCheck_WhenValueToCheckIsNonZero()
            {
                var valueToCheck = new UIntPtr(5);
                var preferredValue = new UIntPtr(10);

                var result = Prefer.NonZeroUIntPtrOverZero(
                    valueToCheck, preferredValue
                );

                Assert.That(result, Is.EqualTo(valueToCheck));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.ObjectOverNull(object, object)" /> returns the
            /// preferred value over the nullable value (since it is preferred, after all) when
            /// it is both are not <see langword="null" />.
            /// </summary>
            [Test]
            public void
                ObjectOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                var nullableValue = new object();
                var preferredValue = new object();

                var result = Prefer.ObjectOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.ObjectOverNull(object, object)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                ObjectOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                object nullableValue = null;
                var preferredValue = new object();

                var result = Prefer.ObjectOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.SByteOverNull(sbyte?, sbyte)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                SByteOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                sbyte? nullableValue = 5;
                const sbyte preferredValue = 10;

                var result = Prefer.SByteOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.SByteOverNull(sbyte?, sbyte)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                SByteOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                sbyte? nullableValue = null;
                const sbyte preferredValue = 10;

                var result = Prefer.SByteOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.ShortOverNull(short?, short)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                ShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                short? nullableValue = 5;
                const short preferredValue = 10;

                var result = Prefer.ShortOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.ShortOverNull(short?, short)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                ShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                short? nullableValue = null;
                const short preferredValue = 10;

                var result = Prefer.ShortOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.StringOverBlank(string, string)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                StringOverBlank_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                const string nullableValue = "nullable";
                const string preferredValue = "preferred";

                var result = Prefer.StringOverBlank(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.StringOverBlank(string, string)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                StringOverBlank_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                string nullableValue = null;
                const string preferredValue = "preferred";

                var result = Prefer.StringOverBlank(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.UInt32OverNull(uint?, uint)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                UInt32OverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                uint? nullableValue = 5;
                const uint preferredValue = 10;

                var result = Prefer.UInt32OverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.UInt32OverNull(uint?, uint)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                UInt32OverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                uint? nullableValue = null;
                const uint preferredValue = 10;

                var result = Prefer.UInt32OverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.UIntPtrOverNull(UIntPtr?, UIntPtr)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                UIntPtrOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                UIntPtr? nullableValue = new UIntPtr(5);
                var preferredValue = new UIntPtr(10);

                var result = Prefer.UIntPtrOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.UIntPtrOverNull(UIntPtr?, UIntPtr)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                UIntPtrOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                UIntPtr? nullableValue = null;
                var preferredValue = new UIntPtr(10);

                var result = Prefer.UIntPtrOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.UShortOverNull(ushort?, ushort)" /> returns the
            /// nullable value when it is not null.
            /// </summary>
            [Test]
            public void
                UShortOverNull_ReturnsNullableValue_WhenNullableValueIsNotNull()
            {
                ushort? nullableValue = 5;
                const ushort preferredValue = 10;

                var result = Prefer.UShortOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(nullableValue));
            }

            /// <summary>
            /// Tests that <see cref="Prefer.UShortOverNull(ushort?, ushort)" /> returns the
            /// preferred value when the nullable value is null.
            /// </summary>
            [Test]
            public void
                UShortOverNull_ReturnsPreferredValue_WhenNullableValueIsNull()
            {
                ushort? nullableValue = null;
                const ushort preferredValue = 10;

                var result = Prefer.UShortOverNull(
                    nullableValue, preferredValue
                );

                Assert.That(result, Is.EqualTo(preferredValue));
            }
        }
    }
}