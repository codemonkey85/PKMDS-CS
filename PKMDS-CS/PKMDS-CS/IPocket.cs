namespace PKMDS_CS
{
    public interface IPocket
    {
        uint[] ItemRawValues { get; set; }
        ItemObject this[int i] { get; set; }
    }
}