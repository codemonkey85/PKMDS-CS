#region Using

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

#endregion Using

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class Pokemon
    {
        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 232)]
        internal byte[] data;

        internal uint EncryptionKey
        {
            get { return BitConverter.ToUInt32(data, 0x00); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x00, 4); }
        }

        internal ushort SanityPlaceholder
        {
            get { return BitConverter.ToUInt16(data, 0x04); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x04, 2); }
        }

        internal ushort Checksum
        {
            get { return BitConverter.ToUInt16(data, 0x06); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x06, 2); }
        }

        private ushort species
        {
            get { return BitConverter.ToUInt16(data, 0x08); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x08, 2); }
        }

        private ushort helditem
        {
            get { return BitConverter.ToUInt16(data, 0x0A); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x0A, 2); }
        }

        [DisplayName("Trainer ID")]
        public ushort OTID
        {
            get { return BitConverter.ToUInt16(data, 0x0C); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x0C, 2); }
        }

        [DisplayName("Trainer Secret ID")]
        public ushort OTSecretID
        {
            get { return BitConverter.ToUInt16(data, 0x0E); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x0E, 2); }
        }

        private uint exp
        {
            get { return BitConverter.ToUInt32(data, 0x10); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x10, 4); }
        }

        private byte ability
        {
            get { return data[0x14]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x14, 1); }
        }

        [DisplayName("Ability Number")]
        public byte AbilityNumber
        {
            get { return data[0x15]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x15, 1); }
        }

        [DisplayName("[Hits Remaining] on [Training Bag]")]
        public ushort HitsRemainingonTrainingBag
        {
            get { return BitConverter.ToUInt16(data, 0x16); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x16, 2); }
        }

        [DisplayName("Personality Value")]
        public uint PID
        {
            get { return BitConverter.ToUInt32(data, 0x18); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x18, 4); }
        }

        private byte nature
        {
            get { return data[0x1C]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x1C, 1); }
        }

        private byte forms
        {
            get { return data[0x1D]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x1D, 1); }
        }

        [DisplayName("HP Effort Value")]
        public byte HPEffortValue
        {
            get { return data[0x1E]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x1E, 1); }
        }

        [DisplayName("Attack Effort Value")]
        public byte AttackEffortValue
        {
            get { return data[0x1F]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x1F, 1); }
        }

        [DisplayName("Defense Effort Value")]
        public byte DefenseEffortValue
        {
            get { return data[0x20]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x20, 1); }
        }

        [DisplayName("Speed Effort Value")]
        public byte SpeedEffortValue
        {
            get { return data[0x21]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x21, 1); }
        }

        [DisplayName("SP Attack Effort Value")]
        public byte SpAttackEffortValue
        {
            get { return data[0x22]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x22, 1); }
        }

        [DisplayName("SP Defense Effort Value")]
        public byte SpDefenseEffortValue
        {
            get { return data[0x23]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x23, 1); }
        }

        [DisplayName("Contest Stat: Cool")]
        public byte ContestStatCool
        {
            get { return data[0x24]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x24, 1); }
        }

        [DisplayName("Contest Stat: Beauty")]
        public byte ContestStatBeauty
        {
            get { return data[0x25]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x25, 1); }
        }

        [DisplayName("Contest Stat: Cute")]
        public byte ContestStatCute
        {
            get { return data[0x26]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x26, 1); }
        }

        [DisplayName("Contest Stat: Smart")]
        public byte ContestStatSmart
        {
            get { return data[0x27]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x27, 1); }
        }

        [DisplayName("Contest Stat: Tough")]
        public byte ContestStatTough
        {
            get { return data[0x28]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x28, 1); }
        }

        [DisplayName("Contest Stat: Sheen")]
        public byte ContestStatSheen
        {
            get { return data[0x29]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x29, 1); }
        }

        private byte markings
        {
            get { return data[0x2A]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x2A, 1); }
        }

        [DisplayName("Pokérus")]
        public byte pokerus
        {
            get { return data[0x2B]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x2B, 1); }
        }

        private uint secretsupertrainingflag
        {
            get { return BitConverter.ToUInt32(data, 0x2C); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x2C, 4); }
        }

        //[DisplayName("Ribbons")] public byte[6] Ribbons { get {return ; } set {; } }
        //[DisplayName("Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0x36); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0x36,2); } }
        [DisplayName("Contest Memory Ribbon [Count]")]
        public byte ContestMemoryRibbonCount
        {
            get { return data[0x38]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x38, 1); }
        }

        [DisplayName("Battle Memory Ribbon [Count]")]
        public byte BattleMemoryRibbonCount
        {
            get { return data[0x39]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x39, 1); }
        }

        [DisplayName("Distribution Super Training Flags")]
        public byte DistributionSuperTrainingFlags
        {
            get { return data[0x3A]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x3A, 1); }
        }

        //[DisplayName("Unused")] public byte[5] Unused { get {return ; } set {; } }
        //[DisplayName("Nickname")] public byte[24] Nickname { get {return ; } set {; } }
        //[DisplayName("Null Terminator")] public ushort NullTerminator { get {return BitConverter.ToUInt16(data, 0x58); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0x58,2); } }
        [DisplayName("Move 1 ID")]
        public ushort move1id
        {
            get { return BitConverter.ToUInt16(data, 0x5A); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x5A, 2); }
        }

        [DisplayName("Move 2 ID")]
        public ushort move2id
        {
            get { return BitConverter.ToUInt16(data, 0x5C); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x5C, 2); }
        }

        [DisplayName("Move 3 ID")]
        public ushort move3id
        {
            get { return BitConverter.ToUInt16(data, 0x5E); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x5E, 2); }
        }

        [DisplayName("Move 4 ID")]
        public ushort move4id
        {
            get { return BitConverter.ToUInt16(data, 0x60); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x60, 2); }
        }

        [DisplayName("Move 1 Current PP")]
        public byte Move1CurrentPP
        {
            get { return data[0x62]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x62, 1); }
        }

        [DisplayName("Move 2 Current PP")]
        public byte Move2CurrentPP
        {
            get { return data[0x63]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x63, 1); }
        }

        [DisplayName("Move 3 Current PP")]
        public byte Move3CurrentPP
        {
            get { return data[0x64]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x64, 1); }
        }

        [DisplayName("Move 4 Current PP")]
        public byte Move4CurrentPP
        {
            get { return data[0x65]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x65, 1); }
        }

        private byte move1ppups { get { return data[0x66]; } set { data[0x66] = value; } }
        private byte move2ppups { get { return data[0x67]; } set { data[0x67] = value; } }
        private byte move3ppups { get { return data[0x68]; } set { data[0x68] = value; } }
        private byte move4ppups { get { return data[0x69]; } set { data[0x69] = value; } }

        [DisplayName("Relearn Move 1 ID")]
        public ushort relearnmove1id
        {
            get { return BitConverter.ToUInt16(data, 0x6A); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x6A, 2); }
        }

        [DisplayName("Relearn Move 2 ID")]
        public ushort relearnmove2id
        {
            get { return BitConverter.ToUInt16(data, 0x6C); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x6C, 2); }
        }

        [DisplayName("Relearn Move 3 ID")]
        public ushort relearnmove3id
        {
            get { return BitConverter.ToUInt16(data, 0x6E); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x6E, 2); }
        }

        [DisplayName("Relearn Move 4 ID")]
        public ushort relearnmove4id
        {
            get { return BitConverter.ToUInt16(data, 0x70); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x70, 2); }
        }

        [DisplayName("Secret Super Training Flag")]
        public byte SecretSuperTrainingFlag
        {
            get { return data[0x72]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x72, 1); }
        }

        //[DisplayName("Unused")] public byte Unused { get {return data[0x73]; } set {Array.Copy(BitConverter.GetBytes(value),0,data,0x73,1); } }
        [DisplayName("IVs")]
        internal uint ivs 
        { 
            get {return BitConverter.ToUInt32(data, 0x74); } 
            set {Array.Copy(BitConverter.GetBytes(value),0,data,0x74,4); }
        }
        //[DisplayName("Latest NotOT Handler Updates Every Trade")] public byte[24] LatestNotOTHandlerUpdatesEveryTrade { get {return ; } set {; } }
        //[DisplayName("Null Terminator")] public ushort NullTerminator { get {return BitConverter.ToUInt16(data, 0x90); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0x90,2); } }
        public byte lasttrainergender
        {
            get { return data[0x92]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x92, 1); }
        }

        public byte currenthandler
        {
            get { return data[0x93]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x93, 1); }
        }

        [DisplayName("Geolocation 1 - Region,Country")]
        public ushort Geolocation1RegionCountry
        {
            get { return BitConverter.ToUInt16(data, 0x94); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x94, 2); }
        }

        [DisplayName("Geolocation 2 - Region,Country")]
        public ushort Geolocation2RegionCountry
        {
            get { return BitConverter.ToUInt16(data, 0x96); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x96, 2); }
        }

        [DisplayName("Geolocation 3 - Region,Country")]
        public ushort Geolocation3RegionCountry
        {
            get { return BitConverter.ToUInt16(data, 0x98); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x98, 2); }
        }

        [DisplayName("Geolocation 4 - Region,Country")]
        public ushort Geolocation4RegionCountry
        {
            get { return BitConverter.ToUInt16(data, 0x9A); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x9A, 2); }
        }

        [DisplayName("Geolocation 5 - Region,Country")]
        public ushort Geolocation5RegionCountry
        {
            get { return BitConverter.ToUInt16(data, 0x9C); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0x9C, 2); }
        }

        //[DisplayName("Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0x9E); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0x9E,2); } }
        //[DisplayName("Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0xA0); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0xA0,2); } }
        [DisplayName("NotOT Friendship")]
        public byte NotOTFriendship
        {
            get { return data[0xA2]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xA2, 1); }
        }

        [DisplayName("NotOT Affection")]
        public byte NotOTAffection
        {
            get { return data[0xA3]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xA3, 1); }
        }

        [DisplayName("NotOT Memory Intensity")]
        public byte NotOTMemoryIntensity
        {
            get { return data[0xA4]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xA4, 1); }
        }

        [DisplayName("NotOT Memory Line")]
        public byte NotOTMemoryLine
        {
            get { return data[0xA5]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xA5, 1); }
        }

        [DisplayName("NotOT Memory Feeling")]
        public byte NotOTMemoryFeeling
        {
            get { return data[0xA6]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xA6, 1); }
        }

        //[DisplayName("Unused")] public byte Unused { get {return data[0xA7]; } set {Array.Copy(BitConverter.GetBytes(value),0,data,0xA7,1); } }
        [DisplayName("NotOT Memory TextVar")]
        public ushort NotOTMemoryTextVar
        {
            get { return BitConverter.ToUInt16(data, 0xA8); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xA8, 2); }
        }

        //[DisplayName("Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0xAA); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0xAA,2); } }
        //[DisplayName("Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0xAC); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0xAC,2); } }
        [DisplayName("Fullness")]
        public byte Fullness
        {
            get { return data[0xAE]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xAE, 1); }
        }

        [DisplayName("Enjoyment")]
        public byte Enjoyment
        {
            get { return data[0xAF]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xAF, 1); }
        }

        //[DisplayName("OT Name")] public byte[24] OTName { get {return ; } set {; } }
        //[DisplayName("Null Terminator")] public ushort NullTerminator { get {return BitConverter.ToUInt16(data, 0xC8); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0xC8,2); } }
        [DisplayName("OT Friendship")]
        public byte OTFriendship
        {
            get { return data[0xCA]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xCA, 1); }
        }

        [DisplayName("OT Affection")]
        public byte OTAffection
        {
            get
            { return data[0xCB]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xCB, 1); }
        }

        [DisplayName("OT Memory Intensity")]
        public byte OTMemoryIntensity
        {
            get { return data[0xCC]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xCC, 1); }
        }

        [DisplayName("OT Memory Line")]
        public byte OTMemoryLine
        {
            get { return data[0xCD]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xCD, 1); }
        }

        [DisplayName("OT Memory TextVar")]
        public ushort OTMemoryTextVar
        {
            get { return BitConverter.ToUInt16(data, 0xCE); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xCE, 2); }
        }

        [DisplayName("OT Memory Feeling")]
        public byte OTMemoryFeeling
        {
            get { return data[0xD0]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xD0, 1); }
        }

        private byte datemetyear { get { return data[0xD1]; } set { data[0xD1] = value; } }
        private byte datemetmonth { get { return data[0xD2]; } set { data[0xD2] = value; } }
        private byte datemetday { get { return data[0xD3]; } set { data[0xD3] = value; } }
        private byte eggmetyear { get { return data[0xD4]; } set { data[0xD4] = value; } }
        private byte eggmetmonth { get { return data[0xD5]; } set { data[0xD5] = value; } }
        private byte eggmetday { get { return data[0xD6]; } set { data[0xD6] = value; } }

        //[DisplayName("Date Egg Received")] public byte[3] DateEggReceived { get {return ; } set {; } }
        //[DisplayName("Date Met")] public byte[3] DateMet { get {return ; } set {; } }
        //[DisplayName("Unknown / Unused")] public byte UnknownUnused { get {return data[0xD7]; } set {Array.Copy(BitConverter.GetBytes(value),0,data,0xD7,1); } }
        [DisplayName("Egg Location")]
        public ushort egglocation
        {
            get { return BitConverter.ToUInt16(data, 0xD8); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xD8, 2); }
        }

        [DisplayName("Met At Location")]
        public ushort metlocation
        {
            get { return BitConverter.ToUInt16(data, 0xDA); }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xDA, 2); }
        }

        [DisplayName("Pokéball")]
        public byte pokeball
        {
            get { return data[0xDC]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xDC, 1); }
        }

        private byte metlevelotgender
        {
            get
            {
                return data[0xDD];
            }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xDD, 1); }
        }

        [DisplayName("Encounter Type Gen 4")]
        public byte EncounterTypeGen4
        {
            get { return data[0xDE]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xDE, 1); }
        }

        [DisplayName("OT Game ID")]
        public byte OTGameID
        {
            get { return data[0xDF]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xDF, 1); }
        }

        [DisplayName("Country ID")]
        public byte CountryID
        {
            get { return data[0xE0]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xE0, 1); }
        }

        [DisplayName("Region ID")]
        public byte RegionID
        {
            get { return data[0xE1]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xE1, 1); }
        }

        [DisplayName("3DS Region ID")]
        public byte _3DSRegionID
        {
            get { return data[0xE2]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xE2, 1); }
        }

        [DisplayName("OT Language ID")]
        public byte OTLanguageID
        {
            get { return data[0xE3]; }
            set { Array.Copy(BitConverter.GetBytes(value), 0, data, 0xE3, 1); }
        }

        //[DisplayName("Unused")] public uint Unused { get {return BitConverter.ToUInt32(data, 0xE4); } set {Array.Copy(BitConverter.GetBytes(value),0,data,0xE4,4); } }

        #region Pokemon Properties

        [DisplayName("HP IV")]
        public uint HP_IV
        {
            get { return (ivs >> 00) & 0x1F; }
            set
            {
                if (value > 31)
                {
                    HP_IV = 31;
                }
                else
                {
                    ivs = (ivs & ~(0x1Fu << 00)) | (value & 0x1Fu) << 00;
                }
            }
        }

        [DisplayName("Attack IV")]
        public uint Attack_IV
        {
            get { return (ivs >> 05) & 0x1F; }
            set
            {
                if (value > 31)
                {
                    Attack_IV = 31;
                }
                else
                {
                    ivs = (ivs & ~(0x1Fu << 05)) | (value & 0x1Fu) << 05;
                }
            }
        }

        [DisplayName("Defense IV")]
        public uint Defense_IV
        {
            get { return (ivs >> 10) & 0x1F; }
            set
            {
                if (value > 31)
                {
                    Defense_IV = 31;
                }
                else
                {
                    ivs = (ivs & ~(0x1Fu << 10)) | (value & 0x1Fu) << 10;
                }
            }
        }

        [DisplayName("Speed IV")]
        public uint Speed_IV
        {
            get { return (ivs >> 15) & 0x1F; }
            set
            {
                if (value > 31)
                {
                    Speed_IV = 31;
                }
                else
                {
                    ivs = (ivs & ~(0x1Fu << 15)) | (value & 0x1Fu) << 15;
                }
            }
        }

        [DisplayName("Special Attack IV")]
        public uint SpecialAttack_IV
        {
            get { return (ivs >> 20) & 0x1F; }
            set
            {
                if (value > 31)
                {
                    SpecialAttack_IV = 31;
                }
                else
                {
                    ivs = (ivs & ~(0x1Fu << 20)) | (value & 0x1Fu) << 20;
                }
            }
        }

        [DisplayName("Special Defense IV")]
        public uint SpecialDefense_IV
        {
            get { return (ivs >> 25) & 0x1F; }
            set
            {
                if (value > 31)
                {
                    SpecialDefense_IV = 31;
                }
                else
                {
                    ivs = (ivs & ~(0x1Fu << 25)) | (value & 0x1Fu) << 25;
                }
            }
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

        [DisplayName("Is Fateful Encounter")]
        public bool Fateful
        {
            get { return (forms & 0x01) == 0x01; }
            set { forms = Convert.ToByte(forms & ~(0x01u << 00) | (Convert.ToByte(value) & (0x01u)) << 00); }
        }

        [DisplayName("Is Female")]
        public bool Female
        {
            get { return (forms & 0x02) == 0x02; }
            set { forms = Convert.ToByte(forms & ~(0x01u << 01) | (Convert.ToByte(value) & (0x01u)) << 01); }
        }

        [DisplayName("Is Genderless")]
        public bool Genderless
        {
            get { return (forms & 0x04) == 0x04; }
            set { forms = Convert.ToByte(forms & ~(0x01u << 02) | (Convert.ToByte(value) & (0x01u)) << 02); }
        }

        [DisplayName("Form ID")]
        public byte FormID
        {
            get { return Convert.ToByte((forms >> 3) & 0x1F); }
            set { forms = Convert.ToByte((forms & ~(0x1F << 3)) | (value & 0x1F) << 3); }
        }

        [DisplayName("Circle")]
        public bool Circle
        {
            get { return (markings & 0x01) == 0x01; }
            set { markings = Convert.ToByte(markings & ~(0x01u << 00) | (Convert.ToByte(value) & (0x01u)) << 00); }
        }

        [DisplayName("Triangle")]
        public bool Triangle
        {
            get { return (markings & 0x02) == 0x02; }
            set { markings = Convert.ToByte(markings & ~(0x01u << 01) | (Convert.ToByte(value) & (0x01u)) << 01); }
        }

        [DisplayName("Square")]
        public bool Square
        {
            get { return (markings & 0x04) == 0x04; }
            set { markings = Convert.ToByte(markings & ~(0x01u << 02) | (Convert.ToByte(value) & (0x01u)) << 02); }
        }

        [DisplayName("Heart")]
        public bool Heart
        {
            get { return (markings & 0x08) == 0x08; }
            set { markings = Convert.ToByte(markings & ~(0x01u << 03) | (Convert.ToByte(value) & (0x01u)) << 03); }
        }

        [DisplayName("Star")]
        public bool Star
        {
            get { return (markings & 0x10) == 0x10; }
            set { markings = Convert.ToByte(markings & ~(0x01u << 04) | (Convert.ToByte(value) & (0x01u)) << 04); }
        }

        [DisplayName("Diamond")]
        public bool Diamond
        {
            get { return (markings & 0x20) == 0x20; }
            set { markings = Convert.ToByte(markings & ~(0x01u << 05) | (Convert.ToByte(value) & (0x01u)) << 05); }
        }

        [DisplayName("Species")]
        public Species Species
        {
            get
            {
                return Enum.IsDefined(typeof(Species), species)
                    ? (Species)species
                    : Species.NoSpecies;
            }
            set { species = (ushort)value; }
        }

        [DisplayName("Held Item")]
        public Items HeldItem
        {
            get
            {
                return Enum.IsDefined(typeof(Items), helditem)
                    ? (Items)helditem
                    : Items.NoItem;
            }
            set { helditem = (ushort)value; }
        }

        [DisplayName("Experience Points")]
        public uint EXP
        {
            get { return exp; }
            set { exp = value; }
        }

        [DisplayName("Ability")]
        public Abilities Ability
        {
            get
            {
                return Enum.IsDefined(typeof(Abilities), ability)
                    ? (Abilities)ability
                    : Abilities.NoAbility;
            }
            set { ability = (byte)value; }
        }

        [DisplayName("Nature")]
        public Natures Nature
        {
            get
            {
                return Enum.IsDefined(typeof(Natures), nature)
                    ? (Natures)nature
                    : Natures.Hardy;
            }
            set { nature = (byte)value; }
        }

        [DisplayName("Move 1")]
        public Moves Move1
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), move1id)
                    ? (Moves)move1id
                    : Moves.NoMove;
            }
            set { move1id = (ushort)value; }
        }

        [DisplayName("Move 2")]
        public Moves Move2
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), move2id)
                    ? (Moves)move2id
                    : Moves.NoMove;
            }
            set { move2id = (ushort)value; }
        }

        [DisplayName("Move 3")]
        public Moves Move3
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), move3id)
                    ? (Moves)move3id
                    : Moves.NoMove;
            }
            set { move3id = (ushort)value; }
        }

        [DisplayName("Move 4")]
        public Moves Move4
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), move4id)
                    ? (Moves)move4id
                    : Moves.NoMove;
            }
            set { move4id = (ushort)value; }
        }

        [DisplayName("Relearn Move 1")]
        public Moves RelearnMove1
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), relearnmove1id)
                    ? (Moves)relearnmove1id
                    : Moves.NoMove;
            }
            set { relearnmove1id = (ushort)value; }
        }

        [DisplayName("Relearn Move 2")]
        public Moves RelearnMove2
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), relearnmove2id)
                    ? (Moves)relearnmove2id
                    : Moves.NoMove;
            }
            set { relearnmove2id = (ushort)value; }
        }

        [DisplayName("Relearn Move 3")]
        public Moves RelearnMove3
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), relearnmove3id)
                    ? (Moves)relearnmove3id
                    : Moves.NoMove;
            }
            set { relearnmove3id = (ushort)value; }
        }

        [DisplayName("Relearn Move 4")]
        public Moves RelearnMove4
        {
            get
            {
                return Enum.IsDefined(typeof(Moves), relearnmove4id)
                    ? (Moves)relearnmove4id
                    : Moves.NoMove;
            }
            set { relearnmove4id = (ushort)value; }
        }

        //[DisplayName("Nickname")]
        //public string Nickname
        //{
        //    get { return nickname; }
        //    set { nickname = value.Length > 12 ? value.Substring(0, 12) : value; }
        //}

        //[DisplayName("Last Trainer Name")]
        //public string LastTrainerName
        //{
        //    get { return lasttrainername; }
        //    set { lasttrainername = value.Length > 12 ? value.Substring(0, 12) : value; }
        //}

        [DisplayName("Ball")]
        public Items Ball
        {
            get { return Extensions.BallToItem(pokeball); }
            set { pokeball = Extensions.ItemToBall(value); }
        }

        [DisplayName("Egg Location")]
        public Locations EggLocation
        {
            get
            {
                return Enum.IsDefined(typeof(Locations), egglocation)
                    ? (Locations)egglocation
                    : Locations.Mystery_Zone;
            }
            set { egglocation = (ushort)value; }
        }

        [DisplayName("Met Location")]
        public Locations MetLocation
        {
            get
            {
                return Enum.IsDefined(typeof(Locations), metlocation)
                    ? (Locations)metlocation
                    : Locations.Mystery_Zone;
            }
            set { metlocation = (ushort)value; }
        }

        [DisplayName("Egg Date")]
        public DateTime EggDate
        {
            get
            {
                try
                {
                    return new DateTime(eggmetyear + 2000, eggmetmonth, eggmetday);
                }
                catch
                {
                }
                return DateTime.MinValue;
            }
            set
            {
                if (value == null)
                {
                    eggmetyear = 0;
                    eggmetmonth = 0;
                    eggmetday = 0;
                }
                else
                {
                    eggmetyear = (byte)(value.Year - 2000);
                    eggmetmonth = (byte)value.Month;
                    eggmetday = (byte)value.Day;
                }
            }
        }

        [DisplayName("Met Date")]
        public DateTime MetDate
        {
            get
            {
                try
                {
                    return new DateTime(datemetyear + 2000, datemetmonth, datemetday);
                }
                catch
                {
                }
                return DateTime.MinValue;
            }
            set
            {
                if (value == null)
                {
                    datemetyear = 0;
                    datemetmonth = 0;
                    datemetday = 0;
                }
                else
                {
                    datemetyear = (byte)(value.Year - 2000);
                    datemetmonth = (byte)value.Month;
                    datemetday = (byte)value.Day;
                }
            }
        }

        //[DisplayName("Original Trainer Name")]
        //public string OTName
        //{
        //    get { return otname; }
        //    set { otname = value.Length > 12 ? value.Substring(0, 12) : value; }
        //}

        [DisplayName("Secret Super Training Available")]
        public bool SecretSuperTrainingAvailable
        {
            get { return secretsupertrainingflag != 0; }
            set { secretsupertrainingflag = value ? Convert.ToByte(1) : Convert.ToByte(0); }
        }

        [DisplayName("Met At Level")]
        public int MetLevel
        {
            get { return (metlevelotgender) & 0x7F; }
            set
            {
                metlevelotgender = Convert.ToByte(value > 127
                    ? (metlevelotgender & ~(0x7Fu)) | (127 & 0x7Fu)
                    : (metlevelotgender & ~(0x7Fu)) | (value & 0x7Fu));
            }
        }

        [DisplayName("OT Gender")]
        public Genders OTGender
        {
            get { return (((metlevelotgender) & 0x80) >> 7) == 1 ? Genders.Female : Genders.Male; }
            set
            {
                metlevelotgender =
                    Convert.ToByte((metlevelotgender & ~(0x01u << 7)) | (Convert.ToUInt32(value) & 0x01u) << 7);
            }
        }

        [DisplayName("Level")]
        public int Level
        {
            get { return DBTools.GetLevel(species, exp); }
            set { exp = DBTools.GetEXPAtLevel(species, value); }
        }

        [DisplayName("Form Name")]
        public string FormName
        {
            get { return DBTools.GetFormName(species, FormID, 9); }
        }

        [Browsable(false)]
        private string PokemonName
        {
            get { return DBTools.GetPokemonName(species, FormID, 9); }
        }

        [DisplayName("Current Trainer Is OT")]
        public bool CurrentTrainerIsOT
        {
            get { return currenthandler == 1; }
            set { currenthandler = value ? Convert.ToByte(1) : Convert.ToByte(0); }
        }

        [DisplayName("Last Trainer Gender")]
        public Genders LastTrainerGender
        {
            get { return (Genders)lasttrainergender; }
            set { lasttrainergender = (byte)value; }
        }

        [DisplayName("Move 1 PP Ups")]
        public byte Move1PPUps
        {
            get { return move1ppups; }
            set { move1ppups = value; }
        }

        [DisplayName("Move 2 PP Ups")]
        public byte Move2PPUps
        {
            get { return move2ppups; }
            set { move2ppups = value; }
        }

        [DisplayName("Move 3 PP Ups")]
        public byte Move3PPUps
        {
            get { return move3ppups; }
            set { move3ppups = value; }
        }

        [DisplayName("Move 4 PP Ups")]
        public byte Move4PPUps
        {
            get { return move4ppups; }
            set { move4ppups = value; }
        }

        [DisplayName("PokeRus Days")]
        public int PokeRusDays
        {
            get { return (pokerus & 0x0F) >> 0; }
            set
            {
                pokerus = Convert.ToByte((pokerus & ~(0x0Fu << 00)) | (value & 0x0Fu) << 00);
            }
        }

        [DisplayName("PokeRus Strain")]
        public int PokeRusStrain
        {
            get { return (pokerus & 0xF0) >> 4; }
            set
            {
                pokerus = Convert.ToByte((pokerus & ~(0x0Fu << 04)) | (value & 0x0Fu) << 04);
            }
        }

        [DisplayName("Gender")]
        public Genders Gender
        {
            get
            {
                if (this.Female) return Genders.Female;
                if (this.Genderless) return Genders.Genderless;
                return Genders.Male;
            }
        }

        [DisplayName("Box Icon")]
        public Image BoxIcon
        {
            get { return Images.GetPokemonImage(species, FormID, Gender); }
        }

        [DisplayName("HP")]
        public int HP
        {
            get
            {
                return DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[0];
            }
        }

        [DisplayName("Attack")]
        public int Attack
        {
            get
            {
                return DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[1];
            }
        }

        [DisplayName("Defense")]
        public int Defense
        {
            get
            {
                return DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[2];
            }
        }

        [DisplayName("Speed")]
        public int Speed
        {
            get
            {
                return DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[3];
            }
        }

        [DisplayName("Special Attack")]
        public int SpecialAttack
        {
            get
            {
                return DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[4];
            }
        }

        [DisplayName("Special Defense")]
        public int SpecialDefense
        {
            get
            {
                return DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[5];
            }
        }

        #endregion Pokemon Properties

        #region Other Properties

        public override string ToString()
        {
            return Species.EnumToString();
            //string pokemonname = PokemonName;
            //if (pokemonname == "")
            //{ return string.Format("{0}", Species.EnumToString()); }
            //else { return pokemonname; }
        }

        #endregion Other Properties

        #region Methods

        public void Encrypt()
        {
            PokePRNG.EncryptPokemon(this);
        }

        public void Decrypt()
        {
            PokePRNG.DecryptPokemon(this);
        }

        public void CloneFrom(Pokemon pokemon)
        {
            Array.Copy(pokemon.data, 0, this.data, 0, 232);
        }

        #endregion Methods
    }
}