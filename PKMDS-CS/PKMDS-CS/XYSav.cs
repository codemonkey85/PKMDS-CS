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

        public PCStorageSystem PCStorageSystem
        {
            get { return pcstoragesystem; }
            set { pcstoragesystem = value; }
        }
    }
}