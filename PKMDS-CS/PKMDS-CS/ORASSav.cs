#region Using

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

#endregion Using

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 0x100000, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASSav
    {
        [FieldOffset(0x38400)]
        [MarshalAs(UnmanagedType.Struct)]
        private PCStorageSystem pcstoragesystem;

        [FieldOffset(0x9800)]
        [MarshalAs(UnmanagedType.Struct)]
        private PCStorageBoxNames pcstorageboxnames;

        [FieldOffset(0x483F)]
        [MarshalAs(UnmanagedType.U1)]
        private byte currentbox;

        [DisplayName("Current Box")]
        public byte CurrentBox
        {
            get { return currentbox; }
            set { currentbox = value; }
        }

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

    }
}