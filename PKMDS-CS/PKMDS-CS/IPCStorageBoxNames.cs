namespace PKMDS_CS
{
    internal interface IPCStorageBoxNames
    {
        System.Collections.Generic.List<BoxName> Boxes { get; }

        BoxName this[int i] { get; set; }
    }
}