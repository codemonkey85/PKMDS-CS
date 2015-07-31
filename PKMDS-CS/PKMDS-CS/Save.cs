using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 0x100000, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYSav : ISave
    {
        public XYSav()
        {
            //Bag = new XYBag();
        }

        [FieldOffset(0x27A00)]
        [MarshalAs(UnmanagedType.Struct)]
        private PCStorageSystem pcstoragesystem;

        [FieldOffset(0x9800)]
        [MarshalAs(UnmanagedType.Struct)]
        private PCStorageBoxNames pcstorageboxnames;

        [FieldOffset(0x483F)]
        [MarshalAs(UnmanagedType.U1)]
        private byte currentbox;

        [FieldOffset(0x05800)]
        [MarshalAs(UnmanagedType.Struct)]
        private XYBag _bag;

        public IBag Bag
        {
            get
            {
                return _bag;
            }
            set
            {
                _bag.ItemsPocket.ItemRawValues = value.ItemsPocket.ItemRawValues;
                _bag.KeyItemsPocket.ItemRawValues = value.KeyItemsPocket.ItemRawValues;
                _bag.TMPocket.ItemRawValues = value.TMPocket.ItemRawValues;
                _bag.MedicinePocket.ItemRawValues = value.MedicinePocket.ItemRawValues;
                _bag.BerryPocket.ItemRawValues = value.BerryPocket.ItemRawValues;
            }
        }

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

    [StructLayout(LayoutKind.Explicit, Size = 0x100000, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASSav : ISave
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

        [FieldOffset(0x05800)]
        [MarshalAs(UnmanagedType.Struct)]
        private ORASBag _bag;

        public IBag Bag
        {
            get
            {
                return _bag;
            }
            set
            {
                _bag.ItemsPocket.ItemRawValues = value.ItemsPocket.ItemRawValues;
                _bag.KeyItemsPocket.ItemRawValues = value.KeyItemsPocket.ItemRawValues;
                _bag.TMPocket.ItemRawValues = value.TMPocket.ItemRawValues;
                _bag.MedicinePocket.ItemRawValues = value.MedicinePocket.ItemRawValues;
                _bag.BerryPocket.ItemRawValues = value.BerryPocket.ItemRawValues;
            }
        }


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