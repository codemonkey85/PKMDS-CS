using System.Collections.Generic;

namespace PKMDS_CS
{
    public interface IPocket
    {
        uint[] ItemRawValues { get; set; }

        List<ItemObject> Items { get; }

        ItemObject this[int i] { get; set; }
    }
}