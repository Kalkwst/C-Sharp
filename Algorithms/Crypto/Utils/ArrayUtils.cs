using System;

namespace Algorithms.Crypto.Utils;

public static class ArrayUtils
{
    /// <summary>
    /// Creates a copy of the specified boolean array. If the input array is null, null is returned.
    /// </summary>
    /// <param name="data">The boolean array to clone.</param>
    /// <returns>A cloned copy of the boolean array, or null if the input is null.</returns>
    public static bool[]? Clone(bool[]? data)
    {
        return data == null ? null : (bool[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified byte array. If the input array is null, null is returned.
    /// </summary>
    /// <param name="data">The byte array to clone.</param>
    /// <returns>A cloned copy of the byte array, or null if the input is null.</returns>
    public static byte[]? Clone(byte[]? data)
    {
        return data == null ? null : (byte[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified short array. If the input array is null, null is returned.
    /// </summary>
    /// <param name="data">The short array to clone.</param>
    /// <returns>A cloned copy of the short array, or null if the input is null.</returns>
    public static short[]? Clone(short[]? data)
    {
        return data == null ? null : (short[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified unsigned short array. If the input array is null, null is returned.
    /// This method is not CLS-compliant because it uses the <see cref="ushort"/> data type.
    /// </summary>
    /// <param name="data">The unsigned short array to clone.</param>
    /// <returns>A cloned copy of the unsigned short array, or null if the input is null.</returns>
    public static ushort[]? Clone(ushort[]? data)
    {
        return data == null ? null : (ushort[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified integer array. If the input array is null, null is returned.
    /// </summary>
    /// <param name="data">The integer array to clone.</param>
    /// <returns>A cloned copy of the integer array, or null if the input is null.</returns>
    public static int[]? Clone(int[]? data)
    {
        return data == null ? null : (int[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified unsigned integer array. If the input array is null, null is returned.
    /// This method is not CLS-compliant because it uses the <see cref="uint"/> data type.
    /// </summary>
    /// <param name="data">The unsigned integer array to clone.</param>
    /// <returns>A cloned copy of the unsigned integer array, or null if the input is null.</returns>
    public static uint[]? Clone(uint[]? data)
    {
        return data == null ? null : (uint[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified long array. If the input array is null, null is returned.
    /// </summary>
    /// <param name="data">The long array to clone.</param>
    /// <returns>A cloned copy of the long array, or null if the input is null.</returns>
    public static long[]? Clone(long[]? data)
    {
        return data == null ? null : (long[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified unsigned long array. If the input array is null, null is returned.
    /// This method is not CLS-compliant because it uses the <see cref="ulong"/> data type.
    /// </summary>
    /// <param name="data">The unsigned long array to clone.</param>
    /// <returns>A cloned copy of the unsigned long array, or null if the input is null.</returns>
    public static ulong[]? Clone(ulong[]? data)
    {
        return data == null ? null : (ulong[])data.Clone();
    }

    /// <summary>
    /// Creates a copy of the specified byte array into an existing array.
    /// If the existing array is null or does not match the length of the input array, a new copy is created.
    /// </summary>
    /// <param name="data">The byte array to clone.</param>
    /// <param name="existing">The array to copy the data into.</param>
    /// <returns>The existing array if the lengths match, or a new copy of the input array.</returns>
    public static byte[]? Clone(byte[]? data, byte[]? existing)
    {
        if (data == null)
        {
            return null;
        }

        if (existing == null || existing.Length != data.Length)
        {
            return Clone(data);
        }

        Array.Copy(data, 0, existing, 0, existing.Length);
        return existing;
    }

    /// <summary>
    /// Creates a copy of the specified unsigned long array into an existing array.
    /// If the existing array is null or does not match the length of the input array, a new copy is created.
    /// This method is not CLS-compliant because it uses the <see cref="ulong"/> data type.
    /// </summary>
    /// <param name="data">The unsigned long array to clone.</param>
    /// <param name="existing">The array to copy the data into.</param>
    /// <returns>The existing array if the lengths match, or a new copy of the input array.</returns>
    public static ulong[]? Clone(ulong[]? data, ulong[]? existing)
    {
        if (data == null)
        {
            return null;
        }

        if (existing == null || existing.Length != data.Length)
        {
            return Clone(data);
        }

        Array.Copy(data, 0, existing, 0, existing.Length);
        return existing;
    }
}
