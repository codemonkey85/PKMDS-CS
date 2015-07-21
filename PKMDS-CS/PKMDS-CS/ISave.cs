namespace PKMDS_CS
{
    public interface ISave
    {
        byte CurrentBox { get; set; }

        PCStorageSystem PCStorageSystem { get; set; }

        PCStorageBoxNames PCStorageBoxNames { get; set; }
    }
}