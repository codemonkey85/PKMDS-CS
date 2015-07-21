namespace PKMDS_CS
{
    internal interface IPCStorageSystem
    {
        System.Collections.Generic.List<PCBox> Boxes { get; }

        PCBox this[int i] { get; set; }
    }
}