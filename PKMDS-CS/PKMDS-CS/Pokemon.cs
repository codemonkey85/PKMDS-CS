using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 232, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class Pokemon
    {
        #region Unencrypted Bytes
        [FieldOffset(0x00)]
        [MarshalAsAttribute(UnmanagedType.U4)]
        private uint encryptionkey;
        [FieldOffset(0x04)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort sanity;
        [FieldOffset(0x06)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort checksum;
        #endregion
        #region Block A
        [FieldOffset(0x08)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort species;
        [FieldOffset(0x0A)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort item;
        [FieldOffset(0x0C)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort otid;
        [FieldOffset(0x0E)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort sid;
        [FieldOffset(0x10)]
        [MarshalAsAttribute(UnmanagedType.U4)]
        private uint exp;
        [FieldOffset(0x14)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte ability;
        [FieldOffset(0x15)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte abilitynum;
        [FieldOffset(0x16)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort supertraining;
        [FieldOffset(0x18)]
        [MarshalAsAttribute(UnmanagedType.U4)]
        private uint pid;
        [FieldOffset(0x1C)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte nature;
        [FieldOffset(0x1D)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte forms;
        [FieldOffset(0x1E)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte hp_effort;
        [FieldOffset(0x1F)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte attack_effort;
        [FieldOffset(0x20)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte defense_effort;
        [FieldOffset(0x21)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte speed_effort;
        [FieldOffset(0x22)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte spattack_effort;
        [FieldOffset(0x23)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte spdefense_effort;
        [FieldOffset(0x24)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte cool;
        [FieldOffset(0x25)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte beauty;
        [FieldOffset(0x26)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte cute;
        [FieldOffset(0x27)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte smart;
        [FieldOffset(0x28)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte tough;
        [FieldOffset(0x29)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte sheen;
        [FieldOffset(0x2A)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte markings;
        [FieldOffset(0x2B)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte pokerus;
        [FieldOffset(0x2C)]
        [MarshalAsAttribute(UnmanagedType.U4)]
        private uint supertraininggoldmedals;
        [FieldOffset(0x30)]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6)]
        private byte[] ribbons;
        [FieldOffset(0x38)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte contestmemoryribbons;
        [FieldOffset(0x39)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte battlememoryribbons;
        [FieldOffset(0x3A)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte distributionsupertrainingflags;
        #endregion
        #region Block B
        [FieldOffset(0x40)]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
        private string nickname;
        [FieldOffset(0x5A)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort move1id;
        [FieldOffset(0x5C)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort move2id;
        [FieldOffset(0x5E)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort move3id;
        [FieldOffset(0x60)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort move4id;
        [FieldOffset(0x62)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte move1currentpp;
        [FieldOffset(0x63)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte move2currentpp;
        [FieldOffset(0x64)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte move3currentpp;
        [FieldOffset(0x65)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte move4currentpp;
        [FieldOffset(0x6A)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort relearnmove1id;
        [FieldOffset(0x6C)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort relearnmove2id;
        [FieldOffset(0x6E)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort relearnmove3id;
        [FieldOffset(0x70)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort relearnmove4id;
        [FieldOffset(0x72)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte secretsupertrainingflag;
        [FieldOffset(0x74)]
        [MarshalAsAttribute(UnmanagedType.U4)]
        internal uint ivs;
        #endregion
        #region Block C
        [FieldOffset(0x78)]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
        private string lasttrainername;
        [FieldOffset(0x92)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte lasttrainergender;
        [FieldOffset(0x93)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte currenthandler;
        [FieldOffset(0x94)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort location1;
        [FieldOffset(0x96)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort location2;
        [FieldOffset(0x98)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort location3;
        [FieldOffset(0x9A)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort location4;
        [FieldOffset(0x9C)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort location5;
        [FieldOffset(0xA2)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte lasttrainerfriendship;
        [FieldOffset(0xA3)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte lasttraineraffection;
        [FieldOffset(0xA4)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte lasttrainermemoryintensity;
        [FieldOffset(0xA5)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte lasttrainermemoryline;
        [FieldOffset(0xA6)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte lasttrainermemoryfeeling;
        [FieldOffset(0xA8)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort lasttrainermemorytext;
        [FieldOffset(0xAE)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte fullness;
        [FieldOffset(0xAF)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte enjoyment;
        #endregion
        #region Block D
        [FieldOffset(0xB0)]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
        private string otname;
        [FieldOffset(0xCA)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte otfriendship;
        [FieldOffset(0xCB)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte otaffection;
        [FieldOffset(0xCC)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte otmemoryintensity;
        [FieldOffset(0xCD)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte otmemoryline;
        [FieldOffset(0xCE)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort otmemorytext;
        [FieldOffset(0xD0)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte otmemoryfeeling;
        [FieldOffset(0xD1)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte eggyear;
        [FieldOffset(0xD2)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte eggmonth;
        [FieldOffset(0xD3)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte eggday;
        [FieldOffset(0xD4)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte metyear;
        [FieldOffset(0xD5)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte metmonth;
        [FieldOffset(0xD6)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte metday;
        [FieldOffset(0xD8)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort egglocation;
        [FieldOffset(0xDA)]
        [MarshalAsAttribute(UnmanagedType.U2)]
        private ushort metlocation;
        [FieldOffset(0xDC)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte pokeball;
        [FieldOffset(0xDD)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte metlevelotgender;
        [FieldOffset(0xDE)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte encounter;
        [FieldOffset(0xDF)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte otgame;
        [FieldOffset(0xE0)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte country;
        [FieldOffset(0xE1)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte region;
        [FieldOffset(0xE2)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte tdsregion;
        [FieldOffset(0xE3)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        private byte otlang;
        #endregion
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
    }
    public enum Gender : byte
    {
        Male = 0,
        Female
    }
    /*
     
Value	Language
0x1	日本語 (Japan)
0x2	English (US/UK/AU)
0x3	Français (France/Québec)
0x4	Italiano (Italy)
0x5	Deutsch (Germany)
0x7	Español (Spain/Latin Americas)
0x8	한국어 (South Korea)
     
     Markings[edit]
Bit	Marking
0x01	Circle
0x02	Triangle
0x04	Square
0x08	Heart
0x10	Star
0x20	Diamon

     Encounter Types
     Value	Country
0x0	Pal Park, Egg, Hatched, Special Event
0x2	Tall Grass
0x4	Dialga/Palkia In-Game Event
0x5	Cave, Hall of Origin
0x7	Surfing, Fishing
0x9	Building
0xA	Great Marsh (Safari Zone)
0xC	Starter, Fossil, Gift (Eevee)
Medals & Ribbons[edit]
Super Training Medals[edit]
Flag Value	0x2C	0x2D	0x2E	0x2F
0x01	Unused	Sp. Atk Level 2	Atk Level 3	Follow Those Fleeing Goals!
0x02	Unused	HP Level 2	Sp. Def Level 3	Watch Out! That's One Tricky Second Half!
0x04	Sp. Atk Level 1	Atk Level 2	Speed Level 3	An Opening of Lighting-Quick Attacks!
0x08	HP Level 1	Sp. Def Level 2	Def Level 3	Those Long Shots Are No Long Shot!
0x10	Atk Level 1	Speed Level 2	The Troubles Keep on Coming?!	Scatterbug Lugs Back!
0x20	Sp. Def Level 1	Def Level 2	The Leaf Stone Cup Begins!	A Barrage of Bitbots!
0x40	Speed Level 1	Sp. Atk Level 3	The Fire Stone Cup Begins!	Drag Down Hydreigon!
0x80	Def Level 1	HP Level 3	The Water Stone Cup Begins!	The Battle for the Best: Version X/Y!
Ribbon Set 1[edit]
Flag Value	0x30	0x31
0x01	Kalos Champ Ribbon	Alert Ribbon
0x02	Champion Ribbon	Shock Ribbon
0x04	Sinnoh Champ Ribbon	Downcast Ribbon
0x08	Best Friends Ribbon	Careless Ribbon
0x10	Training Ribbon	Relax Ribbon
0x20	Skillful Battler Ribbon	Snooze Ribbon
0x40	Expert Battler Ribbon	Smile Ribbon
0x80	Effort Ribbon	Gorgeous Ribbon
Ribbon Set 2[edit]
Flag Value	0x32	0x33
0x01	Royal Ribbon	Earth Ribbon
0x02	Gorgeous Royal Ribbon	World Ribbon
0x04	Artist Ribbon	Classic Ribbon
0x08	Footprint Ribbon	Premier Ribbon
0x10	Record Ribbon	Event Ribbon
0x20	Legend Ribbon	Birthday Ribbon
0x40	Country Ribbon	Special Ribbon
0x80	National Ribbon	Souvenir Ribbon
Ribbon Set 3[edit]
Flag Value	0x34
0x01	Wishing Ribbon
0x02	Battle Champion Ribbon
0x04	Regional Champion Ribbon
0x08	National Champion Ribbon
0x10	World Champion Ribbon
0x20	None
0x40	None
0x80	Hoenn Champion Ribbon
Ribbon Set 4[edit]
Flag Value	0x35
0x01	Contest Star Ribbon
0x02	Coolness Master Ribbon
0x04	Beauty Master Ribbon
0x08	Cuteness Master Ribbon
0x10	Cleverness Master Ribbon
0x20	Toughness Master Ribbon
     */
}
