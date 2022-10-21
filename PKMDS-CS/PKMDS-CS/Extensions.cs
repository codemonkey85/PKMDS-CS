namespace PKMDS_CS;

public static partial class Extensions
{
    public static byte[] GetBytes(byte value) => BitConverter.GetBytes((short)value);
    public static byte[] GetBytes(uint value) => BitConverter.GetBytes(value);
}
