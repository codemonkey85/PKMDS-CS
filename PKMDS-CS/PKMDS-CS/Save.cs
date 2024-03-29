﻿namespace PKMDS_CS;

public interface ISave
{
    byte CurrentBox
    {
        get;
        set;
    }

    PCStorageSystem PCStorageSystem
    {
        get;
        set;
    }

    PCStorageBoxNames PCStorageBoxNames
    {
        get;
        set;
    }
}

[StructLayout(LayoutKind.Explicit, Size = 0x100000, Pack = 1, CharSet = CharSet.Unicode)]
[Serializable]
public class XYSav : ISave
{
    [FieldOffset(0x27A00)]
    [MarshalAs(UnmanagedType.Struct)]
    private PCStorageSystem pcstoragesystem;

    [FieldOffset(0x9800)]
    [MarshalAs(UnmanagedType.Struct)]
    private PCStorageBoxNames pcstorageboxnames;

    [FieldOffset(0x483F)]
    [MarshalAs(UnmanagedType.U1)]
    private byte currentbox;

    [DisplayName(@"Current Box")]
    public byte CurrentBox
    {
        get => currentbox;
        set => currentbox = value;
    }

    public PCStorageSystem PCStorageSystem
    {
        get => pcstoragesystem;
        set => pcstoragesystem = value;
    }

    public PCStorageBoxNames PCStorageBoxNames
    {
        get => pcstorageboxnames;
        set => pcstorageboxnames = value;
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

    [DisplayName(@"Current Box")]
    public byte CurrentBox
    {
        get => currentbox;
        set => currentbox = value;
    }

    public PCStorageSystem PCStorageSystem
    {
        get => pcstoragesystem;
        set => pcstoragesystem = value;
    }

    public PCStorageBoxNames PCStorageBoxNames
    {
        get => pcstorageboxnames;
        set => pcstorageboxnames = value;
    }
}
