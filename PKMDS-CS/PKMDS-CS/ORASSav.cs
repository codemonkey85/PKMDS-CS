#region Using

using System;
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

        public PCStorageSystem PCStorageSystem
        {
            get { return pcstoragesystem; }
            set { pcstoragesystem = value; }
        }
    }
}