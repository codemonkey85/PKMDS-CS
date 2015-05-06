#region Using

using System;
using System.Runtime.InteropServices;

#endregion Using

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 0x100000, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYSav
    {
        [FieldOffset(0x27A00)]
        [MarshalAs(UnmanagedType.Struct)]
        private PCStorageSystem pcstoragesystem;

        [FieldOffset(0x9800)]
        [MarshalAs(UnmanagedType.Struct)]
        private PCStorageBoxNames pcstorageboxnames;

        public PCStorageSystem PCStorageSystem
        {
            get { return pcstoragesystem; }
            set { pcstoragesystem = value; }
        }

        public PCStorageBoxNames PCStorageBoxNames
        {
            get { return pcstorageboxnames; }
            set { pcstorageboxnames = value; }
        }

        //[FieldOffset(0x9800)]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        //private string box1name;

        //[FieldOffset(0x9C1E)]
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
        //private byte[] boxbackgrounds;

        //[FieldOffset(0x9800)]
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst=0x440)]
        //private byte[] test;

        //[DisplayName("Nickname")]
        //public string Nickname
        //{
        //    get
        //    {
        //        return System.Text.Encoding.Unicode.GetString(data, (int)Offsets.NicknameOffset, (int)Consts.NameMaxLength);
        //    }
        //    set
        //    {
        //        byte[] sdata = System.Text.Encoding.Unicode.GetBytes(value);
        //        int length = sdata.Length > (int)Consts.NameMaxLength ? (int)Consts.NameMaxLength : sdata.Length;
        //        Array.Clear(data, (int)Offsets.NicknameOffset, (int)Consts.NameMaxLength);
        //        Array.Copy(sdata, 0, data, (int)Offsets.NicknameOffset, length);
        //    }
        //}
    }
}