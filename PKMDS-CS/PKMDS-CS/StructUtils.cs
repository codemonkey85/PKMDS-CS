#region Using

using System;
using System.IO;
using System.Runtime.InteropServices;

#endregion Using

namespace PKMDS_CS
{
    public class StructUtils
    {
        public static TType RawDeserialize<TType>(byte[] rawData, int position = 0)
        {
            Type anyType = typeof(TType);
            int rawsize = Marshal.SizeOf(anyType);
            if (rawsize > rawData.Length) return default(TType);
            IntPtr buffer = Marshal.AllocHGlobal(rawsize);
            Marshal.Copy(rawData, position, buffer, rawsize);
            object retobj = Marshal.PtrToStructure(buffer, anyType);
            Marshal.FreeHGlobal(buffer);
            return (TType)retobj;
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
                        data = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                    }
                }
                return RawDeserialize<TType>(data, position);
            }
            return default(TType);
        }

        private static void RawSerialize(object anything, string fileName)
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

        private static byte[] RawSerialize(object anything)
        {
            int rawSize = Marshal.SizeOf(anything);
            IntPtr buffer = Marshal.AllocHGlobal(rawSize);
            Marshal.StructureToPtr(anything, buffer, false);
            byte[] rawDatas = new byte[rawSize];
            Marshal.Copy(buffer, rawDatas, 0, rawSize);
            Marshal.FreeHGlobal(buffer);
            return rawDatas;
        }

        public static FileInfo GetTempFileInfo()
        {
            return new FileInfo(Path.GetTempFileName());
        }

        public static FileStream GetTempFileStream(FileMode fileMode, FileAccess fileAccess)
        {
            return new FileStream(Path.GetTempFileName(), fileMode, fileAccess);
        }

        public static void WriteObject<T>(T _object, string fileName)
        {
            if (_object == null) return;
            if (_object is ISave)
            {
                var sav = (_object as ISave);
                if (sav == null) return;
            }
            RawSerialize(_object, fileName);
        }
    }
}