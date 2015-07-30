using System;
using System.Runtime.InteropServices;

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 0x640, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class XYItemsPocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x180, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class XYKeyItemsPocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A8, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class XYTMPocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class XYMedicinePocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x120, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class XYBerryPocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x640, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class ORASItemsPocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x180, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class ORASKeyItemsPocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1AA, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class ORASTMPocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class ORASMedicinePocket : IPocket
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x120, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class ORASBerryPocket : IPocket
    {
    }
}