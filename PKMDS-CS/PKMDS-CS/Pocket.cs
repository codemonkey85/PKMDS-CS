using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 0x640, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYItemsPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 400)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x180, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYKeyItemsPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }
        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A8, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYTMPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 106)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYMedicinePocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x120, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class XYBerryPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x640, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASItemsPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 400)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x180, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASKeyItemsPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1B0, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASTMPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 108)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASMedicinePocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }

    [StructLayout(LayoutKind.Explicit, Size = 0x120, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class ORASBerryPocket : IPocket
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        private uint[] _items;

        public uint[] ItemRawValues
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<ItemObject> Items
        {
            get
            {
                List<ItemObject> retItems = new List<ItemObject>();
                for (int i = 0; i < _items.Length; i++)
                {
                    retItems.Add(new ItemObject(this[i]));
                }
                return retItems;
            }
        }

        public ItemObject this[int i]
        {
            get
            {
                return new ItemObject(_items[i]);
            }
            set
            {
                _items[i] = value.ToUint();
            }
        }

    }
}