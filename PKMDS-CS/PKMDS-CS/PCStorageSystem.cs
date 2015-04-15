#region Using

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#endregion

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class PCBox
    {
        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon01;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon02;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon03;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon04;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon05;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon06;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon07;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon08;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon09;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon10;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon11;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon12;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon13;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon14;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon15;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon16;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon17;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon18;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon19;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon20;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon21;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon22;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon23;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon24;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon25;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon26;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon27;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon28;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon29;

        [MarshalAs(UnmanagedType.Struct)] private Pokemon pokemon30;

        public List<Pokemon> Pokemon
        {
            get
            {
                List<Pokemon> pokemon = new List<Pokemon>();
                for (int i = 0; i < 30; i++)
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
                switch (i)
                {
                    case 0:
                        return pokemon01;
                    case 1:
                        return pokemon02;
                    case 2:
                        return pokemon03;
                    case 3:
                        return pokemon04;
                    case 4:
                        return pokemon05;
                    case 5:
                        return pokemon06;
                    case 6:
                        return pokemon07;
                    case 7:
                        return pokemon08;
                    case 8:
                        return pokemon09;
                    case 9:
                        return pokemon10;
                    case 10:
                        return pokemon11;
                    case 11:
                        return pokemon12;
                    case 12:
                        return pokemon13;
                    case 13:
                        return pokemon14;
                    case 14:
                        return pokemon15;
                    case 15:
                        return pokemon16;
                    case 16:
                        return pokemon17;
                    case 17:
                        return pokemon18;
                    case 18:
                        return pokemon19;
                    case 19:
                        return pokemon20;
                    case 20:
                        return pokemon21;
                    case 21:
                        return pokemon22;
                    case 22:
                        return pokemon23;
                    case 23:
                        return pokemon24;
                    case 24:
                        return pokemon25;
                    case 25:
                        return pokemon26;
                    case 26:
                        return pokemon27;
                    case 27:
                        return pokemon28;
                    case 28:
                        return pokemon29;
                    case 29:
                        return pokemon30;
                    default:
                        return null;
                }
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
        [MarshalAs(UnmanagedType.Struct)] private PCBox box01;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box02;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box03;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box04;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box05;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box06;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box07;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box08;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box09;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box10;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box11;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box12;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box13;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box14;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box15;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box16;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box17;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box18;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box19;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box20;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box21;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box22;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box23;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box24;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box25;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box26;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box27;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box28;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box29;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box30;

        [MarshalAs(UnmanagedType.Struct)] private PCBox box31;

        public List<PCBox> Boxes
        {
            get
            {
                List<PCBox> boxes = new List<PCBox>();
                for (int i = 0; i < 31; i++)
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
                switch (i)
                {
                    case 0:
                        return box01;
                    case 1:
                        return box02;
                    case 2:
                        return box03;
                    case 3:
                        return box04;
                    case 4:
                        return box05;
                    case 5:
                        return box06;
                    case 6:
                        return box07;
                    case 7:
                        return box08;
                    case 8:
                        return box09;
                    case 9:
                        return box10;
                    case 10:
                        return box11;
                    case 11:
                        return box12;
                    case 12:
                        return box13;
                    case 13:
                        return box14;
                    case 14:
                        return box15;
                    case 15:
                        return box16;
                    case 16:
                        return box17;
                    case 17:
                        return box18;
                    case 18:
                        return box19;
                    case 19:
                        return box20;
                    case 20:
                        return box21;
                    case 21:
                        return box22;
                    case 22:
                        return box23;
                    case 23:
                        return box24;
                    case 24:
                        return box25;
                    case 25:
                        return box26;
                    case 26:
                        return box27;
                    case 27:
                        return box28;
                    case 28:
                        return box29;
                    case 29:
                        return box30;
                    case 30:
                        return box31;
                    default:
                        return null;
                }
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
}