using NUnit.Framework;
using FluentAssertions;
using System;
using Algorithms.Crypto.Utils;

namespace Algorithms.Tests.Crypto.Utils
{
    [TestFixture]
    public class ByteEncodingUtilsTests
    {
        [Test]
        public void BigEndianToUint64_ByteArray_ShouldConvertCorrectly()
        {
            // Arrange
            byte[] input = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
            var expected = 0x0123456789ABCDEFUL;

            // Act
            var result = ByteEncodingUtils.BigEndianToUint64(input, 0);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void BigEndianToUint64_ByteArray_WithOffset_ShouldConvertCorrectly()
        {
            // Arrange
            byte[] input = { 0x00, 0x00, 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
            var expected = 0x0123456789ABCDEFUL;

            // Act
            var result = ByteEncodingUtils.BigEndianToUint64(input, 2);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void BigEndianToUint64_Span_ShouldConvertCorrectly()
        {
            // Arrange
            Span<byte> input = stackalloc byte[] { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
            var expected = 0x0123456789ABCDEFUL;

            // Act
            var result = ByteEncodingUtils.BigEndianToUint64(input);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void UInt64ToBigEndian_ShouldWriteCorrectly()
        {
            // Arrange
            var value = 0x0123456789ABCDEFUL;
            Span<byte> output = stackalloc byte[8];
            byte[] expected = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };

            // Act
            ByteEncodingUtils.UInt64ToBigEndian(value, output);

            // Assert
            output.ToArray().Should().Equal(expected);
        }

        [Test]
        public void BigEndianToUint64_InvalidOffset_ShouldThrowException()
        {
            // Arrange
            byte[] input = { 0x01, 0x23 };

            // Act
            Action act = () => ByteEncodingUtils.BigEndianToUint64(input, 1);

            // Assert
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void LittleEndianToUint64_ShouldConvertBytesCorrectly()
        {
            // Arrange
            byte[] byteStream = { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; // Little-endian representation of 1
            const int offset = 0;

            // Act
            var result = ByteEncodingUtils.LittleEndianToUint64(byteStream, offset);

            // Assert
            result.Should().Be(1);
        }

        [Test]
        public void LittleEndianToUint64_ShouldThrowOutOfRangeExceptionForInvalidOffset()
        {
            // Arrange
            byte[] byteStream = { 0x01, 0x00, 0x00 }; // Not enough bytes
            const int offset = 1;

            // Act
            Action act = () => ByteEncodingUtils.LittleEndianToUint64(byteStream, offset);

            // Assert
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void LittleEndianToUint64_ShouldConvertCorrectlyAtOffset()
        {
            // Arrange
            byte[] byteStream = { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 }; // Little-endian 1 at offset 4
            const int offset = 4;

            // Act
            var result = ByteEncodingUtils.LittleEndianToUint64(byteStream, offset);

            // Assert
            result.Should().Be(1);
        }
    }
}
