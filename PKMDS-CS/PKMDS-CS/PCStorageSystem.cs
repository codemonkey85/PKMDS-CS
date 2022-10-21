namespace PKMDS_CS;

[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
[Serializable]
public class PCBox
{
    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon01;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon02;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon03;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon04;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon05;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon06;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon07;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon08;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon09;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon10;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon11;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon12;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon13;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon14;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon15;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon16;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon17;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon18;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon19;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon20;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon21;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon22;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon23;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon24;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon25;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon26;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon27;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon28;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon29;

    [MarshalAs(UnmanagedType.Struct)]
    private Pokemon pokemon30;

    public List<Pokemon> Pokemon
    {
        get
        {
            var pokemon = new List<Pokemon>();
            for (var i = 0; i < 30; i++)
            {
                pokemon.Add(this[i]);
            }
            return pokemon;
        }
    }

    public Pokemon this[int i]
    {
        get
        {
            return i switch
            {
                0 => pokemon01,
                1 => pokemon02,
                2 => pokemon03,
                3 => pokemon04,
                4 => pokemon05,
                5 => pokemon06,
                6 => pokemon07,
                7 => pokemon08,
                8 => pokemon09,
                9 => pokemon10,
                10 => pokemon11,
                11 => pokemon12,
                12 => pokemon13,
                13 => pokemon14,
                14 => pokemon15,
                15 => pokemon16,
                16 => pokemon17,
                17 => pokemon18,
                18 => pokemon19,
                19 => pokemon20,
                20 => pokemon21,
                21 => pokemon22,
                22 => pokemon23,
                23 => pokemon24,
                24 => pokemon25,
                25 => pokemon26,
                26 => pokemon27,
                27 => pokemon28,
                28 => pokemon29,
                29 => pokemon30,
                _ => null,
            };
        }
        set
        {
            switch (i)
            {
                case 0:
                    pokemon01 = value;
                    break;

                case 1:
                    pokemon02 = value;
                    break;

                case 2:
                    pokemon03 = value;
                    break;

                case 3:
                    pokemon04 = value;
                    break;

                case 4:
                    pokemon05 = value;
                    break;

                case 5:
                    pokemon06 = value;
                    break;

                case 6:
                    pokemon07 = value;
                    break;

                case 7:
                    pokemon08 = value;
                    break;

                case 8:
                    pokemon09 = value;
                    break;

                case 9:
                    pokemon10 = value;
                    break;

                case 10:
                    pokemon11 = value;
                    break;

                case 11:
                    pokemon12 = value;
                    break;

                case 12:
                    pokemon13 = value;
                    break;

                case 13:
                    pokemon14 = value;
                    break;

                case 14:
                    pokemon15 = value;
                    break;

                case 15:
                    pokemon16 = value;
                    break;

                case 16:
                    pokemon17 = value;
                    break;

                case 17:
                    pokemon18 = value;
                    break;

                case 18:
                    pokemon19 = value;
                    break;

                case 19:
                    pokemon20 = value;
                    break;

                case 20:
                    pokemon21 = value;
                    break;

                case 21:
                    pokemon22 = value;
                    break;

                case 22:
                    pokemon23 = value;
                    break;

                case 23:
                    pokemon24 = value;
                    break;

                case 24:
                    pokemon25 = value;
                    break;

                case 25:
                    pokemon26 = value;
                    break;

                case 26:
                    pokemon27 = value;
                    break;

                case 27:
                    pokemon28 = value;
                    break;

                case 28:
                    pokemon29 = value;
                    break;

                case 29:
                    pokemon30 = value;
                    break;

                default:
                    return;
            }
        }
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
[Serializable]
public class PCStorageSystem
{
    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box01;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box02;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box03;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box04;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box05;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box06;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box07;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box08;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box09;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box10;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box11;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box12;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box13;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box14;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box15;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box16;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box17;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box18;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box19;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box20;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box21;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box22;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box23;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box24;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box25;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box26;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box27;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box28;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box29;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box30;

    [MarshalAs(UnmanagedType.Struct)]
    private PCBox box31;

    public List<PCBox> Boxes
    {
        get
        {
            var boxes = new List<PCBox>();
            for (var i = 0; i < 31; i++)
            {
                boxes.Add(this[i]);
            }
            return boxes;
        }
    }

    public PCBox this[int i]
    {
        get
        {
            return i switch
            {
                0 => box01,
                1 => box02,
                2 => box03,
                3 => box04,
                4 => box05,
                5 => box06,
                6 => box07,
                7 => box08,
                8 => box09,
                9 => box10,
                10 => box11,
                11 => box12,
                12 => box13,
                13 => box14,
                14 => box15,
                15 => box16,
                16 => box17,
                17 => box18,
                18 => box19,
                19 => box20,
                20 => box21,
                21 => box22,
                22 => box23,
                23 => box24,
                24 => box25,
                25 => box26,
                26 => box27,
                27 => box28,
                28 => box29,
                29 => box30,
                30 => box31,
                _ => null,
            };
        }
        set
        {
            switch (i)
            {
                case 0:
                    box01 = value;
                    break;

                case 1:
                    box02 = value;
                    break;

                case 2:
                    box03 = value;
                    break;

                case 3:
                    box04 = value;
                    break;

                case 4:
                    box05 = value;
                    break;

                case 5:
                    box06 = value;
                    break;

                case 6:
                    box07 = value;
                    break;

                case 7:
                    box08 = value;
                    break;

                case 8:
                    box09 = value;
                    break;

                case 9:
                    box10 = value;
                    break;

                case 10:
                    box11 = value;
                    break;

                case 11:
                    box12 = value;
                    break;

                case 12:
                    box13 = value;
                    break;

                case 13:
                    box14 = value;
                    break;

                case 14:
                    box15 = value;
                    break;

                case 15:
                    box16 = value;
                    break;

                case 16:
                    box17 = value;
                    break;

                case 17:
                    box18 = value;
                    break;

                case 18:
                    box19 = value;
                    break;

                case 19:
                    box20 = value;
                    break;

                case 20:
                    box21 = value;
                    break;

                case 21:
                    box22 = value;
                    break;

                case 22:
                    box23 = value;
                    break;

                case 23:
                    box24 = value;
                    break;

                case 24:
                    box25 = value;
                    break;

                case 25:
                    box26 = value;
                    break;

                case 26:
                    box27 = value;
                    break;

                case 27:
                    box28 = value;
                    break;

                case 28:
                    box29 = value;
                    break;

                case 29:
                    box30 = value;
                    break;

                case 30:
                    box31 = value;
                    break;

                default:
                    return;
            }
        }
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
[Serializable]
public class PCStorageBoxNames
{
    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box01;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box02;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box03;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box04;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box05;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box06;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box07;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box08;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box09;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box10;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box11;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box12;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box13;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box14;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box15;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box16;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box17;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box18;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box19;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box20;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box21;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box22;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box23;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box24;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box25;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box26;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box27;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box28;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box29;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box30;

    [MarshalAs(UnmanagedType.Struct)]
    private BoxName box31;

    public List<BoxName> Boxes
    {
        get
        {
            var boxes = new List<BoxName>();
            for (var i = 0; i < 31; i++)
            {
                boxes.Add(this[i]);
            }
            return boxes;
        }
    }

    public BoxName this[int i]
    {
        get
        {
            return i switch
            {
                0 => box01,
                1 => box02,
                2 => box03,
                3 => box04,
                4 => box05,
                5 => box06,
                6 => box07,
                7 => box08,
                8 => box09,
                9 => box10,
                10 => box11,
                11 => box12,
                12 => box13,
                13 => box14,
                14 => box15,
                15 => box16,
                16 => box17,
                17 => box18,
                18 => box19,
                19 => box20,
                20 => box21,
                21 => box22,
                22 => box23,
                23 => box24,
                24 => box25,
                25 => box26,
                26 => box27,
                27 => box28,
                28 => box29,
                29 => box30,
                30 => box31,
                _ => null,
            };
        }
        set
        {
            switch (i)
            {
                case 0:
                    box01 = value;
                    break;

                case 1:
                    box02 = value;
                    break;

                case 2:
                    box03 = value;
                    break;

                case 3:
                    box04 = value;
                    break;

                case 4:
                    box05 = value;
                    break;

                case 5:
                    box06 = value;
                    break;

                case 6:
                    box07 = value;
                    break;

                case 7:
                    box08 = value;
                    break;

                case 8:
                    box09 = value;
                    break;

                case 9:
                    box10 = value;
                    break;

                case 10:
                    box11 = value;
                    break;

                case 11:
                    box12 = value;
                    break;

                case 12:
                    box13 = value;
                    break;

                case 13:
                    box14 = value;
                    break;

                case 14:
                    box15 = value;
                    break;

                case 15:
                    box16 = value;
                    break;

                case 16:
                    box17 = value;
                    break;

                case 17:
                    box18 = value;
                    break;

                case 18:
                    box19 = value;
                    break;

                case 19:
                    box20 = value;
                    break;

                case 20:
                    box21 = value;
                    break;

                case 21:
                    box22 = value;
                    break;

                case 22:
                    box23 = value;
                    break;

                case 23:
                    box24 = value;
                    break;

                case 24:
                    box25 = value;
                    break;

                case 25:
                    box26 = value;
                    break;

                case 26:
                    box27 = value;
                    break;

                case 27:
                    box28 = value;
                    break;

                case 28:
                    box29 = value;
                    break;

                case 29:
                    box30 = value;
                    break;

                case 30:
                    box31 = value;
                    break;

                default:
                    return;
            }
        }
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
[Serializable]
public class BoxName
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value == string.Empty)
            {
                throw new Exception("Cannot have an empty box name.");
            }

            if (value.Length > 17)
            {
                value = value[..17];
            }

            name = value;
        }
    }

    public override string ToString() => Name;
}
