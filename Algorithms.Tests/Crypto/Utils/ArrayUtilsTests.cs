using Algorithms.Crypto.Utils;
using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.Tests.Crypto.Utils;

[TestFixture]
public class ArrayUtilsTests
{
    [Test]
    public void Clone_BoolArray_ShouldReturnExactClone()
    {
        bool[] original = [true, false, true];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_BoolArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((bool[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_ByteArray_ShouldReturnExactClone()
    {
        byte[] original = [1, 2, 3];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_ByteArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((byte[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_ShortArray_ShouldReturnExactClone()
    {
        short[] original = [1, 2, 3];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_ShortArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((short[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_UShortArray_ShouldReturnExactClone()
    {
        ushort[] original = [1, 2, 3];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_UShortArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((ushort[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_IntArray_ShouldReturnExactClone()
    {
        int[] original = [1, 2, 3];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_IntArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((int[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_UIntArray_ShouldReturnExactClone()
    {
        uint[] original = [1, 2, 3];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_UIntArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((uint[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_LongArray_ShouldReturnExactClone()
    {
        long[] original = [1, 2, 3];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_LongArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((long[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_ULongArray_ShouldReturnExactClone()
    {
        ulong[] original = [1, 2, 3];
        var clone = ArrayUtils.Clone(original);

        clone.Should().NotBeNull();
        clone.Should().Equal(original);
        clone.Should().NotBeSameAs(original);
    }

    [Test]
    public void Clone_ULongArray_Null_ShouldReturnNull()
    {
        var clone = ArrayUtils.Clone((ulong[]?)null);
        clone.Should().BeNull();
    }

    [Test]
    public void Clone_ByteArray_WithExistingArray_ShouldReuseExistingArray()
    {
        byte[] original = [1, 2, 3];
        var existing = new byte[3];
        var clone = ArrayUtils.Clone(original, existing);

        clone.Should().BeSameAs(existing);
        clone.Should().Equal(original);
    }

    [Test]
    public void Clone_ByteArray_WithExistingArray_ShouldReturnNewCloneWhenLengthMismatch()
    {
        byte[] original = [1, 2, 3];
        var existing = new byte[2]; // Mismatched length
        var clone = ArrayUtils.Clone(original, existing);

        clone.Should().NotBeSameAs(existing);
        clone.Should().Equal(original);
    }

    [Test]
    public void Clone_ULongArray_WithExistingArray_ShouldReuseExistingArray()
    {
        ulong[] original = [1, 2, 3];
        var existing = new ulong[3];
        var clone = ArrayUtils.Clone(original, existing);

        clone.Should().BeSameAs(existing);
        clone.Should().Equal(original);
    }

    [Test]
    public void Clone_ULongArray_WithExistingArray_ShouldReturnNewCloneWhenLengthMismatch()
    {
        ulong[] original = [1, 2, 3];
        var existing = new ulong[2]; // Mismatched length
        var clone = ArrayUtils.Clone(original, existing);

        clone.Should().NotBeSameAs(existing);
        clone.Should().Equal(original);
    }
}
