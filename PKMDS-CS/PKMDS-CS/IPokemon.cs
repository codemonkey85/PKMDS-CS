using System;

namespace PKMDS_CS
{
    public interface IPokemon
    {
        byte _3DSRegionID { get; set; }

        Abilities Ability { get; set; }

        byte AbilityNumber { get; set; }

        int Attack { get; }

        uint Attack_IV { get; set; }

        byte AttackEffortValue { get; set; }

        Items Ball { get; set; }

        byte BattleMemoryRibbonCount { get; set; }

        System.Drawing.Image BoxIcon { get; }

        System.Drawing.Image BoxIconEgg { get; }

        //ushort Checksum { get; set; }

        bool Circle { get; set; }

        void CloneFrom(Pokemon pokemon);

        int CompareTo(Pokemon comparePokemon);

        byte ContestMemoryRibbonCount { get; set; }

        byte ContestStatBeauty { get; set; }

        byte ContestStatCool { get; set; }

        byte ContestStatCute { get; set; }

        byte ContestStatSheen { get; set; }

        byte ContestStatSmart { get; set; }

        byte ContestStatTough { get; set; }

        byte CountryID { get; set; }

        byte currenthandler { get; set; }

        bool CurrentTrainerIsOT { get; set; }

        void Decrypt();

        int Defense { get; }

        uint Defense_IV { get; set; }

        byte DefenseEffortValue { get; set; }

        bool Diamond { get; set; }

        byte DistributionSuperTrainingFlags { get; set; }

        DateTime? EggDate { get; set; }

        ushort egglocation { get; set; }

        Locations EggLocation { get; set; }

        byte EncounterTypeGen4 { get; set; }

        void Encrypt();

        byte Enjoyment { get; set; }

        bool Equals(Pokemon other);

        bool Equals(Species other);

        bool Equals(object obj);

        uint EXP { get; set; }

        bool Fateful { get; set; }

        bool Female { get; set; }

        byte FormID { get; set; }

        string FormName { get; }

        byte Fullness { get; set; }

        Genders Gender { get; }

        System.Drawing.Image GenderIcon { get; }

        bool Genderless { get; set; }

        ushort Geolocation1RegionCountry { get; set; }

        ushort Geolocation2RegionCountry { get; set; }

        ushort Geolocation3RegionCountry { get; set; }

        ushort Geolocation4RegionCountry { get; set; }

        ushort Geolocation5RegionCountry { get; set; }

        int GetHashCode();

        bool Heart { get; set; }

        Items HeldItem { get; set; }

        ushort HitsRemainingonTrainingBag { get; set; }

        int HP { get; }

        uint HP_IV { get; set; }

        byte HPEffortValue { get; set; }

        bool IsEgg { get; set; }

        bool IsNicknamed { get; set; }

        byte lasttrainergender { get; set; }

        Genders LastTrainerGender { get; set; }

        string LastTrainerName { get; set; }

        int Level { get; set; }

        DateTime MetDate { get; set; }

        int MetLevel { get; set; }

        ushort metlocation { get; set; }

        Locations MetLocation { get; set; }

        Moves Move1 { get; set; }

        byte Move1CurrentPP { get; set; }

        ushort move1id { get; set; }

        byte Move1PPUps { get; set; }

        Moves Move2 { get; set; }

        byte Move2CurrentPP { get; set; }

        ushort move2id { get; set; }

        byte Move2PPUps { get; set; }

        Moves Move3 { get; set; }

        byte Move3CurrentPP { get; set; }

        ushort move3id { get; set; }

        byte Move3PPUps { get; set; }

        Moves Move4 { get; set; }

        byte Move4CurrentPP { get; set; }

        ushort move4id { get; set; }

        byte Move4PPUps { get; set; }

        System.Collections.Generic.List<MovesObject> Moves { get; set; }

        Natures Nature { get; set; }

        string Nickname { get; set; }

        byte NotOTAffection { get; set; }

        byte NotOTFriendship { get; set; }

        byte NotOTMemoryFeeling { get; set; }

        byte NotOTMemoryIntensity { get; set; }

        byte NotOTMemoryLine { get; set; }

        ushort NotOTMemoryTextVar { get; set; }

        byte OTAffection { get; set; }

        byte OTFriendship { get; set; }

        byte OTGameID { get; set; }

        Genders OTGender { get; set; }

        bool OTGenderIsFemale { get; set; }

        bool OTGenderIsMale { get; set; }

        ushort OTID { get; set; }

        byte OTLanguageID { get; set; }

        byte OTMemoryFeeling { get; set; }

        byte OTMemoryIntensity { get; set; }

        byte OTMemoryLine { get; set; }

        ushort OTMemoryTextVar { get; set; }

        string OTName { get; set; }

        ushort OTSecretID { get; set; }

        uint PID { get; set; }

        byte pokeball { get; set; }

        byte pokerus { get; set; }

        int PokeRusDays { get; set; }

        int PokeRusStrain { get; set; }

        byte RegionID { get; set; }

        System.Collections.Generic.List<MovesObject> RelearnableMoves { get; set; }

        Moves RelearnMove1 { get; set; }

        ushort relearnmove1id { get; set; }

        Moves RelearnMove2 { get; set; }

        ushort relearnmove2id { get; set; }

        Moves RelearnMove3 { get; set; }

        ushort relearnmove3id { get; set; }

        Moves RelearnMove4 { get; set; }

        ushort relearnmove4id { get; set; }

        bool SecretSuperTrainingAvailable { get; set; }

        byte SecretSuperTrainingFlag { get; set; }

        int SortBySpeciesAscending(string name1, string name2);

        byte SpAttackEffortValue { get; set; }

        byte SpDefenseEffortValue { get; set; }

        int SpecialAttack { get; }

        uint SpecialAttack_IV { get; set; }

        int SpecialDefense { get; }

        uint SpecialDefense_IV { get; set; }

        Species Species { get; set; }

        int Speed { get; }

        uint Speed_IV { get; set; }

        byte SpeedEffortValue { get; set; }

        bool Square { get; set; }

        bool Star { get; set; }

        string ToString();

        bool Triangle { get; set; }

        TypeObject? Type1 { get; }

        TypeObject? Type2 { get; }
    }
}