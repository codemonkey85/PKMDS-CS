﻿namespace PKMDS_CS;

internal enum Offsets
{
    NicknameOffset = 0x40,
    LastTrainerNameOffset = 0x78,
    OTNameOffset = 0xB0
}

public enum Consts
{
    NameMaxLength = 24
}

[StructLayout(LayoutKind.Explicit, Pack = 1, CharSet = CharSet.Unicode)]
[Serializable]
public class Pokemon : IEquatable<Pokemon>, IComparable<Pokemon>
{
    [FieldOffset(0x00)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 232)]
    internal byte[] data;

    public Pokemon() => data = new byte[232];

    public int SortBySpeciesAscending(string name1, string name2) => name1.CompareTo(name2);

    public override bool Equals(object obj)
    {
        var objAsPart = obj as Pokemon;
        return objAsPart != null && Equals(objAsPart);
    }

    public int CompareTo(Pokemon comparePokemon) => comparePokemon == null ? 1 : comparePokemon.Species == Species.NoSpecies ? 0 : Species.CompareTo(comparePokemon.Species);

    public override int GetHashCode() => string.Format("{0}-{1}-{2}-{3}", Checksum, PID, EncryptionKey, species).GetHashCode();

    public bool Equals(Pokemon other) => other != null && data.SequenceEqual(other.data);

    public static bool operator ==(Pokemon a, Pokemon b) => ReferenceEquals(a, b) || a is not null && b is not null && a.data.SequenceEqual(b.data);

    public static bool operator !=(Pokemon a, Pokemon b) => !(a == b);

    public bool Equals(Species other) => Species == other;

    public static bool operator ==(Pokemon a, Species b) => a is not null && a.Species == b;

    public static bool operator !=(Pokemon a, Species b) => !(a == b);

    public static void Swap(Pokemon a, Pokemon b)
    {
        var c = new Pokemon();
        c.CloneFrom(a);
        a.CloneFrom(b);
        b.CloneFrom(c);
    }

    internal uint EncryptionKey
    {
        get => BitConverter.ToUInt32(data, 0x00);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x00, 4);
    }

    internal ushort SanityPlaceholder
    {
        get => BitConverter.ToUInt16(data, 0x04);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x04, 2);
    }

    internal ushort Checksum
    {
        get => BitConverter.ToUInt16(data, 0x06);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x06, 2);
    }

    private ushort species
    {
        get => BitConverter.ToUInt16(data, 0x08);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x08, 2);
    }

    private ushort helditem
    {
        get => BitConverter.ToUInt16(data, 0x0A);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x0A, 2);
    }

    [DisplayName(@"Trainer ID")]
    public ushort OTID
    {
        get => BitConverter.ToUInt16(data, 0x0C);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x0C, 2);
    }

    [DisplayName(@"Trainer Secret ID")]
    public ushort OTSecretID
    {
        get => BitConverter.ToUInt16(data, 0x0E);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x0E, 2);
    }

    private uint exp
    {
        get => BitConverter.ToUInt32(data, 0x10);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x10, 4);
    }

    private byte ability
    {
        get => data[0x14];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x14, 1);
    }

    [DisplayName(@"Ability Number")]
    public byte AbilityNumber
    {
        get => data[0x15];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x15, 1);
    }

    [DisplayName(@"[Hits Remaining] on [Training Bag]")]
    public ushort HitsRemainingonTrainingBag
    {
        get => BitConverter.ToUInt16(data, 0x16);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x16, 2);
    }

    [DisplayName(@"Personality Value")]
    public uint PID
    {
        get => BitConverter.ToUInt32(data, 0x18);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x18, 4);
    }

    private byte nature
    {
        get => data[0x1C];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x1C, 1);
    }

    private byte forms
    {
        get => data[0x1D];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x1D, 1);
    }

    [DisplayName(@"HP Effort Value")]
    public byte HPEffortValue
    {
        get => data[0x1E];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x1E, 1);
    }

    [DisplayName(@"Attack Effort Value")]
    public byte AttackEffortValue
    {
        get => data[0x1F];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x1F, 1);
    }

    [DisplayName(@"Defense Effort Value")]
    public byte DefenseEffortValue
    {
        get => data[0x20];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x20, 1);
    }

    [DisplayName(@"Speed Effort Value")]
    public byte SpeedEffortValue
    {
        get => data[0x21];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x21, 1);
    }

    [DisplayName(@"SP Attack Effort Value")]
    public byte SpAttackEffortValue
    {
        get => data[0x22];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x22, 1);
    }

    [DisplayName(@"SP Defense Effort Value")]
    public byte SpDefenseEffortValue
    {
        get => data[0x23];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x23, 1);
    }

    [DisplayName(@"Contest Stat: Cool")]
    public byte ContestStatCool
    {
        get => data[0x24];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x24, 1);
    }

    [DisplayName(@"Contest Stat: Beauty")]
    public byte ContestStatBeauty
    {
        get => data[0x25];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x25, 1);
    }

    [DisplayName(@"Contest Stat: Cute")]
    public byte ContestStatCute
    {
        get => data[0x26];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x26, 1);
    }

    [DisplayName(@"Contest Stat: Smart")]
    public byte ContestStatSmart
    {
        get => data[0x27];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x27, 1);
    }

    [DisplayName(@"Contest Stat: Tough")]
    public byte ContestStatTough
    {
        get => data[0x28];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x28, 1);
    }

    [DisplayName(@"Contest Stat: Sheen")]
    public byte ContestStatSheen
    {
        get => data[0x29];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x29, 1);
    }

    private byte markings
    {
        get => data[0x2A];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x2A, 1);
    }

    [DisplayName(@"Pokérus")]
    public byte pokerus
    {
        get => data[0x2B];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x2B, 1);
    }

    private uint secretsupertrainingflag
    {
        get => BitConverter.ToUInt32(data, 0x2C);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x2C, 4);
    }

    //[DisplayName(@"Ribbons")] public byte[6] Ribbons { get {return ; } set {; } }
    //[DisplayName(@"Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0x36); } set {Array.Copy(Extensions.GetBytes(value),0,data,0x36,2); } }
    [DisplayName(@"Contest Memory Ribbon [Count]")]
    public byte ContestMemoryRibbonCount
    {
        get => data[0x38];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x38, 1);
    }

    [DisplayName(@"Battle Memory Ribbon [Count]")]
    public byte BattleMemoryRibbonCount
    {
        get => data[0x39];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x39, 1);
    }

    [DisplayName(@"Distribution Super Training Flags")]
    public byte DistributionSuperTrainingFlags
    {
        get => data[0x3A];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x3A, 1);
    }

    [DisplayName(@"Move 1 ID")]
    public ushort move1id
    {
        get => BitConverter.ToUInt16(data, 0x5A);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x5A, 2);
    }

    [DisplayName(@"Move 2 ID")]
    public ushort move2id
    {
        get => BitConverter.ToUInt16(data, 0x5C);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x5C, 2);
    }

    [DisplayName(@"Move 3 ID")]
    public ushort move3id
    {
        get => BitConverter.ToUInt16(data, 0x5E);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x5E, 2);
    }

    [DisplayName(@"Move 4 ID")]
    public ushort move4id
    {
        get => BitConverter.ToUInt16(data, 0x60);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x60, 2);
    }

    [DisplayName(@"Move 1 Current PP")]
    public byte Move1CurrentPP
    {
        get => data[0x62];
        set => Array.Copy(Extensions.GetBytes(value > 255u ? 255u : value < 0u ? 0u : value), 0, data, 0x62, 1);
    }

    [DisplayName(@"Move 2 Current PP")]
    public byte Move2CurrentPP
    {
        get => data[0x63];
        set => Array.Copy(Extensions.GetBytes(value > 255u ? 255u : value < 0u ? 0u : value), 0, data, 0x63, 1);
    }

    [DisplayName(@"Move 3 Current PP")]
    public byte Move3CurrentPP
    {
        get => data[0x64];
        set => Array.Copy(Extensions.GetBytes(value > 255u ? 255u : value < 0u ? 0u : value), 0, data, 0x64, 1);
    }

    [DisplayName(@"Move 4 Current PP")]
    public byte Move4CurrentPP
    {
        get => data[0x65];
        set => Array.Copy(Extensions.GetBytes(value > 255u ? 255u : value < 0u ? 0u : value), 0, data, 0x65, 1);
    }

    private byte move1ppups
    {
        get => data[0x66];
        set => data[0x66] = value;
    }

    private byte move2ppups
    {
        get => data[0x67];
        set => data[0x67] = value;
    }

    private byte move3ppups
    {
        get => data[0x68];
        set => data[0x68] = value;
    }

    private byte move4ppups
    {
        get => data[0x69];
        set => data[0x69] = value;
    }

    [DisplayName(@"Relearn Move 1 ID")]
    public ushort relearnmove1id
    {
        get => BitConverter.ToUInt16(data, 0x6A);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x6A, 2);
    }

    [DisplayName(@"Relearn Move 2 ID")]
    public ushort relearnmove2id
    {
        get => BitConverter.ToUInt16(data, 0x6C);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x6C, 2);
    }

    [DisplayName(@"Relearn Move 3 ID")]
    public ushort relearnmove3id
    {
        get => BitConverter.ToUInt16(data, 0x6E);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x6E, 2);
    }

    [DisplayName(@"Relearn Move 4 ID")]
    public ushort relearnmove4id
    {
        get => BitConverter.ToUInt16(data, 0x70);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x70, 2);
    }

    public List<MovesObject> Moves
    {
        get
        {
            var pokemonMoves = new List<MovesObject>
            {
                new MovesObject(Move1)
                {
                    CurrentPP = Move1CurrentPP,
                    PPUps = Move1PPUps
                },
                new MovesObject(Move2)
                {
                    CurrentPP = Move2CurrentPP,
                    PPUps = Move2PPUps
                },
                new MovesObject(Move3)
                {
                    CurrentPP = Move3CurrentPP,
                    PPUps = Move3PPUps
                },
                new MovesObject(Move4)
                {
                    CurrentPP = Move4CurrentPP,
                    PPUps = Move4PPUps
                }
            };
            return pokemonMoves;
        }
        set
        {
            if (value.Count == 0)
            {
                throw new Exception(string.Format("The Pokémon {0} must have at least one move!", ToString()));
            }

            if (value.Count >= 1)
            {
                Move1 = value[0].Value;
                Move1CurrentPP = value[0].CurrentPP;
                Move1PPUps = value[0].PPUps;
            }
            if (value.Count >= 2)
            {
                Move2 = value[1].Value;
                Move2CurrentPP = value[1].CurrentPP;
                Move2PPUps = value[1].PPUps;
            }
            if (value.Count >= 3)
            {
                Move3 = value[2].Value;
                Move3CurrentPP = value[2].CurrentPP;
                Move3PPUps = value[2].PPUps;
            }
            if (value.Count >= 4)
            {
                Move4 = value[3].Value;
                Move4CurrentPP = value[3].CurrentPP;
                Move4PPUps = value[3].PPUps;
            }
        }
    }

    public List<MovesObject> RelearnableMoves
    {
        get
        {
            var pokemonRelearnableMoves = new List<MovesObject>
            {
                new MovesObject(RelearnMove1),
                new MovesObject(RelearnMove2),
                new MovesObject(RelearnMove3),
                new MovesObject(RelearnMove4)
            };
            return pokemonRelearnableMoves;
        }
        set
        {
            if (value.Count >= 1)
            {
                RelearnMove1 = value[0].Value;
            }

            if (value.Count >= 2)
            {
                RelearnMove2 = value[1].Value;
            }

            if (value.Count >= 3)
            {
                RelearnMove3 = value[2].Value;
            }

            if (value.Count >= 4)
            {
                RelearnMove4 = value[3].Value;
            }
        }
    }

    [DisplayName(@"Secret Super Training Flag")]
    public byte SecretSuperTrainingFlag
    {
        get => data[0x72];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x72, 1);
    }

    //[DisplayName(@"Unused")] public byte Unused { get {return data[0x73]; } set {Array.Copy(Extensions.GetBytes(value),0,data,0x73,1); } }
    [DisplayName(@"IVs")]
    internal uint ivs
    {
        get => BitConverter.ToUInt32(data, 0x74);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x74, 4);
    }

    public byte lasttrainergender
    {
        get => data[0x92];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x92, 1);
    }

    public byte currenthandler
    {
        get => data[0x93];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x93, 1);
    }

    [DisplayName(@"Geolocation 1 - Region,Country")]
    public ushort Geolocation1RegionCountry
    {
        get => BitConverter.ToUInt16(data, 0x94);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x94, 2);
    }

    [DisplayName(@"Geolocation 2 - Region,Country")]
    public ushort Geolocation2RegionCountry
    {
        get => BitConverter.ToUInt16(data, 0x96);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x96, 2);
    }

    [DisplayName(@"Geolocation 3 - Region,Country")]
    public ushort Geolocation3RegionCountry
    {
        get => BitConverter.ToUInt16(data, 0x98);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x98, 2);
    }

    [DisplayName(@"Geolocation 4 - Region,Country")]
    public ushort Geolocation4RegionCountry
    {
        get => BitConverter.ToUInt16(data, 0x9A);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x9A, 2);
    }

    [DisplayName(@"Geolocation 5 - Region,Country")]
    public ushort Geolocation5RegionCountry
    {
        get => BitConverter.ToUInt16(data, 0x9C);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0x9C, 2);
    }

    //[DisplayName(@"Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0x9E); } set {Array.Copy(Extensions.GetBytes(value),0,data,0x9E,2); } }
    //[DisplayName(@"Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0xA0); } set {Array.Copy(Extensions.GetBytes(value),0,data,0xA0,2); } }
    [DisplayName(@"NotOT Friendship")]
    public byte NotOTFriendship
    {
        get => data[0xA2];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xA2, 1);
    }

    [DisplayName(@"NotOT Affection")]
    public byte NotOTAffection
    {
        get => data[0xA3];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xA3, 1);
    }

    [DisplayName(@"NotOT Memory Intensity")]
    public byte NotOTMemoryIntensity
    {
        get => data[0xA4];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xA4, 1);
    }

    [DisplayName(@"NotOT Memory Line")]
    public byte NotOTMemoryLine
    {
        get => data[0xA5];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xA5, 1);
    }

    [DisplayName(@"NotOT Memory Feeling")]
    public byte NotOTMemoryFeeling
    {
        get => data[0xA6];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xA6, 1);
    }

    //[DisplayName(@"Unused")] public byte Unused { get {return data[0xA7]; } set {Array.Copy(Extensions.GetBytes(value),0,data,0xA7,1); } }
    [DisplayName(@"NotOT Memory TextVar")]
    public ushort NotOTMemoryTextVar
    {
        get => BitConverter.ToUInt16(data, 0xA8);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xA8, 2);
    }

    //[DisplayName(@"Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0xAA); } set {Array.Copy(Extensions.GetBytes(value),0,data,0xAA,2); } }
    //[DisplayName(@"Unused")] public ushort Unused { get {return BitConverter.ToUInt16(data, 0xAC); } set {Array.Copy(Extensions.GetBytes(value),0,data,0xAC,2); } }
    [DisplayName(@"Fullness")]
    public byte Fullness
    {
        get => data[0xAE];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xAE, 1);
    }

    [DisplayName(@"Enjoyment")]
    public byte Enjoyment
    {
        get => data[0xAF];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xAF, 1);
    }

    [DisplayName(@"OT Friendship")]
    public byte OTFriendship
    {
        get => data[0xCA];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xCA, 1);
    }

    [DisplayName(@"OT Affection")]
    public byte OTAffection
    {
        get => data[0xCB];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xCB, 1);
    }

    [DisplayName(@"OT Memory Intensity")]
    public byte OTMemoryIntensity
    {
        get => data[0xCC];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xCC, 1);
    }

    [DisplayName(@"OT Memory Line")]
    public byte OTMemoryLine
    {
        get => data[0xCD];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xCD, 1);
    }

    [DisplayName(@"OT Memory TextVar")]
    public ushort OTMemoryTextVar
    {
        get => BitConverter.ToUInt16(data, 0xCE);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xCE, 2);
    }

    [DisplayName(@"OT Memory Feeling")]
    public byte OTMemoryFeeling
    {
        get => data[0xD0];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xD0, 1);
    }

    private byte datemetyear
    {
        get => data[0xD1];
        set => data[0xD1] = value;
    }

    private byte datemetmonth
    {
        get => data[0xD2];
        set => data[0xD2] = value;
    }

    private byte datemetday
    {
        get => data[0xD3];
        set => data[0xD3] = value;
    }

    private byte eggmetyear
    {
        get => data[0xD4];
        set => data[0xD4] = value;
    }

    private byte eggmetmonth
    {
        get => data[0xD5];
        set => data[0xD5] = value;
    }

    private byte eggmetday
    {
        get => data[0xD6];
        set => data[0xD6] = value;
    }

    //[DisplayName(@"Date Egg Received")] public byte[3] DateEggReceived { get {return ; } set {; } }
    //[DisplayName(@"Date Met")] public byte[3] DateMet { get {return ; } set {; } }
    //[DisplayName(@"Unknown / Unused")] public byte UnknownUnused { get {return data[0xD7]; } set {Array.Copy(Extensions.GetBytes(value),0,data,0xD7,1); } }
    [DisplayName(@"Egg Location")]
    public ushort egglocation
    {
        get => BitConverter.ToUInt16(data, 0xD8);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xD8, 2);
    }

    [DisplayName(@"Met At Location")]
    public ushort metlocation
    {
        get => BitConverter.ToUInt16(data, 0xDA);
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xDA, 2);
    }

    [DisplayName(@"Pokéball")]
    public byte pokeball
    {
        get => data[0xDC];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xDC, 1);
    }

    private byte metlevelotgender
    {
        get => data[0xDD];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xDD, 1);
    }

    [DisplayName(@"Encounter Type Gen 4")]
    public byte EncounterTypeGen4
    {
        get => data[0xDE];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xDE, 1);
    }

    [DisplayName(@"OT Game ID")]
    public byte OTGameID
    {
        get => data[0xDF];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xDF, 1);
    }

    [DisplayName(@"Country ID")]
    public byte CountryID
    {
        get => data[0xE0];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xE0, 1);
    }

    [DisplayName(@"Region ID")]
    public byte RegionID
    {
        get => data[0xE1];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xE1, 1);
    }

    [DisplayName(@"3DS Region ID")]
    public byte _3DSRegionID
    {
        get => data[0xE2];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xE2, 1);
    }

    [DisplayName(@"OT Language ID")]
    public byte OTLanguageID
    {
        get => data[0xE3];
        set => Array.Copy(Extensions.GetBytes(value), 0, data, 0xE3, 1);
    }

    //[DisplayName(@"Unused")] public uint Unused { get {return BitConverter.ToUInt32(data, 0xE4); } set {Array.Copy(Extensions.GetBytes(value),0,data,0xE4,4); } }

    #region Pokemon Properties

    [DisplayName(@"HP IV")]
    public uint HP_IV
    {
        get => (ivs >> 00) & 0x1F;
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

    [DisplayName(@"Attack IV")]
    public uint Attack_IV
    {
        get => (ivs >> 05) & 0x1F;
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

    [DisplayName(@"Defense IV")]
    public uint Defense_IV
    {
        get => (ivs >> 10) & 0x1F;
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

    [DisplayName(@"Speed IV")]
    public uint Speed_IV
    {
        get => (ivs >> 15) & 0x1F;
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

    [DisplayName(@"Special Attack IV")]
    public uint SpecialAttack_IV
    {
        get => (ivs >> 20) & 0x1F;
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

    [DisplayName(@"Special Defense IV")]
    public uint SpecialDefense_IV
    {
        get => (ivs >> 25) & 0x1F;
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

    [DisplayName(@"Is Egg")]
    public bool IsEgg
    {
        get => ((ivs >> 30) & 0x01u) == 1;
        set => ivs = (ivs & ~(0x01u << 30)) | (Convert.ToUInt32(value) & 0x01u) << 30;
    }

    [DisplayName(@"Is Nicknamed")]
    public bool IsNicknamed
    {
        get => ((ivs >> 31) & 0x01u) == 1;
        set => ivs = (ivs & ~(0x01u << 31)) | (Convert.ToUInt32(value) & 0x01u) << 31;
    }

    [DisplayName(@"Is Fateful Encounter")]
    public bool Fateful
    {
        get => (forms & 0x01) == 0x01;
        set => forms = Convert.ToByte(forms & ~(0x01u << 00) | (Convert.ToByte(value) & (0x01u)) << 00);
    }

    [DisplayName(@"Is Female")]
    public bool Female
    {
        get => (forms & 0x02) == 0x02;
        set => forms = Convert.ToByte(forms & ~(0x01u << 01) | (Convert.ToByte(value) & (0x01u)) << 01);
    }

    [DisplayName(@"Is Genderless")]
    public bool Genderless
    {
        get => (forms & 0x04) == 0x04;
        set => forms = Convert.ToByte(forms & ~(0x01u << 02) | (Convert.ToByte(value) & (0x01u)) << 02);
    }

    [DisplayName(@"Form ID")]
    public byte FormID
    {
        get => Convert.ToByte((forms >> 3) & 0x1F);
        set => forms = Convert.ToByte((forms & ~(0x1F << 3)) | (value & 0x1F) << 3);
    }

    [DisplayName(@"Circle")]
    public bool Circle
    {
        get => (markings & 0x01) == 0x01;
        set => markings = Convert.ToByte(markings & ~(0x01u << 00) | (Convert.ToByte(value) & (0x01u)) << 00);
    }

    [DisplayName(@"Triangle")]
    public bool Triangle
    {
        get => (markings & 0x02) == 0x02;
        set => markings = Convert.ToByte(markings & ~(0x01u << 01) | (Convert.ToByte(value) & (0x01u)) << 01);
    }

    [DisplayName(@"Square")]
    public bool Square
    {
        get => (markings & 0x04) == 0x04;
        set => markings = Convert.ToByte(markings & ~(0x01u << 02) | (Convert.ToByte(value) & (0x01u)) << 02);
    }

    [DisplayName(@"Heart")]
    public bool Heart
    {
        get => (markings & 0x08) == 0x08;
        set => markings = Convert.ToByte(markings & ~(0x01u << 03) | (Convert.ToByte(value) & (0x01u)) << 03);
    }

    [DisplayName(@"Star")]
    public bool Star
    {
        get => (markings & 0x10) == 0x10;
        set => markings = Convert.ToByte(markings & ~(0x01u << 04) | (Convert.ToByte(value) & (0x01u)) << 04);
    }

    [DisplayName(@"Diamond")]
    public bool Diamond
    {
        get => (markings & 0x20) == 0x20;
        set => markings = Convert.ToByte(markings & ~(0x01u << 05) | (Convert.ToByte(value) & (0x01u)) << 05);
    }

    [DisplayName(@"Species")]
    public Species Species
    {
        get => Enum.IsDefined(typeof(Species), species)
                ? (Species)species
                : Species.NoSpecies;
        set => species = (ushort)value;
    }

    [DisplayName(@"Held Item")]
    public Items HeldItem
    {
        get => Enum.IsDefined(typeof(Items), helditem)
                ? (Items)helditem
                : Items.NoItem;
        set => helditem = (ushort)value;
    }

    [DisplayName(@"Experience Points")]
    public uint EXP
    {
        get => exp;
        set => exp = value;
    }

    [DisplayName(@"Ability")]
    public Abilities Ability
    {
        get => Enum.IsDefined(typeof(Abilities), ability)
                ? (Abilities)ability
                : Abilities.NoAbility;
        set => ability = (byte)value;
    }

    [DisplayName(@"Nature")]
    public Natures Nature
    {
        get => Enum.IsDefined(typeof(Natures), nature)
                ? (Natures)nature
                : Natures.Hardy;
        set => nature = (byte)value;
    }

    [DisplayName(@"Move 1")]
    public Moves Move1
    {
        get => Enum.IsDefined(typeof(Moves), move1id)
                ? (Moves)move1id
                : PKMDS_CS.Moves.NoMove;
        set
        {
            if (value == PKMDS_CS.Moves.NoMove)
            {
                throw new Exception(string.Format("The Pokémon {0}'s first move cannot be 'No Move'!", ToString()));
            }

            move1id = (ushort)value;
        }
    }

    [DisplayName(@"Move 2")]
    public Moves Move2
    {
        get => Enum.IsDefined(typeof(Moves), move2id)
                ? (Moves)move2id
                : PKMDS_CS.Moves.NoMove;
        set => move2id = (ushort)value;
    }

    [DisplayName(@"Move 3")]
    public Moves Move3
    {
        get => Enum.IsDefined(typeof(Moves), move3id)
                ? (Moves)move3id
                : PKMDS_CS.Moves.NoMove;
        set => move3id = (ushort)value;
    }

    [DisplayName(@"Move 4")]
    public Moves Move4
    {
        get => Enum.IsDefined(typeof(Moves), move4id)
                ? (Moves)move4id
                : PKMDS_CS.Moves.NoMove;
        set => move4id = (ushort)value;
    }

    [DisplayName(@"Relearn Move 1")]
    public Moves RelearnMove1
    {
        get => Enum.IsDefined(typeof(Moves), relearnmove1id)
                ? (Moves)relearnmove1id
                : PKMDS_CS.Moves.NoMove;
        set => relearnmove1id = (ushort)value;
    }

    [DisplayName(@"Relearn Move 2")]
    public Moves RelearnMove2
    {
        get => Enum.IsDefined(typeof(Moves), relearnmove2id)
                ? (Moves)relearnmove2id
                : PKMDS_CS.Moves.NoMove;
        set => relearnmove2id = (ushort)value;
    }

    [DisplayName(@"Relearn Move 3")]
    public Moves RelearnMove3
    {
        get => Enum.IsDefined(typeof(Moves), relearnmove3id)
                ? (Moves)relearnmove3id
                : PKMDS_CS.Moves.NoMove;
        set => relearnmove3id = (ushort)value;
    }

    [DisplayName(@"Relearn Move 4")]
    public Moves RelearnMove4
    {
        get => Enum.IsDefined(typeof(Moves), relearnmove4id)
                ? (Moves)relearnmove4id
                : PKMDS_CS.Moves.NoMove;
        set => relearnmove4id = (ushort)value;
    }

    [DisplayName(@"Nickname")]
    public string Nickname
    {
        get => Encoding.Unicode.GetString(data, (int)Offsets.NicknameOffset, (int)Consts.NameMaxLength);
        set
        {
            var sdata = Encoding.Unicode.GetBytes(value);
            var length = sdata.Length > (int)Consts.NameMaxLength ? (int)Consts.NameMaxLength : sdata.Length;
            Array.Clear(data, (int)Offsets.NicknameOffset, (int)Consts.NameMaxLength);
            Array.Copy(sdata, 0, data, (int)Offsets.NicknameOffset, length);
        }
    }

    [DisplayName(@"Last Trainer Name")]
    public string LastTrainerName
    {
        get => Encoding.Unicode.GetString(data, (int)Offsets.LastTrainerNameOffset, (int)Consts.NameMaxLength);
        set
        {
            var sdata = Encoding.Unicode.GetBytes(value);
            var length = sdata.Length > (int)Consts.NameMaxLength ? (int)Consts.NameMaxLength : sdata.Length;
            Array.Clear(data, (int)Offsets.LastTrainerNameOffset, (int)Consts.NameMaxLength);
            Array.Copy(sdata, 0, data, (int)Offsets.LastTrainerNameOffset, length);
        }
    }

    [DisplayName(@"OT Name")]
    public string OTName
    {
        get => Encoding.Unicode.GetString(data, (int)Offsets.OTNameOffset, (int)Consts.NameMaxLength);
        set
        {
            var sdata = Encoding.Unicode.GetBytes(value);
            var length = sdata.Length > (int)Consts.NameMaxLength ? (int)Consts.NameMaxLength : sdata.Length;
            Array.Clear(data, (int)Offsets.OTNameOffset, (int)Consts.NameMaxLength);
            Array.Copy(sdata, 0, data, (int)Offsets.OTNameOffset, length);
        }
    }

    [DisplayName(@"Ball")]
    public Items Ball
    {
        get => Extensions.BallToItem(pokeball);
        set => pokeball = Extensions.ItemToBall(value);
    }

    [DisplayName(@"Egg Location")]
    public Locations EggLocation
    {
        get => Enum.IsDefined(typeof(Locations), egglocation)
                ? ((Locations)egglocation)
                : Locations.Mystery_Zone;
        set => egglocation = (ushort)value;
    }

    [DisplayName(@"Met Location")]
    public Locations MetLocation
    {
        get => Enum.IsDefined(typeof(Locations), metlocation)
                ? ((Locations)metlocation)
                : Locations.Mystery_Zone;
        set => metlocation = (ushort)value;
    }

    [DisplayName(@"Type 1")]
    public TypeObject? Type1 => new TypeObject(DBTools.GetPokemonType(species, FormID, DBTools.TypeSlots.Slot1));

    [DisplayName(@"Type 2")]
    public TypeObject? Type2 => new TypeObject(DBTools.GetPokemonType(species, FormID, DBTools.TypeSlots.Slot2));

    [DisplayName(@"Egg Date")]
    public DateTime? EggDate
    {
        get
        {
            if (eggmetyear == 0 && eggmetmonth == 0 && eggmetday == 0)
            {
                return null;
            }

            try
            {
                return new DateTime(eggmetyear + 2000, eggmetmonth, eggmetday);
            }
            catch (Exception)
            {
                // ignored
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
                eggmetyear = (byte)(value.Value.Year - 2000);
                eggmetmonth = (byte)value.Value.Month;
                eggmetday = (byte)value.Value.Day;
            }
        }
    }

    [DisplayName(@"Met Date")]
    public DateTime MetDate
    {
        get
        {
            try
            {
                return new DateTime(datemetyear + 2000, datemetmonth, datemetday);
            }
            catch (Exception)
            {
                // ignored
            }
            return DateTime.MinValue;
        }
        set
        {
            {
                datemetyear = (byte)(value.Year - 2000);
                datemetmonth = (byte)value.Month;
                datemetday = (byte)value.Day;
            }
        }
    }

    [DisplayName(@"Secret Super Training Available")]
    public bool SecretSuperTrainingAvailable
    {
        get => secretsupertrainingflag != 0;
        set => secretsupertrainingflag = value ? Convert.ToByte(1) : Convert.ToByte(0);
    }

    [DisplayName(@"Met At Level")]
    public int MetLevel
    {
        get => (metlevelotgender) & 0x7F;
        set => metlevelotgender = Convert.ToByte(value > 127
                ? (metlevelotgender & ~0x7Fu) | (127 & 0x7Fu)
                : (metlevelotgender & ~0x7Fu) | (value & 0x7Fu));
    }

    [DisplayName(@"OT Gender")]
    public Genders OTGender
    {
        get => ((metlevelotgender) & 0x80) >> 7 == 1 ? Genders.Female : Genders.Male;
        set => metlevelotgender =
                Convert.ToByte((metlevelotgender & ~(0x01u << 7)) | (Convert.ToUInt32(value) & 0x01u) << 7);
    }

    [DisplayName(@"OT Gender Is Male")]
    public bool OTGenderIsMale
    {
        get => OTGender == Genders.Male;
        set => OTGender = value ? Genders.Male : Genders.Female;
    }

    [DisplayName(@"OT Gender Is Female")]
    public bool OTGenderIsFemale
    {
        get => OTGender == Genders.Female;
        set => OTGender = value ? Genders.Female : Genders.Male;
    }

    [DisplayName(@"Level")]
    public int Level
    {
        get => DBTools.GetLevel(species, exp);
        set
        {
            if (value is < 1 or > 100)
            {
                throw new Exception(string.Format("{0}'s level must be between 1 and 100.", this));
            }

            exp = DBTools.GetEXPAtLevel(species, value);
        }
    }

    [DisplayName(@"Form Name")]
    public string FormName => DBTools.GetFormName(species, FormID);

    [Browsable(false)]
    private string PokemonName => DBTools.GetPokemonName(species, FormID);

    [DisplayName(@"Current Trainer Is OT")]
    public bool CurrentTrainerIsOT
    {
        get => currenthandler == 1;
        set => currenthandler = value ? Convert.ToByte(1) : Convert.ToByte(0);
    }

    [DisplayName(@"Last Trainer Gender")]
    public Genders LastTrainerGender
    {
        get => (Genders)lasttrainergender;
        set => lasttrainergender = (byte)value;
    }

    [DisplayName(@"Move 1 PP Ups")]
    public byte Move1PPUps
    {
        get => move1ppups;
        set => move1ppups = value;
    }

    [DisplayName(@"Move 2 PP Ups")]
    public byte Move2PPUps
    {
        get => move2ppups;
        set => move2ppups = value;
    }

    [DisplayName(@"Move 3 PP Ups")]
    public byte Move3PPUps
    {
        get => move3ppups;
        set => move3ppups = value;
    }

    [DisplayName(@"Move 4 PP Ups")]
    public byte Move4PPUps
    {
        get => move4ppups;
        set => move4ppups = value;
    }

    [DisplayName(@"PokeRus Days")]
    public int PokeRusDays
    {
        get => (pokerus & 0x0F) >> 0;
        set => pokerus = Convert.ToByte((pokerus & ~(0x0Fu << 00)) | (value & 0x0Fu) << 00);
    }

    [DisplayName(@"PokeRus Strain")]
    public int PokeRusStrain
    {
        get => (pokerus & 0xF0) >> 4;
        set => pokerus = Convert.ToByte((pokerus & ~(0x0Fu << 04)) | (value & 0x0Fu) << 04);
    }

    [DisplayName(@"Gender")]
    public Genders Gender => Female ? Genders.Female : Genderless ? Genders.Genderless : Genders.Male;

    [DisplayName(@"Gender Icon")]
    public Image GenderIcon => Images.GetGenderIcon(Gender);

    [DisplayName(@"Box Icon")]
    public Image BoxIcon => Images.GetPokemonImage(species, FormID, Gender);

    [DisplayName(@"Box Icon")]
    public Image BoxIconEgg => IsEgg ? Images.GetImageFromResource("egg") : BoxIcon;

    [DisplayName(@"HP")]
    public int HP => DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[0];

    [DisplayName(@"Attack")]
    public int Attack => DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[1];

    [DisplayName(@"Defense")]
    public int Defense => DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[2];

    [DisplayName(@"Speed")]
    public int Speed => DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[3];

    [DisplayName(@"Special Attack")]
    public int SpecialAttack => DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[4];

    [DisplayName(@"Special Defense")]
    public int SpecialDefense => DBTools.CalcStats(species, FormID, nature, Level, HP_IV, Attack_IV, Defense_IV, Speed_IV, SpecialAttack_IV, SpecialDefense_IV, HPEffortValue, AttackEffortValue, DefenseEffortValue, SpeedEffortValue, SpAttackEffortValue, SpDefenseEffortValue)[5];

    #endregion Pokemon Properties

    #region Other Properties

    public override string ToString() => Species.EnumToString();

    #endregion Other Properties

    #region Methods

    public void Encrypt() => PokePRNG.EncryptPokemon(this);

    public void Decrypt() => PokePRNG.DecryptPokemon(this);

    public void CloneFrom(Pokemon pokemon) => Array.Copy(pokemon.data, 0, data, 0, 232);

    #endregion Methods
}
