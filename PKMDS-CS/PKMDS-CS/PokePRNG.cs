namespace PKMDS_CS;

internal static class PokePRNG
{
    internal static uint LCRNG(uint seed)
    {
        const uint a = 0x41C64E6D;
        const uint c = 0x00006073;

        seed = (seed * a + c) & 0xFFFFFFFF;
        return seed;
    }

    internal static uint LCRNG(ref uint seed)
    {
        const uint a = 0x41C64E6D;
        const uint c = 0x00006073;

        seed = (seed * a + c) & 0xFFFFFFFF;
        return seed;
    }

    internal static void shuffleArray(ref byte[] pkx)
    {
        var pv = BitConverter.ToUInt32(pkx, 0);
        var sv = ((pv & 0x3E000) >> 0xD) % 24;
        var ekx = new byte[232];
        Array.Copy(pkx, ekx, 8);
        byte[] aloc = { 0, 0, 0, 0, 0, 0, 1, 1, 2, 3, 2, 3, 1, 1, 2, 3, 2, 3, 1, 1, 2, 3, 2, 3 };
        byte[] bloc = { 1, 1, 2, 3, 2, 3, 0, 0, 0, 0, 0, 0, 2, 3, 1, 1, 3, 2, 2, 3, 1, 1, 3, 2 };
        byte[] cloc = { 2, 3, 1, 1, 3, 2, 2, 3, 1, 1, 3, 2, 0, 0, 0, 0, 0, 0, 3, 2, 3, 2, 1, 1 };
        byte[] dloc = { 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 1, 0, 0, 0, 0, 0, 0 };
        byte[] shlog = { aloc[sv], bloc[sv], cloc[sv], dloc[sv] };
        for (var b = 0; b < 4; b++)
        {
            Array.Copy(pkx, 8 + 56 * shlog[b], ekx, 8 + 56 * b, 56);
        }

        Array.Copy(ekx, pkx, pkx.Length);
    }

    internal static void cryptArray(ref byte[] data)
    {
        var dataout = (byte[])data.Clone();
        var pv = BitConverter.ToUInt32(dataout, 0);
        var seed = pv;
        for (var i = 8; i < 232; i += 2)
        {
            Array.Copy(BitConverter.GetBytes((ushort)(BitConverter.ToUInt16(dataout, i) ^ (LCRNG(ref seed) >> 16))), 0, dataout, i, 2);
        }

        Array.Copy(dataout, data, data.Length);
    }

    internal static byte[] decryptArray(byte[] ekx)
    {
        var pkx = (byte[])ekx.Clone();
        cryptArray(ref pkx);
        shuffleArray(ref pkx);
        return pkx;
    }

    internal static byte[] encryptArray(byte[] pkx)
    {
        var ekx = (byte[])pkx.Clone();
        for (var i = 0; i < 11; i++)
        {
            shuffleArray(ref ekx);
        }

        cryptArray(ref ekx);
        return ekx;
    }

    internal static ushort getCHK(byte[] data)
    {
        ushort chk = 0;
        for (var i = 8; i < 232; i += 2)
        {
            chk += BitConverter.ToUInt16(data, i);
        }

        return chk;
    }

    internal static bool verifychk(byte[] input)
    {
        ushort checksum = 0;
        if (input.Length is 100 or 80)  // Gen 3 Files
        {
            for (var i = 32; i < 80; i += 2)
            {
                checksum += BitConverter.ToUInt16(input, i);
            }

            return checksum == BitConverter.ToUInt16(input, 28);
        }
        {
            switch (input.Length)
            {
                case 236:
                case 220:
                case 136:
                    Array.Resize(ref input, 136);
                    break;

                case 232:
                case 260:
                    Array.Resize(ref input, 232);
                    break;

                default:
                    throw new Exception("Wrong sized input array to verifychecksum");
            }

            ushort chk = 0;
            for (var i = 8; i < input.Length; i += 2)
            {
                chk += BitConverter.ToUInt16(input, i);
            }

            return chk == BitConverter.ToUInt16(input, 0x6);
        }
    }

    internal static uint getPSV(uint PID) => Convert.ToUInt16(((PID >> 16) ^ (PID & 0xFFFF)) >> 4);

    internal static uint getTSV(uint TID, uint SID) => (TID ^ SID) >> 4;

    internal static void EncryptPokemon(Pokemon pokemon) => Array.Copy(encryptArray(pokemon.data), 0, pokemon.data, 0, 232);

    internal static void DecryptPokemon(Pokemon pokemon) => Array.Copy(decryptArray(pokemon.data), 0, pokemon.data, 0, 232);
}
