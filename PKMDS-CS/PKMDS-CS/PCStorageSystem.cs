#region Using

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

#endregion

namespace PKMDS_CS
{
    //[StructLayout(LayoutKind.Sequential, Size = 6960, Pack = 1, CharSet = CharSet.Unicode)]
    //[Serializable]
    //public class PCBox
    //{
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon01;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon02;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon03;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon04;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon05;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon06;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon07;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon08;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon09;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon10;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon11;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon12;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon13;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon14;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon15;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon16;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon17;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon18;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon19;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon20;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon21;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon22;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon23;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon24;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon25;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon26;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon27;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon28;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon29;
    //    [MarshalAs(UnmanagedType.Struct)]
    //    private Pokemon pokemon30;

    //    public PCBox()
    //    {
    //        pokemon01 = new Pokemon();
    //        pokemon02 = new Pokemon();
    //        pokemon03 = new Pokemon();
    //        pokemon04 = new Pokemon();
    //        pokemon05 = new Pokemon();
    //        pokemon06 = new Pokemon();
    //        pokemon07 = new Pokemon();
    //        pokemon08 = new Pokemon();
    //        pokemon09 = new Pokemon();
    //        pokemon10 = new Pokemon();
    //        pokemon11 = new Pokemon();
    //        pokemon12 = new Pokemon();
    //        pokemon13 = new Pokemon();
    //        pokemon14 = new Pokemon();
    //        pokemon15 = new Pokemon();
    //        pokemon16 = new Pokemon();
    //        pokemon17 = new Pokemon();
    //        pokemon18 = new Pokemon();
    //        pokemon19 = new Pokemon();
    //        pokemon20 = new Pokemon();
    //        pokemon21 = new Pokemon();
    //        pokemon22 = new Pokemon();
    //        pokemon23 = new Pokemon();
    //        pokemon24 = new Pokemon();
    //        pokemon25 = new Pokemon();
    //        pokemon26 = new Pokemon();
    //        pokemon27 = new Pokemon();
    //        pokemon28 = new Pokemon();
    //        pokemon29 = new Pokemon();
    //        pokemon30 = new Pokemon();
    //    }

    //    public Pokemon this[int i]
    //    {
    //        get
    //        {
    //            switch (i)
    //            {
    //                case 0:
    //                    return pokemon01;
    //                default:
    //                    return null;
    //            }
    //        }
    //        set
    //        {
    //            switch (i)
    //            {
    //                case 1:
    //                    pokemon01 = value;
    //                    break;
    //                default:
    //                    return;
    //            }
    //        }
    //    }

    //}
    //[StructLayout(LayoutKind.Sequential, Size = 215760, Pack = 1, CharSet = CharSet.Unicode)]
    //[Serializable]
    //public class PCStorageSystem
    //{
    //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
    //    public PCBox[] Boxes;

    //    public PCStorageSystem()
    //    {
    //        Boxes = new PCBox[31];
    //    }

    //    public PCBox this[int i]
    //    {
    //        get
    //        {
    //            return this.Boxes[i];
    //        }
    //        set
    //        {
    //            this.Boxes[i] = value;
    //        }
    //    }

    //}
}
