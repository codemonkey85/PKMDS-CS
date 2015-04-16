#region Using

using System;
using System.IO;
using System.Runtime.InteropServices;

#endregion

namespace PKMDS_CS
{
    public class StructUtils
    {
        public static void RawDeserialize(byte[] rawData, Pokemon pokemon)
        {
            pokemon.CloneFrom(RawDeserialize<Pokemon>(rawData));
        }

        public static TType RawDeserialize<TType>(byte[] rawData, int position = 0)
        {
            Type anyType = typeof (TType);
            int rawsize = Marshal.SizeOf(anyType);
            if (rawsize > rawData.Length) return default(TType);
            IntPtr buffer = Marshal.AllocHGlobal(rawsize);
            Marshal.Copy(rawData, position, buffer, rawsize);
            object retobj = Marshal.PtrToStructure(buffer, anyType);
            Marshal.FreeHGlobal(buffer);
            return (TType) retobj;
        }

        public static TType RawDeserialize<TType>(string fileName, int position = 0)
        {
            if (File.Exists(fileName))
            {
                byte[] data = null;
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        data = br.ReadBytes((int) fs.Length);
                        br.Close();
                        fs.Close();
                    }
                }
                return RawDeserialize<TType>(data, position);
            }
            return default(TType);
        }

        public static void RawSerialize<TType>(byte[] rawData, int position, TType value)
        {
            var Data = RawSerialize(value);
            Array.Copy(Data, 0, rawData, position, Data.Length);
        }

        public static void RawSerialize(object anything, string fileName)
        {
            if (anything == null || string.IsNullOrEmpty(fileName))
            {
                return;
            }
            byte[] data = RawSerialize(anything);
            if (data != null)
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(data);
                        bw.Close();
                        fs.Close();
                    }
                }
            }
        }

        public static byte[] RawSerialize(object anything)
        {
            int rawSize = Marshal.SizeOf(anything);
            IntPtr buffer = Marshal.AllocHGlobal(rawSize);
            Marshal.StructureToPtr(anything, buffer, false);
            byte[] rawDatas = new byte[rawSize];
            Marshal.Copy(buffer, rawDatas, 0, rawSize);
            Marshal.FreeHGlobal(buffer);
            return rawDatas;
        }
    }
}