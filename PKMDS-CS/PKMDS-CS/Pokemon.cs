#region Using

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

#endregion

namespace PKMDS_CS
{
    [StructLayout(LayoutKind.Explicit, Size = 0xE8, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class Pokemon
    {
        #region Unencrypted Bytes

        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.U4)]
        internal uint encryptionkey;

        [FieldOffset(0x04)]
        [MarshalAs(UnmanagedType.U2)]
        internal ushort sanity;

        [FieldOffset(0x06)]
        [MarshalAs(UnmanagedType.U2)]
        internal ushort checksum;

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
                return Enum.IsDefined(typeof(Items), item)
                    ? (Items)item
                    : Items.NoItem;
            }
            set { item = (ushort)value; }
        }

        [DisplayName("Trainer ID")]
        public ushort TrainerID
        {
            get { return otid; }
            set { otid = value; }
        }

        [DisplayName("Trainer Secret ID")]
        public ushort TrainerSID
        {
            get { return sid; }
            set { sid = value; }
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

        [DisplayName("Personality Value")]
        public uint PID
        {
            get { return pid; }
            set { pid = value; }
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

        [DisplayName("HP Effort")]
        public byte HPEffort
        {
            get { return hp_effort; }
            set { hp_effort = value; }
        }

        [DisplayName("Attack Effort")]
        public byte AttackEffort
        {
            get { return attack_effort; }
            set { attack_effort = value; }
        }

        [DisplayName("Defense Effort")]
        public byte DefenseEffort
        {
            get { return defense_effort; }
            set { defense_effort = value; }
        }

        [DisplayName("Speed Effort")]
        public byte SpeedEffort
        {
            get { return speed_effort; }
            set { speed_effort = value; }
        }

        [DisplayName("Special Attack Effort")]
        public byte SpAttackEffort
        {
            get { return spattack_effort; }
            set { spattack_effort = value; }
        }

        [DisplayName("Special Defense Effort")]
        public byte SpDefenseEffort
        {
            get { return spdefense_effort; }
            set { spdefense_effort = value; }
        }

        [DisplayName("Cool")]
        public byte Cool
        {
            get { return cool; }
            set { cool = value; }
        }

        [DisplayName("Beauty")]
        public byte Beauty
        {
            get { return beauty; }
            set { beauty = value; }
        }

        [DisplayName("Cute")]
        public byte Cute
        {
            get { return cute; }
            set { cute = value; }
        }

        [DisplayName("Smart")]
        public byte Smart
        {
            get { return smart; }
            set { smart = value; }
        }

        [DisplayName("Tough")]
        public byte Tough
        {
            get { return tough; }
            set { tough = value; }
        }

        [DisplayName("Sheen")]
        public byte Sheen
        {
            get { return sheen; }
            set { sheen = value; }
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

        [DisplayName("Nickname")]
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value.Length > 12 ? value.Substring(0, 12) : value; }
        }

        [DisplayName("Last Trainer Name")]
        public string LastTrainerName
        {
            get { return lasttrainername; }
            set { lasttrainername = value.Length > 12 ? value.Substring(0, 12) : value; }
        }

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
                    return new DateTime(eggyear + 2000, eggmonth, eggday);
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
                    eggyear = 0;
                    eggmonth = 0;
                    eggday = 0;
                }
                else
                {
                    eggyear = (byte)(value.Year - 2000);
                    eggmonth = (byte)value.Month;
                    eggday = (byte)value.Day;
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
                    return new DateTime(metyear + 2000, metmonth, metday);
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
                    metyear = 0;
                    metmonth = 0;
                    metday = 0;
                }
                else
                {
                    metyear = (byte)(value.Year - 2000);
                    metmonth = (byte)value.Month;
                    metday = (byte)value.Day;
                }
            }
        }

        [DisplayName("Original Trainer Name")]
        public string OTName
        {
            get { return otname; }
            set { otname = value.Length > 12 ? value.Substring(0, 12) : value; }
        }

        [DisplayName("Contest Memory Ribbon Count")]
        public byte ContestMemoryRibbonCount
        {
            get { return contestmemoryribbons; }
            set { contestmemoryribbons = value; }
        }

        [DisplayName("Battle Memory Ribbon Count")]
        public byte BattleMemoryRibbonCount
        {
            get { return battlememoryribbons; }
            set { battlememoryribbons = value; }
        }

        [DisplayName("3DS Region")]
        public byte TDSRegion
        {
            get { return tdsregion; }
            set { tdsregion = value; }
        }

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

        [DisplayName("Region ID")]
        public byte RegionID
        {
            get { return region; }
            set { region = value; }
        }

        [DisplayName("Ability Number")]
        public byte AbilityNum
        {
            get { return abilitynum; }
            set { abilitynum = value; }
        }

        [DisplayName("Country")]
        public byte Country
        {
            get { return country; }
            set { country = value; }
        }

        [DisplayName("Encounter Type")]
        public byte EncounterType
        {
            get { return encounter; }
            set { encounter = value; }
        }

        [DisplayName("Enjoyment")]
        public byte Enjoyment
        {
            get { return enjoyment; }
            set { enjoyment = value; }
        }

        [DisplayName("Fullness")]
        public byte Fullness
        {
            get { return fullness; }
            set { fullness = value; }
        }

        [DisplayName("Current Trainer Is OT")]
        public bool CurrentTrainerIsOT
        {
            get { return currenthandler == 1; }
            set { currenthandler = value ? Convert.ToByte(1) : Convert.ToByte(0); }
        }

        [DisplayName("Last Trainer Affection")]
        public byte LastTrainerAffection
        {
            get { return lasttraineraffection; }
            set { lasttraineraffection = value; }
        }

        [DisplayName("Last Trainer Friendship")]
        public byte LastTrainerFriendship
        {
            get { return lasttrainerfriendship; }
            set { lasttrainerfriendship = value; }
        }

        [DisplayName("Last Trainer Gender")]
        public Genders LastTrainerGender
        {
            get { return (Genders)lasttrainergender; }
            set { lasttrainergender = (byte)value; }
        }

        [DisplayName("Last Trainer Memory Feeling")]
        public byte LastTrainerMemoryFeeling
        {
            get { return lasttrainermemoryfeeling; }
            set { lasttrainermemoryfeeling = value; }
        }

        [DisplayName("Last Trainer Memory Intensity")]
        public byte LastTrainerMemoryIntensity
        {
            get { return lasttrainermemoryintensity; }
            set { lasttrainermemoryintensity = value; }
        }

        [DisplayName("Last Trainer Memory Line")]
        public byte LastTrainerMemoryLine
        {
            get { return lasttrainermemoryline; }
            set { lasttrainermemoryline = value; }
        }

        [DisplayName("Last Trainer Memory Text Var")]
        public ushort LastTrainerMemoryTextVar
        {
            get { return lasttrainermemorytext; }
            set { lasttrainermemorytext = value; }
        }

        [DisplayName("OT Affection")]
        public byte OTAffection
        {
            get { return otaffection; }
            set { otaffection = value; }
        }

        [DisplayName("OT Friendship")]
        public byte OTFriendship
        {
            get { return otfriendship; }
            set { otfriendship = value; }
        }

        [DisplayName("OT Game ID")]
        public byte OTGameID
        {
            get { return otgame; }
            set { otgame = value; }
        }

        [DisplayName("OT Language ID")]
        public byte OTLanguageID
        {
            get { return otlang; }
            set { otlang = value; }
        }

        [DisplayName("OT Memory Feeling")]
        public byte OTMemoryFeeling
        {
            get { return otmemoryfeeling; }
            set { otmemoryfeeling = value; }
        }

        [DisplayName("OT Memory Intensity")]
        public byte OTMemoryIntensity
        {
            get { return otmemoryintensity; }
            set { otmemoryintensity = value; }
        }

        [DisplayName("OT Memory Line")]
        public byte OTMemoryLine
        {
            get { return otmemoryline; }
            set { otmemoryline = value; }
        }

        [DisplayName("OT Memory Text Var")]
        public ushort OTMemoryTextVar
        {
            get { return otmemorytext; }
            set { otmemorytext = value; }
        }

        #endregion Pokemon Properties

        #region Other Properties

        public override string ToString()
        {
            string pokemonname = PokemonName;
            if (pokemonname == "")
            { return string.Format("{0}", Species.EnumToString()); }
            else { return pokemonname; }
        }

        #endregion Other Properties

        #region Methods

        internal void CloneFrom(Pokemon pokemon)
        {
            encryptionkey = pokemon.encryptionkey;
            sanity = pokemon.sanity;
            checksum = pokemon.checksum;
            species = pokemon.species;
            item = pokemon.item;
            otid = pokemon.otid;
            sid = pokemon.sid;
            exp = pokemon.exp;
            ability = pokemon.ability;
            abilitynum = pokemon.abilitynum;
            supertraining = pokemon.supertraining;
            pid = pokemon.pid;
            nature = pokemon.nature;
            forms = pokemon.forms;
            hp_effort = pokemon.hp_effort;
            attack_effort = pokemon.attack_effort;
            defense_effort = pokemon.defense_effort;
            speed_effort = pokemon.speed_effort;
            spattack_effort = pokemon.spattack_effort;
            spdefense_effort = pokemon.spdefense_effort;
            cool = pokemon.cool;
            beauty = pokemon.beauty;
            cute = pokemon.cute;
            smart = pokemon.smart;
            tough = pokemon.tough;
            sheen = pokemon.sheen;
            markings = pokemon.markings;
            pokerus = pokemon.pokerus;
            supertraininggoldmedals = pokemon.supertraininggoldmedals;
            ribbons = pokemon.ribbons;
            contestmemoryribbons = pokemon.contestmemoryribbons;
            battlememoryribbons = pokemon.battlememoryribbons;
            distributionsupertrainingflags = pokemon.distributionsupertrainingflags;
            nickname = pokemon.nickname;
            move1id = pokemon.move1id;
            move2id = pokemon.move2id;
            move3id = pokemon.move3id;
            move4id = pokemon.move4id;
            move1currentpp = pokemon.move1currentpp;
            move2currentpp = pokemon.move2currentpp;
            move3currentpp = pokemon.move3currentpp;
            move4currentpp = pokemon.move4currentpp;
            relearnmove1id = pokemon.relearnmove1id;
            relearnmove2id = pokemon.relearnmove2id;
            relearnmove3id = pokemon.relearnmove3id;
            relearnmove4id = pokemon.relearnmove4id;
            secretsupertrainingflag = pokemon.secretsupertrainingflag;
            ivs = pokemon.ivs;
            lasttrainername = pokemon.lasttrainername;
            lasttrainergender = pokemon.lasttrainergender;
            currenthandler = pokemon.currenthandler;
            location1 = pokemon.location1;
            location2 = pokemon.location2;
            location3 = pokemon.location3;
            location4 = pokemon.location4;
            location5 = pokemon.location5;
            lasttrainerfriendship = pokemon.lasttrainerfriendship;
            lasttraineraffection = pokemon.lasttraineraffection;
            lasttrainermemoryintensity = pokemon.lasttrainermemoryintensity;
            lasttrainermemoryline = pokemon.lasttrainermemoryline;
            lasttrainermemoryfeeling = pokemon.lasttrainermemoryfeeling;
            lasttrainermemorytext = pokemon.lasttrainermemorytext;
            fullness = pokemon.fullness;
            enjoyment = pokemon.enjoyment;
            otname = pokemon.otname;
            otfriendship = pokemon.otfriendship;
            otaffection = pokemon.otaffection;
            otmemoryintensity = pokemon.otmemoryintensity;
            otmemoryline = pokemon.otmemoryline;
            otmemorytext = pokemon.otmemorytext;
            otmemoryfeeling = pokemon.otmemoryfeeling;
            eggyear = pokemon.eggyear;
            eggmonth = pokemon.eggmonth;
            eggday = pokemon.eggday;
            metyear = pokemon.metyear;
            metmonth = pokemon.metmonth;
            metday = pokemon.metday;
            egglocation = pokemon.egglocation;
            metlocation = pokemon.metlocation;
            pokeball = pokemon.pokeball;
            metlevelotgender = pokemon.metlevelotgender;
            encounter = pokemon.encounter;
            otgame = pokemon.otgame;
            country = pokemon.country;
            region = pokemon.region;
            tdsregion = pokemon.tdsregion;
            otlang = pokemon.otlang;
        }

        #endregion
    }
}