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
        /*
        [FieldOffset(0x1E)]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6)]
        private byte[] efforts;
        [FieldOffset(0x24)]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6)]
        private byte[] contests;
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
        [FieldOffset(0x36)]
        [MarshalAsAttribute(UnmanagedType.U4)]
        private ushort unused1;


        /*
         0x1E	HP Effort Value
         1F	Attack Effort Value
         20	Defense Effort Value
         21	Speed Effort Value
         22	SP Attack Effort Value
         23	SP Defense Effort Value
         24	Contest Stat: Cool
         25	Contest Stat: Beauty
         26	Contest Stat: Cute
         27	Contest Stat: Smart
         28	Contest Stat: Tough
         29	Contest Stat: Sheen
         2A	Markings
         2B	Pokérus
         2C-0x2F	(Secret) Super Training
         Gold Medal Flags
         30-         35	Ribbons
         36-0x37	Unused
         38	Contest Memory Ribbon [Count]
         39	Battle Memory Ribbon [Count]
         3A	Distribution Super Training Flags
         3B-0x3F	Unused
         */

        #endregion
        #region Block B
        /*
         Block B (0x40-0x77)[edit]
         Offset	Contents
         40-0x57	Nickname
         58-0x59	Null Terminator
         0x5A-0x5B	Move 1 ID
         0x5C-0x5D	Move 2 ID
         0x5E-0x5F	Move 3 ID
         0x60-0x61	Move 4 ID
         0x62	Move 1 Current PP
         0x63	Move 2 Current PP
         0x64	Move 3 Current PP
         0x65	Move 4 Current PP
         0x66-0x69	Move PP Ups
         0x6A-0x6B	Relearn Move 1 ID
         0x6C-0x6D	Relearn Move 2 ID
         0x6E-0x6F	Relearn Move 3 ID
         0x70-0x71	Relearn Move 4 ID
         0x72	"Secret" Super Training Flag
         0 - Missions Unavailable
         1 - Missions Available
         0x73	Unused
         0x74-0x77	Bits 0-29 - Individual Values
         HP ( [0-31] << 0 )
         Attack ( [0-31] << 5 )
         Defense ( [0-31] << 10 )
         Speed ( [0-31] << 15 )
         SP Attack ( [0-31] << 20 )
         SP Defense ( [0-31] << 25 )
         Bit 30 - IsEgg Flag
         Bit 31 - IsNicknamed Flag
         */
        /*
        [FieldOffset(0x74)]
        [MarshalAsAttribute(UnmanagedType.Struct)]
        private IVs ivs;
        #endregion
        #region Block C
        */
        /*
         Block C (0x78-0xAF)[edit]
         Offset	Contents
         0x78-0x8F	Latest NotOT Handler
         Updates Every Trade
         0x90-0x91	Null Terminator
         0x92	NotOT Gender
         0 - Male
         1 - Female
         0x93	Current Handler
         0 - OT
         1 - NotOT
         0x94-0x95	Geolocation 1 - (Region,Country)
         0x96-0x97	Geolocation 2 - (Region,Country)
         0x98-0x99	Geolocation 3 - (Region,Country)
         0x9A-0x9B	Geolocation 4 - (Region,Country)
         0x9C-0x9D	Geolocation 5 - (Region,Country)
         0x9E-0x9F	Unused
         0xA0-0xA1	Unused
         0xA2	NotOT Friendship
         0xA3	NotOT Affection
         0xA4	NotOT Memory Intensity
         0xA5	NotOT Memory Line
         0xA6	NotOT Memory Feeling
         0xA7	Unused
         0xA8-0xA9	NotOT Memory TextVar
         0xAA-0xAB	Unused
         0xAC-0xAD	Unused
         0xAE	Fullness
         0xAF	Enjoyment
         */

        #endregion
        #region Block D
        /*
         Block D (0xB0-0xE7)[edit]
         Offset	Contents
         0xB0-0xC7	OT Name
         0xC8-0xC9	Null Terminator
         0xCA	OT Friendship
         0xCB	OT Affection
         0xCC	OT Memory Intensity
         0xCD	OT Memory Line
         0xCE-0xCF	OT Memory TextVar
         0xD0	OT Memory Feeling
         0xD1-0xD3	Date Egg Received
         0xD4-0xD6	Date Met
         0xD7	Unknown / Unused
         0xD8-0xD9	Egg Location
         0xDA-0xDB	Met At Location
         0xDC	Pokéball
         0xDD	Bit 0-6 - Encounter Level
         Bit 7 - Female OT Gender
         0xDE	Encounter Type (Gen 4)
         0xDF	OT Game ID
         0xE0	Country ID
         0xE1	Region ID
         0xE2	3DS Region ID
         0xE3	OT Language ID
         0xE4-0xE7	Unused
         */

        #endregion
        /*
        [DisplayName("HP IV")]
        public uint HP_IV
        {
            get { return ivs.HP_IV; }
            set { ivs.HP_IV = value; }
        }
        [DisplayName("Attack IV")]
        public uint Attack_IV
        {
            get { return ivs.Attack_IV; }
            set { ivs.Attack_IV = value; }
        }
        [DisplayName("Defense IV")]
        public uint Defense_IV
        {
            get { return ivs.Defense_IV; }
            set { ivs.Defense_IV = value; }
        }
        [DisplayName("Special Attack IV")]
        public uint SpecialAttack_IV
        {
            get { return ivs.SpecialAttack_IV; }
            set { ivs.SpecialAttack_IV = value; }
        }
        [DisplayName("Special Defense IV")]
        public uint SpecialDefense_IV
        {
            get { return ivs.SpecialDefense_IV; }
            set { ivs.SpecialDefense_IV = value; }
        }
        [DisplayName("Speed IV")]
        public uint Speed_IV
        {
            get { return ivs.Speed_IV; }
            set { ivs.Speed_IV = value; }
        }
        [DisplayName("TEST7")]
        public bool Value7
        {
            get { return ivs.Value7; }
            set { ivs.Value7 = value; }
        }
        [DisplayName("TEST8")]
        public bool Value8
        {
            get { return ivs.Value8; }
            set { ivs.Value8 = value; }
        }
        public Pokemon()
        {
            ivs = new IVs();
        }
         */
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
    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class IVs
    {
        public IVs()
        {
            Data = 0u;
        }
        [FieldOffset(0)]
        [MarshalAsAttribute(UnmanagedType.U4)]
        internal uint Data;
        internal uint HP_IV
        {
            get { return (Data >> 00) & 0x1F; }
            set { Data = (Data & ~(0x1Fu << 00)) | (value & 0x1Fu) << 00; }
        }
        internal uint Attack_IV
        {
            get { return (Data >> 05) & 0x1F; }
            set { Data = (Data & ~(0x1Fu << 05)) | (value & 0x1Fu) << 05; }
        }
        internal uint Defense_IV
        {
            get { return (Data >> 10) & 0x1F; }
            set { Data = (Data & ~(0x1Fu << 10)) | (value & 0x1Fu) << 10; }
        }
        internal uint SpecialAttack_IV
        {
            get { return (Data >> 15) & 0x1F; }
            set { Data = (Data & ~(0x1Fu << 15)) | (value & 0x1Fu) << 15; }
        }
        internal uint SpecialDefense_IV
        {
            get { return (Data >> 20) & 0x1F; }
            set { Data = (Data & ~(0x1Fu << 20)) | (value & 0x1Fu) << 20; }
        }
        internal uint Speed_IV
        {
            get { return (Data >> 25) & 0x1F; }
            set { Data = (Data & ~(0x1Fu << 25)) | (value & 0x1Fu) << 25; }
        }
        internal bool Value7
        {
            get { return ((Data >> 30) & 0x01u) == 1; }
            set { Data = (Data & ~(0x01u << 30)) | (Convert.ToUInt32(value) & 0x01u) << 30; }
        }
        internal bool Value8
        {
            get { return ((Data >> 31) & 0x01u) == 1; }
            set { Data = (Data & ~(0x01u << 31)) | (Convert.ToUInt32(value) & 0x01u) << 31; }
        }
    }
    [StructLayout(LayoutKind.Explicit, Size = 1, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    internal class Forms
    {
        public Forms()
        {
            Data = 0;
        }
        [FieldOffset(0)]
        [MarshalAsAttribute(UnmanagedType.U1)]
        internal byte Data;
        internal bool fateful
        {
            get { return ((Data >> 0) & 0x1F) == 1; }
            set { Data = Convert.ToByte((Data & ~(0x1F << 0)) | (Convert.ToByte(value) & 0x1F) << 0); }
        }
        internal bool female
        {
            get { return ((Data >> 1) & 0x1F) == 1; }
            set { Data = Convert.ToByte((Data & ~(0x1F << 1)) | (Convert.ToByte(value) & 0x1F) << 1); }
        }
        internal bool genderless
        {
            get { return ((Data >> 2) & 0x1F) == 1; }
            set { Data = Convert.ToByte((Data & ~(0x1F << 2)) | (Convert.ToByte(value) & 0x1F) << 2); }
        }
        internal byte alternateforms
        {
            get { return Convert.ToByte((Data >> 3) & 0x1F); }
            set { Data = Convert.ToByte((Data & ~(0x1F << 3)) | (value & 0x1F) << 3); }
        }
    }
}
