#region Using

using System;

#endregion

namespace PKMDS_CS
{
    public static class PokePRNG
    {
        internal static uint LCRNG(uint seed)
        {
            const uint a = 0x41C64E6D;
            const uint c = 0x00006073;

            seed = (seed*a + c) & 0xFFFFFFFF;
            return seed;
        }

        internal static uint LCRNG(ref uint seed)
        {
            const uint a = 0x41C64E6D;
            const uint c = 0x00006073;

            seed = (seed*a + c) & 0xFFFFFFFF;
            return seed;
        }

        internal static byte[] shuffleArray(byte[] pkx, uint sv)
        {
            byte[] ekx = new byte[232];
            Array.Copy(pkx, ekx, 8);

            byte[] aloc = {0, 0, 0, 0, 0, 0, 1, 1, 2, 3, 2, 3, 1, 1, 2, 3, 2, 3, 1, 1, 2, 3, 2, 3};
            byte[] bloc = {1, 1, 2, 3, 2, 3, 0, 0, 0, 0, 0, 0, 2, 3, 1, 1, 3, 2, 2, 3, 1, 1, 3, 2};
            byte[] cloc = {2, 3, 1, 1, 3, 2, 2, 3, 1, 1, 3, 2, 0, 0, 0, 0, 0, 0, 3, 2, 3, 2, 1, 1};
            byte[] dloc = {3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 1, 0, 0, 0, 0, 0, 0};

            byte[] shlog = {aloc[sv], bloc[sv], cloc[sv], dloc[sv]};

            for (int b = 0; b < 4; b++)
                Array.Copy(pkx, 8 + 56*shlog[b], ekx, 8 + 56*b, 56);

            return ekx;
        }

        internal static byte[] decryptArray(byte[] ekx)
        {
            byte[] pkx = (byte[]) ekx.Clone();

            uint pv = BitConverter.ToUInt32(pkx, 0);
            uint sv = (((pv & 0x3E000) >> 0xD)%24);

            uint seed = pv;

            // Decrypt Blocks with RNG Seed
            for (int i = 8; i < 232; i += 2)
                Array.Copy(BitConverter.GetBytes((ushort) (BitConverter.ToUInt16(pkx, i) ^ (LCRNG(ref seed) >> 16))), 0,
                    pkx, i, 2);

            // Deshuffle
            pkx = shuffleArray(pkx, sv);

            // Decrypt the Party Stats
            seed = pv;
            if (pkx.Length <= 232) return pkx;
            for (int i = 232; i < 260; i += 2)
                Array.Copy(BitConverter.GetBytes((ushort) (BitConverter.ToUInt16(pkx, i) ^ (LCRNG(ref seed) >> 16))), 0,
                    pkx, i, 2);

            return pkx;
        }

        internal static byte[] encryptArray(byte[] pkx)
        {
            // Shuffle
            uint pv = BitConverter.ToUInt32(pkx, 0);
            uint sv = (((pv & 0x3E000) >> 0xD)%24);

            byte[] ekx = (byte[]) pkx.Clone();

            // If I unshuffle 11 times, the 12th (decryption) will always decrypt to ABCD.
            // 2 x 3 x 4 = 12 (possible unshuffle loops -> total iterations)
            for (int i = 0; i < 11; i++)
                ekx = shuffleArray(ekx, sv);

            uint seed = pv;
            // Encrypt Blocks with RNG Seed
            for (int i = 8; i < 232; i += 2)
                Array.Copy(BitConverter.GetBytes((ushort) (BitConverter.ToUInt16(ekx, i) ^ (LCRNG(ref seed) >> 16))), 0,
                    ekx, i, 2);

            // If no party stats, return.
            if (ekx.Length <= 232) return ekx;

            // Encrypt the Party Stats
            seed = pv;
            for (int i = 232; i < 260; i += 2)
                Array.Copy(BitConverter.GetBytes((ushort) (BitConverter.ToUInt16(ekx, i) ^ (LCRNG(ref seed) >> 16))), 0,
                    ekx, i, 2);

            // Done
            return ekx;
        }

        internal static ushort getCHK(byte[] data)
        {
            ushort chk = 0;
            for (int i = 8; i < 232; i += 2) // Loop through the entire PKX
                chk += BitConverter.ToUInt16(data, i);

            return chk;
        }

        internal static bool verifychk(byte[] input)
        {
            ushort checksum = 0;
            if (input.Length == 100 || input.Length == 80) // Gen 3 Files
            {
                for (int i = 32; i < 80; i += 2)
                    checksum += BitConverter.ToUInt16(input, i);

                return (checksum == BitConverter.ToUInt16(input, 28));
            }
            {
                if (input.Length == 236 || input.Length == 220 || input.Length == 136) // Gen 4/5
                    Array.Resize(ref input, 136);
                else if (input.Length == 232 || input.Length == 260) // Gen 6
                    Array.Resize(ref input, 232);
                else throw new Exception("Wrong sized input array to verifychecksum");

                ushort chk = 0;
                for (int i = 8; i < input.Length; i += 2)
                    chk += BitConverter.ToUInt16(input, i);

                return (chk == BitConverter.ToUInt16(input, 0x6));
            }
        }

        public static void DecryptPokemon(/*ref*/ Pokemon pokemon)
        {
            byte[] ekx = StructUtils.RawSerialize(pokemon);
            byte[] pkx = new byte[232];
            Array.Copy(ekx, 0, pkx, 0, 8);
            uint pv = pokemon.encryptionkey;
            uint sv = (((pv & 0x3E000) >> 0xD)%24);
            uint seed = pv;
            for (int i = 8; i < 232; i += 2)
            {
                Array.Copy(BitConverter.GetBytes((ushort) (BitConverter.ToUInt16(ekx, i) ^ (LCRNG(ref seed) >> 16))), 0,
                    pkx, i, 2);
            }
            pkx = shuffleArray(pkx, sv);
            StructUtils.RawDeserialize(pkx, pokemon);
        }

        public static void EncryptPokemon(ref Pokemon pokemon)
        {
            byte[] pkx = StructUtils.RawSerialize(pokemon);
            byte[] ekx = new byte[232];
            Array.Copy(pkx, 0, ekx, 0, 8);
            uint pv = pokemon.encryptionkey;
            uint sv = (((pv & 0x3E000) >> 0xD)%24);
            uint seed = pv;
            for (int i = 0; i < 11; i++)
                pkx = shuffleArray(pkx, sv);
            for (int i = 8; i < 232; i += 2)
            {
                Array.Copy(BitConverter.GetBytes((ushort) (BitConverter.ToUInt16(pkx, i) ^ (LCRNG(ref seed) >> 16))), 0,
                    ekx, i, 2);
            }
            StructUtils.RawDeserialize(ekx, pokemon);
        }
    }
}