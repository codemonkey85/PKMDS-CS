namespace PKMDS_CS
{
    internal interface IPCBox
    {
        System.Collections.Generic.List<Pokemon> Pokemon { get; }

        Pokemon this[int i] { get; set; }
    }
}