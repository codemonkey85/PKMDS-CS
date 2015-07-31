namespace PKMDS_CS
{
    public interface IBag
    {
        IPocket ItemsPocket { get; set; }

        IPocket KeyItemsPocket { get; set; }

        IPocket TMPocket { get; set; }

        IPocket MedicinePocket { get; set; }

        IPocket BerryPocket { get; set; }
    }
}