using System;
using System.Runtime.InteropServices;

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0B88, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYBag : IBag
    {
        [FieldOffset(0x0000)]
        [MarshalAs(UnmanagedType.Struct)]
        private XYItemsPocket _itemsPocket;

        [FieldOffset(0x0640)]
        [MarshalAs(UnmanagedType.Struct)]
        private XYKeyItemsPocket _keyItemsPocket;

        [FieldOffset(0x07C0)]
        [MarshalAs(UnmanagedType.Struct)]
        private XYTMPocket _tMPocket;

        [FieldOffset(0x0968)]
        [MarshalAs(UnmanagedType.Struct)]
        private XYMedicinePocket _medicinePocket;

        [FieldOffset(0x0A68)]
        [MarshalAs(UnmanagedType.Struct)]
        private XYBerryPocket _berryPocket;

        public IPocket ItemsPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket KeyItemsPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket TMPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket MedicinePocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket BerryPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0B90, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASBag : IBag
    {
        [FieldOffset(0x0000)]
        [MarshalAs(UnmanagedType.Struct)]
        private ORASItemsPocket _itemsPocket;

        [FieldOffset(0x0640)]
        [MarshalAs(UnmanagedType.Struct)]
        private ORASKeyItemsPocket _keyItemsPocket;

        [FieldOffset(0x07C0)]
        [MarshalAs(UnmanagedType.Struct)]
        private ORASTMPocket _tMPocket;

        [FieldOffset(0x0970)]
        [MarshalAs(UnmanagedType.Struct)]
        private ORASMedicinePocket _medicinePocket;

        [FieldOffset(0x0A70)]
        [MarshalAs(UnmanagedType.Struct)]
        private ORASBerryPocket _berryPocket;

        public IPocket ItemsPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket KeyItemsPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket TMPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket MedicinePocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }

        public IPocket BerryPocket
        {
            get { return _itemsPocket; }
            set { _itemsPocket.ItemRawValues = value.ItemRawValues; }
        }
    }
}

/*

Items in the save file structure

X / Y

0001	05800	00000B88	6A822
05800 - Items Pocket
05E40 - Key Items Pocket
05FC0 - TM Pocket
06168 - Medicine Pocket
06268 - Berry Pocket

ORAS

0001	5800	00000B90	75E22
05800 - Items Pocket
05E40 - Key Items Pocket
05FC0 - TM Pocket
06170- Medicine Pocket
06270 - Berry Pocket
*/