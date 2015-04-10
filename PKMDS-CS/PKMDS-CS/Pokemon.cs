#region Using

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

#endregion Using

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 232, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class Pokemon
    {
        #region Unencrypted Bytes

        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.U4)]
        private uint encryptionkey;

        [FieldOffset(0x04)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort sanity;

        [FieldOffset(0x06)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort checksum;

        #endregion Unencrypted Bytes

        #region Block A

        [FieldOffset(0x08)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort species;

        [FieldOffset(0x0A)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort item;

        [FieldOffset(0x0C)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort otid;

        [FieldOffset(0x0E)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort sid;

        [FieldOffset(0x10)]
        [MarshalAs(UnmanagedType.U4)]
        private uint exp;

        [FieldOffset(0x14)]
        [MarshalAs(UnmanagedType.U1)]
        private byte ability;

        [FieldOffset(0x15)]
        [MarshalAs(UnmanagedType.U1)]
        private byte abilitynum;

        [FieldOffset(0x16)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort supertraining;

        [FieldOffset(0x18)]
        [MarshalAs(UnmanagedType.U4)]
        private uint pid;

        [FieldOffset(0x1C)]
        [MarshalAs(UnmanagedType.U1)]
        private byte nature;

        [FieldOffset(0x1D)]
        [MarshalAs(UnmanagedType.U1)]
        private byte forms;

        [FieldOffset(0x1E)]
        [MarshalAs(UnmanagedType.U1)]
        private byte hp_effort;

        [FieldOffset(0x1F)]
        [MarshalAs(UnmanagedType.U1)]
        private byte attack_effort;

        [FieldOffset(0x20)]
        [MarshalAs(UnmanagedType.U1)]
        private byte defense_effort;

        [FieldOffset(0x21)]
        [MarshalAs(UnmanagedType.U1)]
        private byte speed_effort;

        [FieldOffset(0x22)]
        [MarshalAs(UnmanagedType.U1)]
        private byte spattack_effort;

        [FieldOffset(0x23)]
        [MarshalAs(UnmanagedType.U1)]
        private byte spdefense_effort;

        [FieldOffset(0x24)]
        [MarshalAs(UnmanagedType.U1)]
        private byte cool;

        [FieldOffset(0x25)]
        [MarshalAs(UnmanagedType.U1)]
        private byte beauty;

        [FieldOffset(0x26)]
        [MarshalAs(UnmanagedType.U1)]
        private byte cute;

        [FieldOffset(0x27)]
        [MarshalAs(UnmanagedType.U1)]
        private byte smart;

        [FieldOffset(0x28)]
        [MarshalAs(UnmanagedType.U1)]
        private byte tough;

        [FieldOffset(0x29)]
        [MarshalAs(UnmanagedType.U1)]
        private byte sheen;

        [FieldOffset(0x2A)]
        [MarshalAs(UnmanagedType.U1)]
        private byte markings;

        [FieldOffset(0x2B)]
        [MarshalAs(UnmanagedType.U1)]
        private byte pokerus;

        [FieldOffset(0x2C)]
        [MarshalAs(UnmanagedType.U4)]
        private uint supertraininggoldmedals;

        [FieldOffset(0x30)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        private byte[] ribbons;

        [FieldOffset(0x38)]
        [MarshalAs(UnmanagedType.U1)]
        private byte contestmemoryribbons;

        [FieldOffset(0x39)]
        [MarshalAs(UnmanagedType.U1)]
        private byte battlememoryribbons;

        [FieldOffset(0x3A)]
        [MarshalAs(UnmanagedType.U1)]
        private byte distributionsupertrainingflags;

        #endregion Block A

        #region Block B

        [FieldOffset(0x40)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        private string nickname;

        [FieldOffset(0x5A)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort move1id;

        [FieldOffset(0x5C)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort move2id;

        [FieldOffset(0x5E)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort move3id;

        [FieldOffset(0x60)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort move4id;

        [FieldOffset(0x62)]
        [MarshalAs(UnmanagedType.U1)]
        private byte move1currentpp;

        [FieldOffset(0x63)]
        [MarshalAs(UnmanagedType.U1)]
        private byte move2currentpp;

        [FieldOffset(0x64)]
        [MarshalAs(UnmanagedType.U1)]
        private byte move3currentpp;

        [FieldOffset(0x65)]
        [MarshalAs(UnmanagedType.U1)]
        private byte move4currentpp;

        [FieldOffset(0x6A)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort relearnmove1id;

        [FieldOffset(0x6C)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort relearnmove2id;

        [FieldOffset(0x6E)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort relearnmove3id;

        [FieldOffset(0x70)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort relearnmove4id;

        [FieldOffset(0x72)]
        [MarshalAs(UnmanagedType.U1)]
        private byte secretsupertrainingflag;

        [FieldOffset(0x74)]
        [MarshalAs(UnmanagedType.U4)]
        internal uint ivs;

        #endregion Block B

        #region Block C

        [FieldOffset(0x78)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        private string lasttrainername;

        [FieldOffset(0x92)]
        [MarshalAs(UnmanagedType.U1)]
        private byte lasttrainergender;

        [FieldOffset(0x93)]
        [MarshalAs(UnmanagedType.U1)]
        private byte currenthandler;

        [FieldOffset(0x94)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort location1;

        [FieldOffset(0x96)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort location2;

        [FieldOffset(0x98)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort location3;

        [FieldOffset(0x9A)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort location4;

        [FieldOffset(0x9C)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort location5;

        [FieldOffset(0xA2)]
        [MarshalAs(UnmanagedType.U1)]
        private byte lasttrainerfriendship;

        [FieldOffset(0xA3)]
        [MarshalAs(UnmanagedType.U1)]
        private byte lasttraineraffection;

        [FieldOffset(0xA4)]
        [MarshalAs(UnmanagedType.U1)]
        private byte lasttrainermemoryintensity;

        [FieldOffset(0xA5)]
        [MarshalAs(UnmanagedType.U1)]
        private byte lasttrainermemoryline;

        [FieldOffset(0xA6)]
        [MarshalAs(UnmanagedType.U1)]
        private byte lasttrainermemoryfeeling;

        [FieldOffset(0xA8)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort lasttrainermemorytext;

        [FieldOffset(0xAE)]
        [MarshalAs(UnmanagedType.U1)]
        private byte fullness;

        [FieldOffset(0xAF)]
        [MarshalAs(UnmanagedType.U1)]
        private byte enjoyment;

        #endregion Block C

        #region Block D

        [FieldOffset(0xB0)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        private string otname;

        [FieldOffset(0xCA)]
        [MarshalAs(UnmanagedType.U1)]
        private byte otfriendship;

        [FieldOffset(0xCB)]
        [MarshalAs(UnmanagedType.U1)]
        private byte otaffection;

        [FieldOffset(0xCC)]
        [MarshalAs(UnmanagedType.U1)]
        private byte otmemoryintensity;

        [FieldOffset(0xCD)]
        [MarshalAs(UnmanagedType.U1)]
        private byte otmemoryline;

        [FieldOffset(0xCE)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort otmemorytext;

        [FieldOffset(0xD0)]
        [MarshalAs(UnmanagedType.U1)]
        private byte otmemoryfeeling;

        [FieldOffset(0xD1)]
        [MarshalAs(UnmanagedType.U1)]
        private byte eggyear;

        [FieldOffset(0xD2)]
        [MarshalAs(UnmanagedType.U1)]
        private byte eggmonth;

        [FieldOffset(0xD3)]
        [MarshalAs(UnmanagedType.U1)]
        private byte eggday;

        [FieldOffset(0xD4)]
        [MarshalAs(UnmanagedType.U1)]
        private byte metyear;

        [FieldOffset(0xD5)]
        [MarshalAs(UnmanagedType.U1)]
        private byte metmonth;

        [FieldOffset(0xD6)]
        [MarshalAs(UnmanagedType.U1)]
        private byte metday;

        [FieldOffset(0xD8)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort egglocation;

        [FieldOffset(0xDA)]
        [MarshalAs(UnmanagedType.U2)]
        private ushort metlocation;

        [FieldOffset(0xDC)]
        [MarshalAs(UnmanagedType.U1)]
        private byte pokeball;

        [FieldOffset(0xDD)]
        [MarshalAs(UnmanagedType.U1)]
        private byte metlevelotgender;

        [FieldOffset(0xDE)]
        [MarshalAs(UnmanagedType.U1)]
        private byte encounter;

        [FieldOffset(0xDF)]
        [MarshalAs(UnmanagedType.U1)]
        private byte otgame;

        [FieldOffset(0xE0)]
        [MarshalAs(UnmanagedType.U1)]
        private byte country;

        [FieldOffset(0xE1)]
        [MarshalAs(UnmanagedType.U1)]
        private byte region;

        [FieldOffset(0xE2)]
        [MarshalAs(UnmanagedType.U1)]
        private byte tdsregion;

        [FieldOffset(0xE3)]
        [MarshalAs(UnmanagedType.U1)]
        private byte otlang;

        #endregion Block D

        [DisplayName("HP IV")]
        public uint HP_IV
        {
            get { return (ivs >> 00) & 0x1F; }
            set { ivs = (ivs & ~(0x1Fu << 00)) | (value & 0x1Fu) << 00; }
        }

        [DisplayName("Attack IV")]
        public uint Attack_IV
        {
            get { return (ivs >> 05) & 0x1F; }
            set { ivs = (ivs & ~(0x1Fu << 05)) | (value & 0x1Fu) << 05; }
        }

        [DisplayName("Defense IV")]
        public uint Defense_IV
        {
            get { return (ivs >> 10) & 0x1F; }
            set { ivs = (ivs & ~(0x1Fu << 10)) | (value & 0x1Fu) << 10; }
        }

        [DisplayName("Speed IV")]
        public uint Speed_IV
        {
            get { return (ivs >> 15) & 0x1F; }
            set { ivs = (ivs & ~(0x1Fu << 15)) | (value & 0x1Fu) << 15; }
        }

        [DisplayName("Special Attack IV")]
        public uint SpecialAttack_IV
        {
            get { return (ivs >> 20) & 0x1F; }
            set { ivs = (ivs & ~(0x1Fu << 20)) | (value & 0x1Fu) << 20; }
        }

        [DisplayName("Special Defense IV")]
        public uint SpecialDefense_IV
        {
            get { return (ivs >> 25) & 0x1F; }
            set { ivs = (ivs & ~(0x1Fu << 25)) | (value & 0x1Fu) << 25; }
        }

        [DisplayName("Is Egg")]
        public bool IsEgg
        {
            get { return ((ivs >> 30) & 0x01u) == 1; }
            set { ivs = (ivs & ~(0x01u << 30)) | (Convert.ToUInt32(value) & 0x01u) << 30; }
        }

        [DisplayName("Is Nicknamed")]
        public bool IsNicknamed
        {
            get { return ((ivs >> 31) & 0x01u) == 1; }
            set { ivs = (ivs & ~(0x01u << 31)) | (Convert.ToUInt32(value) & 0x01u) << 31; }
        }

        [DisplayName("Fateful Encounter")]
        public bool Fateful
        {
            get { return ((forms >> 0) & 0x1F) == 1; }
            set { forms = Convert.ToByte((forms & ~(0x1F << 0)) | (Convert.ToByte(value) & 0x1F) << 0); }
        }

        [DisplayName("Is Female")]
        public bool Female
        {
            get { return ((forms >> 1) & 0x1F) == 1; }
            set { forms = Convert.ToByte((forms & ~(0x1F << 1)) | (Convert.ToByte(value) & 0x1F) << 1); }
        }

        [DisplayName("Is Genderless")]
        public bool Genderless
        {
            get { return ((forms >> 2) & 0x1F) == 1; }
            set { forms = Convert.ToByte((forms & ~(0x1F << 2)) | (Convert.ToByte(value) & 0x1F) << 2); }
        }

        [DisplayName("Form ID")]
        public byte AlternateForm
        {
            get { return Convert.ToByte((forms >> 3) & 0x1F); }
            set { forms = Convert.ToByte((forms & ~(0x1F << 3)) | (value & 0x1F) << 3); }
        }

        [DisplayName("Species")]
        public Species Species
        {
            get { return (Species)species; }
            set { species = (ushort)value; }
        }
    }
}