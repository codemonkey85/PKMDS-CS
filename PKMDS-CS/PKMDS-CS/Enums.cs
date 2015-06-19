#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;

#endregion Using

namespace PKMDS_CS
{
    public static class Extensions
    {
        internal static List<ushort> BallsToItems = new List<ushort>
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            492,
            493,
            494,
            495,
            496,
            497,
            498,
            499,
            576
        };

        /// <summary>
        ///     Return the DescriptionAttribute of the given Enum.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>String</returns>
        public static string EnumToString(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                        Attribute.GetCustomAttribute(field,
                            typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

        public static Items BallToItem(byte ball)
        {
            if (ball < 0 || ball >= BallsToItems.Count)
                return Items.NoItem;
            return (Items)BallsToItems[ball];
        }

        public static byte ItemToBall(Items item)
        {
            if (!BallsToItems.Contains((ushort)item))
                return 0;
            return (byte)(BallsToItems.IndexOf((ushort)item));
        }
    }

    public enum Species : ushort
    {
        [Description("No Species")]
        NoSpecies = 0,

        [Description("Bulbasaur")]
        Bulbasaur = 1,

        [Description("Ivysaur")]
        Ivysaur = 2,

        [Description("Venusaur")]
        Venusaur = 3,

        [Description("Charmander")]
        Charmander = 4,

        [Description("Charmeleon")]
        Charmeleon = 5,

        [Description("Charizard")]
        Charizard = 6,

        [Description("Squirtle")]
        Squirtle = 7,

        [Description("Wartortle")]
        Wartortle = 8,

        [Description("Blastoise")]
        Blastoise = 9,

        [Description("Caterpie")]
        Caterpie = 10,

        [Description("Metapod")]
        Metapod = 11,

        [Description("Butterfree")]
        Butterfree = 12,

        [Description("Weedle")]
        Weedle = 13,

        [Description("Kakuna")]
        Kakuna = 14,

        [Description("Beedrill")]
        Beedrill = 15,

        [Description("Pidgey")]
        Pidgey = 16,

        [Description("Pidgeotto")]
        Pidgeotto = 17,

        [Description("Pidgeot")]
        Pidgeot = 18,

        [Description("Rattata")]
        Rattata = 19,

        [Description("Raticate")]
        Raticate = 20,

        [Description("Spearow")]
        Spearow = 21,

        [Description("Fearow")]
        Fearow = 22,

        [Description("Ekans")]
        Ekans = 23,

        [Description("Arbok")]
        Arbok = 24,

        [Description("Pikachu")]
        Pikachu = 25,

        [Description("Raichu")]
        Raichu = 26,

        [Description("Sandshrew")]
        Sandshrew = 27,

        [Description("Sandslash")]
        Sandslash = 28,

        [Description("Nidoran♀")]
        Nidoran_F = 29,

        [Description("Nidorina")]
        Nidorina = 30,

        [Description("Nidoqueen")]
        Nidoqueen = 31,

        [Description("Nidoran♂")]
        Nidoran_M = 32,

        [Description("Nidorino")]
        Nidorino = 33,

        [Description("Nidoking")]
        Nidoking = 34,

        [Description("Clefairy")]
        Clefairy = 35,

        [Description("Clefable")]
        Clefable = 36,

        [Description("Vulpix")]
        Vulpix = 37,

        [Description("Ninetales")]
        Ninetales = 38,

        [Description("Jigglypuff")]
        Jigglypuff = 39,

        [Description("Wigglytuff")]
        Wigglytuff = 40,

        [Description("Zubat")]
        Zubat = 41,

        [Description("Golbat")]
        Golbat = 42,

        [Description("Oddish")]
        Oddish = 43,

        [Description("Gloom")]
        Gloom = 44,

        [Description("Vileplume")]
        Vileplume = 45,

        [Description("Paras")]
        Paras = 46,

        [Description("Parasect")]
        Parasect = 47,

        [Description("Venonat")]
        Venonat = 48,

        [Description("Venomoth")]
        Venomoth = 49,

        [Description("Diglett")]
        Diglett = 50,

        [Description("Dugtrio")]
        Dugtrio = 51,

        [Description("Meowth")]
        Meowth = 52,

        [Description("Persian")]
        Persian = 53,

        [Description("Psyduck")]
        Psyduck = 54,

        [Description("Golduck")]
        Golduck = 55,

        [Description("Mankey")]
        Mankey = 56,

        [Description("Primeape")]
        Primeape = 57,

        [Description("Growlithe")]
        Growlithe = 58,

        [Description("Arcanine")]
        Arcanine = 59,

        [Description("Poliwag")]
        Poliwag = 60,

        [Description("Poliwhirl")]
        Poliwhirl = 61,

        [Description("Poliwrath")]
        Poliwrath = 62,

        [Description("Abra")]
        Abra = 63,

        [Description("Kadabra")]
        Kadabra = 64,

        [Description("Alakazam")]
        Alakazam = 65,

        [Description("Machop")]
        Machop = 66,

        [Description("Machoke")]
        Machoke = 67,

        [Description("Machamp")]
        Machamp = 68,

        [Description("Bellsprout")]
        Bellsprout = 69,

        [Description("Weepinbell")]
        Weepinbell = 70,

        [Description("Victreebel")]
        Victreebel = 71,

        [Description("Tentacool")]
        Tentacool = 72,

        [Description("Tentacruel")]
        Tentacruel = 73,

        [Description("Geodude")]
        Geodude = 74,

        [Description("Graveler")]
        Graveler = 75,

        [Description("Golem")]
        Golem = 76,

        [Description("Ponyta")]
        Ponyta = 77,

        [Description("Rapidash")]
        Rapidash = 78,

        [Description("Slowpoke")]
        Slowpoke = 79,

        [Description("Slowbro")]
        Slowbro = 80,

        [Description("Magnemite")]
        Magnemite = 81,

        [Description("Magneton")]
        Magneton = 82,

        [Description("Farfetch'd")]
        Farfetchd = 83,

        [Description("Doduo")]
        Doduo = 84,

        [Description("Dodrio")]
        Dodrio = 85,

        [Description("Seel")]
        Seel = 86,

        [Description("Dewgong")]
        Dewgong = 87,

        [Description("Grimer")]
        Grimer = 88,

        [Description("Muk")]
        Muk = 89,

        [Description("Shellder")]
        Shellder = 90,

        [Description("Cloyster")]
        Cloyster = 91,

        [Description("Gastly")]
        Gastly = 92,

        [Description("Haunter")]
        Haunter = 93,

        [Description("Gengar")]
        Gengar = 94,

        [Description("Onix")]
        Onix = 95,

        [Description("Drowzee")]
        Drowzee = 96,

        [Description("Hypno")]
        Hypno = 97,

        [Description("Krabby")]
        Krabby = 98,

        [Description("Kingler")]
        Kingler = 99,

        [Description("Voltorb")]
        Voltorb = 100,

        [Description("Electrode")]
        Electrode = 101,

        [Description("Exeggcute")]
        Exeggcute = 102,

        [Description("Exeggutor")]
        Exeggutor = 103,

        [Description("Cubone")]
        Cubone = 104,

        [Description("Marowak")]
        Marowak = 105,

        [Description("Hitmonlee")]
        Hitmonlee = 106,

        [Description("Hitmonchan")]
        Hitmonchan = 107,

        [Description("Lickitung")]
        Lickitung = 108,

        [Description("Koffing")]
        Koffing = 109,

        [Description("Weezing")]
        Weezing = 110,

        [Description("Rhyhorn")]
        Rhyhorn = 111,

        [Description("Rhydon")]
        Rhydon = 112,

        [Description("Chansey")]
        Chansey = 113,

        [Description("Tangela")]
        Tangela = 114,

        [Description("Kangaskhan")]
        Kangaskhan = 115,

        [Description("Horsea")]
        Horsea = 116,

        [Description("Seadra")]
        Seadra = 117,

        [Description("Goldeen")]
        Goldeen = 118,

        [Description("Seaking")]
        Seaking = 119,

        [Description("Staryu")]
        Staryu = 120,

        [Description("Starmie")]
        Starmie = 121,

        [Description("Mr. Mime")]
        Mr_Mime = 122,

        [Description("Scyther")]
        Scyther = 123,

        [Description("Jynx")]
        Jynx = 124,

        [Description("Electabuzz")]
        Electabuzz = 125,

        [Description("Magmar")]
        Magmar = 126,

        [Description("Pinsir")]
        Pinsir = 127,

        [Description("Tauros")]
        Tauros = 128,

        [Description("Magikarp")]
        Magikarp = 129,

        [Description("Gyarados")]
        Gyarados = 130,

        [Description("Lapras")]
        Lapras = 131,

        [Description("Ditto")]
        Ditto = 132,

        [Description("Eevee")]
        Eevee = 133,

        [Description("Vaporeon")]
        Vaporeon = 134,

        [Description("Jolteon")]
        Jolteon = 135,

        [Description("Flareon")]
        Flareon = 136,

        [Description("Porygon")]
        Porygon = 137,

        [Description("Omanyte")]
        Omanyte = 138,

        [Description("Omastar")]
        Omastar = 139,

        [Description("Kabuto")]
        Kabuto = 140,

        [Description("Kabutops")]
        Kabutops = 141,

        [Description("Aerodactyl")]
        Aerodactyl = 142,

        [Description("Snorlax")]
        Snorlax = 143,

        [Description("Articuno")]
        Articuno = 144,

        [Description("Zapdos")]
        Zapdos = 145,

        [Description("Moltres")]
        Moltres = 146,

        [Description("Dratini")]
        Dratini = 147,

        [Description("Dragonair")]
        Dragonair = 148,

        [Description("Dragonite")]
        Dragonite = 149,

        [Description("Mewtwo")]
        Mewtwo = 150,

        [Description("Mew")]
        Mew = 151,

        [Description("Chikorita")]
        Chikorita = 152,

        [Description("Bayleef")]
        Bayleef = 153,

        [Description("Meganium")]
        Meganium = 154,

        [Description("Cyndaquil")]
        Cyndaquil = 155,

        [Description("Quilava")]
        Quilava = 156,

        [Description("Typhlosion")]
        Typhlosion = 157,

        [Description("Totodile")]
        Totodile = 158,

        [Description("Croconaw")]
        Croconaw = 159,

        [Description("Feraligatr")]
        Feraligatr = 160,

        [Description("Sentret")]
        Sentret = 161,

        [Description("Furret")]
        Furret = 162,

        [Description("Hoothoot")]
        Hoothoot = 163,

        [Description("Noctowl")]
        Noctowl = 164,

        [Description("Ledyba")]
        Ledyba = 165,

        [Description("Ledian")]
        Ledian = 166,

        [Description("Spinarak")]
        Spinarak = 167,

        [Description("Ariados")]
        Ariados = 168,

        [Description("Crobat")]
        Crobat = 169,

        [Description("Chinchou")]
        Chinchou = 170,

        [Description("Lanturn")]
        Lanturn = 171,

        [Description("Pichu")]
        Pichu = 172,

        [Description("Cleffa")]
        Cleffa = 173,

        [Description("Igglybuff")]
        Igglybuff = 174,

        [Description("Togepi")]
        Togepi = 175,

        [Description("Togetic")]
        Togetic = 176,

        [Description("Natu")]
        Natu = 177,

        [Description("Xatu")]
        Xatu = 178,

        [Description("Mareep")]
        Mareep = 179,

        [Description("Flaaffy")]
        Flaaffy = 180,

        [Description("Ampharos")]
        Ampharos = 181,

        [Description("Bellossom")]
        Bellossom = 182,

        [Description("Marill")]
        Marill = 183,

        [Description("Azumarill")]
        Azumarill = 184,

        [Description("Sudowoodo")]
        Sudowoodo = 185,

        [Description("Politoed")]
        Politoed = 186,

        [Description("Hoppip")]
        Hoppip = 187,

        [Description("Skiploom")]
        Skiploom = 188,

        [Description("Jumpluff")]
        Jumpluff = 189,

        [Description("Aipom")]
        Aipom = 190,

        [Description("Sunkern")]
        Sunkern = 191,

        [Description("Sunflora")]
        Sunflora = 192,

        [Description("Yanma")]
        Yanma = 193,

        [Description("Wooper")]
        Wooper = 194,

        [Description("Quagsire")]
        Quagsire = 195,

        [Description("Espeon")]
        Espeon = 196,

        [Description("Umbreon")]
        Umbreon = 197,

        [Description("Murkrow")]
        Murkrow = 198,

        [Description("Slowking")]
        Slowking = 199,

        [Description("Misdreavus")]
        Misdreavus = 200,

        [Description("Unown")]
        Unown = 201,

        [Description("Wobbuffet")]
        Wobbuffet = 202,

        [Description("Girafarig")]
        Girafarig = 203,

        [Description("Pineco")]
        Pineco = 204,

        [Description("Forretress")]
        Forretress = 205,

        [Description("Dunsparce")]
        Dunsparce = 206,

        [Description("Gligar")]
        Gligar = 207,

        [Description("Steelix")]
        Steelix = 208,

        [Description("Snubbull")]
        Snubbull = 209,

        [Description("Granbull")]
        Granbull = 210,

        [Description("Qwilfish")]
        Qwilfish = 211,

        [Description("Scizor")]
        Scizor = 212,

        [Description("Shuckle")]
        Shuckle = 213,

        [Description("Heracross")]
        Heracross = 214,

        [Description("Sneasel")]
        Sneasel = 215,

        [Description("Teddiursa")]
        Teddiursa = 216,

        [Description("Ursaring")]
        Ursaring = 217,

        [Description("Slugma")]
        Slugma = 218,

        [Description("Magcargo")]
        Magcargo = 219,

        [Description("Swinub")]
        Swinub = 220,

        [Description("Piloswine")]
        Piloswine = 221,

        [Description("Corsola")]
        Corsola = 222,

        [Description("Remoraid")]
        Remoraid = 223,

        [Description("Octillery")]
        Octillery = 224,

        [Description("Delibird")]
        Delibird = 225,

        [Description("Mantine")]
        Mantine = 226,

        [Description("Skarmory")]
        Skarmory = 227,

        [Description("Houndour")]
        Houndour = 228,

        [Description("Houndoom")]
        Houndoom = 229,

        [Description("Kingdra")]
        Kingdra = 230,

        [Description("Phanpy")]
        Phanpy = 231,

        [Description("Donphan")]
        Donphan = 232,

        [Description("Porygon2")]
        Porygon2 = 233,

        [Description("Stantler")]
        Stantler = 234,

        [Description("Smeargle")]
        Smeargle = 235,

        [Description("Tyrogue")]
        Tyrogue = 236,

        [Description("Hitmontop")]
        Hitmontop = 237,

        [Description("Smoochum")]
        Smoochum = 238,

        [Description("Elekid")]
        Elekid = 239,

        [Description("Magby")]
        Magby = 240,

        [Description("Miltank")]
        Miltank = 241,

        [Description("Blissey")]
        Blissey = 242,

        [Description("Raikou")]
        Raikou = 243,

        [Description("Entei")]
        Entei = 244,

        [Description("Suicune")]
        Suicune = 245,

        [Description("Larvitar")]
        Larvitar = 246,

        [Description("Pupitar")]
        Pupitar = 247,

        [Description("Tyranitar")]
        Tyranitar = 248,

        [Description("Lugia")]
        Lugia = 249,

        [Description("Ho-Oh")]
        Ho_Oh = 250,

        [Description("Celebi")]
        Celebi = 251,

        [Description("Treecko")]
        Treecko = 252,

        [Description("Grovyle")]
        Grovyle = 253,

        [Description("Sceptile")]
        Sceptile = 254,

        [Description("Torchic")]
        Torchic = 255,

        [Description("Combusken")]
        Combusken = 256,

        [Description("Blaziken")]
        Blaziken = 257,

        [Description("Mudkip")]
        Mudkip = 258,

        [Description("Marshtomp")]
        Marshtomp = 259,

        [Description("Swampert")]
        Swampert = 260,

        [Description("Poochyena")]
        Poochyena = 261,

        [Description("Mightyena")]
        Mightyena = 262,

        [Description("Zigzagoon")]
        Zigzagoon = 263,

        [Description("Linoone")]
        Linoone = 264,

        [Description("Wurmple")]
        Wurmple = 265,

        [Description("Silcoon")]
        Silcoon = 266,

        [Description("Beautifly")]
        Beautifly = 267,

        [Description("Cascoon")]
        Cascoon = 268,

        [Description("Dustox")]
        Dustox = 269,

        [Description("Lotad")]
        Lotad = 270,

        [Description("Lombre")]
        Lombre = 271,

        [Description("Ludicolo")]
        Ludicolo = 272,

        [Description("Seedot")]
        Seedot = 273,

        [Description("Nuzleaf")]
        Nuzleaf = 274,

        [Description("Shiftry")]
        Shiftry = 275,

        [Description("Taillow")]
        Taillow = 276,

        [Description("Swellow")]
        Swellow = 277,

        [Description("Wingull")]
        Wingull = 278,

        [Description("Pelipper")]
        Pelipper = 279,

        [Description("Ralts")]
        Ralts = 280,

        [Description("Kirlia")]
        Kirlia = 281,

        [Description("Gardevoir")]
        Gardevoir = 282,

        [Description("Surskit")]
        Surskit = 283,

        [Description("Masquerain")]
        Masquerain = 284,

        [Description("Shroomish")]
        Shroomish = 285,

        [Description("Breloom")]
        Breloom = 286,

        [Description("Slakoth")]
        Slakoth = 287,

        [Description("Vigoroth")]
        Vigoroth = 288,

        [Description("Slaking")]
        Slaking = 289,

        [Description("Nincada")]
        Nincada = 290,

        [Description("Ninjask")]
        Ninjask = 291,

        [Description("Shedinja")]
        Shedinja = 292,

        [Description("Whismur")]
        Whismur = 293,

        [Description("Loudred")]
        Loudred = 294,

        [Description("Exploud")]
        Exploud = 295,

        [Description("Makuhita")]
        Makuhita = 296,

        [Description("Hariyama")]
        Hariyama = 297,

        [Description("Azurill")]
        Azurill = 298,

        [Description("Nosepass")]
        Nosepass = 299,

        [Description("Skitty")]
        Skitty = 300,

        [Description("Delcatty")]
        Delcatty = 301,

        [Description("Sableye")]
        Sableye = 302,

        [Description("Mawile")]
        Mawile = 303,

        [Description("Aron")]
        Aron = 304,

        [Description("Lairon")]
        Lairon = 305,

        [Description("Aggron")]
        Aggron = 306,

        [Description("Meditite")]
        Meditite = 307,

        [Description("Medicham")]
        Medicham = 308,

        [Description("Electrike")]
        Electrike = 309,

        [Description("Manectric")]
        Manectric = 310,

        [Description("Plusle")]
        Plusle = 311,

        [Description("Minun")]
        Minun = 312,

        [Description("Volbeat")]
        Volbeat = 313,

        [Description("Illumise")]
        Illumise = 314,

        [Description("Roselia")]
        Roselia = 315,

        [Description("Gulpin")]
        Gulpin = 316,

        [Description("Swalot")]
        Swalot = 317,

        [Description("Carvanha")]
        Carvanha = 318,

        [Description("Sharpedo")]
        Sharpedo = 319,

        [Description("Wailmer")]
        Wailmer = 320,

        [Description("Wailord")]
        Wailord = 321,

        [Description("Numel")]
        Numel = 322,

        [Description("Camerupt")]
        Camerupt = 323,

        [Description("Torkoal")]
        Torkoal = 324,

        [Description("Spoink")]
        Spoink = 325,

        [Description("Grumpig")]
        Grumpig = 326,

        [Description("Spinda")]
        Spinda = 327,

        [Description("Trapinch")]
        Trapinch = 328,

        [Description("Vibrava")]
        Vibrava = 329,

        [Description("Flygon")]
        Flygon = 330,

        [Description("Cacnea")]
        Cacnea = 331,

        [Description("Cacturne")]
        Cacturne = 332,

        [Description("Swablu")]
        Swablu = 333,

        [Description("Altaria")]
        Altaria = 334,

        [Description("Zangoose")]
        Zangoose = 335,

        [Description("Seviper")]
        Seviper = 336,

        [Description("Lunatone")]
        Lunatone = 337,

        [Description("Solrock")]
        Solrock = 338,

        [Description("Barboach")]
        Barboach = 339,

        [Description("Whiscash")]
        Whiscash = 340,

        [Description("Corphish")]
        Corphish = 341,

        [Description("Crawdaunt")]
        Crawdaunt = 342,

        [Description("Baltoy")]
        Baltoy = 343,

        [Description("Claydol")]
        Claydol = 344,

        [Description("Lileep")]
        Lileep = 345,

        [Description("Cradily")]
        Cradily = 346,

        [Description("Anorith")]
        Anorith = 347,

        [Description("Armaldo")]
        Armaldo = 348,

        [Description("Feebas")]
        Feebas = 349,

        [Description("Milotic")]
        Milotic = 350,

        [Description("Castform")]
        Castform = 351,

        [Description("Kecleon")]
        Kecleon = 352,

        [Description("Shuppet")]
        Shuppet = 353,

        [Description("Banette")]
        Banette = 354,

        [Description("Duskull")]
        Duskull = 355,

        [Description("Dusclops")]
        Dusclops = 356,

        [Description("Tropius")]
        Tropius = 357,

        [Description("Chimecho")]
        Chimecho = 358,

        [Description("Absol")]
        Absol = 359,

        [Description("Wynaut")]
        Wynaut = 360,

        [Description("Snorunt")]
        Snorunt = 361,

        [Description("Glalie")]
        Glalie = 362,

        [Description("Spheal")]
        Spheal = 363,

        [Description("Sealeo")]
        Sealeo = 364,

        [Description("Walrein")]
        Walrein = 365,

        [Description("Clamperl")]
        Clamperl = 366,

        [Description("Huntail")]
        Huntail = 367,

        [Description("Gorebyss")]
        Gorebyss = 368,

        [Description("Relicanth")]
        Relicanth = 369,

        [Description("Luvdisc")]
        Luvdisc = 370,

        [Description("Bagon")]
        Bagon = 371,

        [Description("Shelgon")]
        Shelgon = 372,

        [Description("Salamence")]
        Salamence = 373,

        [Description("Beldum")]
        Beldum = 374,

        [Description("Metang")]
        Metang = 375,

        [Description("Metagross")]
        Metagross = 376,

        [Description("Regirock")]
        Regirock = 377,

        [Description("Regice")]
        Regice = 378,

        [Description("Registeel")]
        Registeel = 379,

        [Description("Latias")]
        Latias = 380,

        [Description("Latios")]
        Latios = 381,

        [Description("Kyogre")]
        Kyogre = 382,

        [Description("Groudon")]
        Groudon = 383,

        [Description("Rayquaza")]
        Rayquaza = 384,

        [Description("Jirachi")]
        Jirachi = 385,

        [Description("Deoxys")]
        Deoxys = 386,

        [Description("Turtwig")]
        Turtwig = 387,

        [Description("Grotle")]
        Grotle = 388,

        [Description("Torterra")]
        Torterra = 389,

        [Description("Chimchar")]
        Chimchar = 390,

        [Description("Monferno")]
        Monferno = 391,

        [Description("Infernape")]
        Infernape = 392,

        [Description("Piplup")]
        Piplup = 393,

        [Description("Prinplup")]
        Prinplup = 394,

        [Description("Empoleon")]
        Empoleon = 395,

        [Description("Starly")]
        Starly = 396,

        [Description("Staravia")]
        Staravia = 397,

        [Description("Staraptor")]
        Staraptor = 398,

        [Description("Bidoof")]
        Bidoof = 399,

        [Description("Bibarel")]
        Bibarel = 400,

        [Description("Kricketot")]
        Kricketot = 401,

        [Description("Kricketune")]
        Kricketune = 402,

        [Description("Shinx")]
        Shinx = 403,

        [Description("Luxio")]
        Luxio = 404,

        [Description("Luxray")]
        Luxray = 405,

        [Description("Budew")]
        Budew = 406,

        [Description("Roserade")]
        Roserade = 407,

        [Description("Cranidos")]
        Cranidos = 408,

        [Description("Rampardos")]
        Rampardos = 409,

        [Description("Shieldon")]
        Shieldon = 410,

        [Description("Bastiodon")]
        Bastiodon = 411,

        [Description("Burmy")]
        Burmy = 412,

        [Description("Wormadam")]
        Wormadam = 413,

        [Description("Mothim")]
        Mothim = 414,

        [Description("Combee")]
        Combee = 415,

        [Description("Vespiquen")]
        Vespiquen = 416,

        [Description("Pachirisu")]
        Pachirisu = 417,

        [Description("Buizel")]
        Buizel = 418,

        [Description("Floatzel")]
        Floatzel = 419,

        [Description("Cherubi")]
        Cherubi = 420,

        [Description("Cherrim")]
        Cherrim = 421,

        [Description("Shellos")]
        Shellos = 422,

        [Description("Gastrodon")]
        Gastrodon = 423,

        [Description("Ambipom")]
        Ambipom = 424,

        [Description("Drifloon")]
        Drifloon = 425,

        [Description("Drifblim")]
        Drifblim = 426,

        [Description("Buneary")]
        Buneary = 427,

        [Description("Lopunny")]
        Lopunny = 428,

        [Description("Mismagius")]
        Mismagius = 429,

        [Description("Honchkrow")]
        Honchkrow = 430,

        [Description("Glameow")]
        Glameow = 431,

        [Description("Purugly")]
        Purugly = 432,

        [Description("Chingling")]
        Chingling = 433,

        [Description("Stunky")]
        Stunky = 434,

        [Description("Skuntank")]
        Skuntank = 435,

        [Description("Bronzor")]
        Bronzor = 436,

        [Description("Bronzong")]
        Bronzong = 437,

        [Description("Bonsly")]
        Bonsly = 438,

        [Description("Mime Jr.")]
        Mime_Jr = 439,

        [Description("Happiny")]
        Happiny = 440,

        [Description("Chatot")]
        Chatot = 441,

        [Description("Spiritomb")]
        Spiritomb = 442,

        [Description("Gible")]
        Gible = 443,

        [Description("Gabite")]
        Gabite = 444,

        [Description("Garchomp")]
        Garchomp = 445,

        [Description("Munchlax")]
        Munchlax = 446,

        [Description("Riolu")]
        Riolu = 447,

        [Description("Lucario")]
        Lucario = 448,

        [Description("Hippopotas")]
        Hippopotas = 449,

        [Description("Hippowdon")]
        Hippowdon = 450,

        [Description("Skorupi")]
        Skorupi = 451,

        [Description("Drapion")]
        Drapion = 452,

        [Description("Croagunk")]
        Croagunk = 453,

        [Description("Toxicroak")]
        Toxicroak = 454,

        [Description("Carnivine")]
        Carnivine = 455,

        [Description("Finneon")]
        Finneon = 456,

        [Description("Lumineon")]
        Lumineon = 457,

        [Description("Mantyke")]
        Mantyke = 458,

        [Description("Snover")]
        Snover = 459,

        [Description("Abomasnow")]
        Abomasnow = 460,

        [Description("Weavile")]
        Weavile = 461,

        [Description("Magnezone")]
        Magnezone = 462,

        [Description("Lickilicky")]
        Lickilicky = 463,

        [Description("Rhyperior")]
        Rhyperior = 464,

        [Description("Tangrowth")]
        Tangrowth = 465,

        [Description("Electivire")]
        Electivire = 466,

        [Description("Magmortar")]
        Magmortar = 467,

        [Description("Togekiss")]
        Togekiss = 468,

        [Description("Yanmega")]
        Yanmega = 469,

        [Description("Leafeon")]
        Leafeon = 470,

        [Description("Glaceon")]
        Glaceon = 471,

        [Description("Gliscor")]
        Gliscor = 472,

        [Description("Mamoswine")]
        Mamoswine = 473,

        [Description("Porygon-Z")]
        Porygon_Z = 474,

        [Description("Gallade")]
        Gallade = 475,

        [Description("Probopass")]
        Probopass = 476,

        [Description("Dusknoir")]
        Dusknoir = 477,

        [Description("Froslass")]
        Froslass = 478,

        [Description("Rotom")]
        Rotom = 479,

        [Description("Uxie")]
        Uxie = 480,

        [Description("Mesprit")]
        Mesprit = 481,

        [Description("Azelf")]
        Azelf = 482,

        [Description("Dialga")]
        Dialga = 483,

        [Description("Palkia")]
        Palkia = 484,

        [Description("Heatran")]
        Heatran = 485,

        [Description("Regigigas")]
        Regigigas = 486,

        [Description("Giratina")]
        Giratina = 487,

        [Description("Cresselia")]
        Cresselia = 488,

        [Description("Phione")]
        Phione = 489,

        [Description("Manaphy")]
        Manaphy = 490,

        [Description("Darkrai")]
        Darkrai = 491,

        [Description("Shaymin")]
        Shaymin = 492,

        [Description("Arceus")]
        Arceus = 493,

        [Description("Victini")]
        Victini = 494,

        [Description("Snivy")]
        Snivy = 495,

        [Description("Servine")]
        Servine = 496,

        [Description("Serperior")]
        Serperior = 497,

        [Description("Tepig")]
        Tepig = 498,

        [Description("Pignite")]
        Pignite = 499,

        [Description("Emboar")]
        Emboar = 500,

        [Description("Oshawott")]
        Oshawott = 501,

        [Description("Dewott")]
        Dewott = 502,

        [Description("Samurott")]
        Samurott = 503,

        [Description("Patrat")]
        Patrat = 504,

        [Description("Watchog")]
        Watchog = 505,

        [Description("Lillipup")]
        Lillipup = 506,

        [Description("Herdier")]
        Herdier = 507,

        [Description("Stoutland")]
        Stoutland = 508,

        [Description("Purrloin")]
        Purrloin = 509,

        [Description("Liepard")]
        Liepard = 510,

        [Description("Pansage")]
        Pansage = 511,

        [Description("Simisage")]
        Simisage = 512,

        [Description("Pansear")]
        Pansear = 513,

        [Description("Simisear")]
        Simisear = 514,

        [Description("Panpour")]
        Panpour = 515,

        [Description("Simipour")]
        Simipour = 516,

        [Description("Munna")]
        Munna = 517,

        [Description("Musharna")]
        Musharna = 518,

        [Description("Pidove")]
        Pidove = 519,

        [Description("Tranquill")]
        Tranquill = 520,

        [Description("Unfezant")]
        Unfezant = 521,

        [Description("Blitzle")]
        Blitzle = 522,

        [Description("Zebstrika")]
        Zebstrika = 523,

        [Description("Roggenrola")]
        Roggenrola = 524,

        [Description("Boldore")]
        Boldore = 525,

        [Description("Gigalith")]
        Gigalith = 526,

        [Description("Woobat")]
        Woobat = 527,

        [Description("Swoobat")]
        Swoobat = 528,

        [Description("Drilbur")]
        Drilbur = 529,

        [Description("Excadrill")]
        Excadrill = 530,

        [Description("Audino")]
        Audino = 531,

        [Description("Timburr")]
        Timburr = 532,

        [Description("Gurdurr")]
        Gurdurr = 533,

        [Description("Conkeldurr")]
        Conkeldurr = 534,

        [Description("Tympole")]
        Tympole = 535,

        [Description("Palpitoad")]
        Palpitoad = 536,

        [Description("Seismitoad")]
        Seismitoad = 537,

        [Description("Throh")]
        Throh = 538,

        [Description("Sawk")]
        Sawk = 539,

        [Description("Sewaddle")]
        Sewaddle = 540,

        [Description("Swadloon")]
        Swadloon = 541,

        [Description("Leavanny")]
        Leavanny = 542,

        [Description("Venipede")]
        Venipede = 543,

        [Description("Whirlipede")]
        Whirlipede = 544,

        [Description("Scolipede")]
        Scolipede = 545,

        [Description("Cottonee")]
        Cottonee = 546,

        [Description("Whimsicott")]
        Whimsicott = 547,

        [Description("Petilil")]
        Petilil = 548,

        [Description("Lilligant")]
        Lilligant = 549,

        [Description("Basculin")]
        Basculin = 550,

        [Description("Sandile")]
        Sandile = 551,

        [Description("Krokorok")]
        Krokorok = 552,

        [Description("Krookodile")]
        Krookodile = 553,

        [Description("Darumaka")]
        Darumaka = 554,

        [Description("Darmanitan")]
        Darmanitan = 555,

        [Description("Maractus")]
        Maractus = 556,

        [Description("Dwebble")]
        Dwebble = 557,

        [Description("Crustle")]
        Crustle = 558,

        [Description("Scraggy")]
        Scraggy = 559,

        [Description("Scrafty")]
        Scrafty = 560,

        [Description("Sigilyph")]
        Sigilyph = 561,

        [Description("Yamask")]
        Yamask = 562,

        [Description("Cofagrigus")]
        Cofagrigus = 563,

        [Description("Tirtouga")]
        Tirtouga = 564,

        [Description("Carracosta")]
        Carracosta = 565,

        [Description("Archen")]
        Archen = 566,

        [Description("Archeops")]
        Archeops = 567,

        [Description("Trubbish")]
        Trubbish = 568,

        [Description("Garbodor")]
        Garbodor = 569,

        [Description("Zorua")]
        Zorua = 570,

        [Description("Zoroark")]
        Zoroark = 571,

        [Description("Minccino")]
        Minccino = 572,

        [Description("Cinccino")]
        Cinccino = 573,

        [Description("Gothita")]
        Gothita = 574,

        [Description("Gothorita")]
        Gothorita = 575,

        [Description("Gothitelle")]
        Gothitelle = 576,

        [Description("Solosis")]
        Solosis = 577,

        [Description("Duosion")]
        Duosion = 578,

        [Description("Reuniclus")]
        Reuniclus = 579,

        [Description("Ducklett")]
        Ducklett = 580,

        [Description("Swanna")]
        Swanna = 581,

        [Description("Vanillite")]
        Vanillite = 582,

        [Description("Vanillish")]
        Vanillish = 583,

        [Description("Vanilluxe")]
        Vanilluxe = 584,

        [Description("Deerling")]
        Deerling = 585,

        [Description("Sawsbuck")]
        Sawsbuck = 586,

        [Description("Emolga")]
        Emolga = 587,

        [Description("Karrablast")]
        Karrablast = 588,

        [Description("Escavalier")]
        Escavalier = 589,

        [Description("Foongus")]
        Foongus = 590,

        [Description("Amoonguss")]
        Amoonguss = 591,

        [Description("Frillish")]
        Frillish = 592,

        [Description("Jellicent")]
        Jellicent = 593,

        [Description("Alomomola")]
        Alomomola = 594,

        [Description("Joltik")]
        Joltik = 595,

        [Description("Galvantula")]
        Galvantula = 596,

        [Description("Ferroseed")]
        Ferroseed = 597,

        [Description("Ferrothorn")]
        Ferrothorn = 598,

        [Description("Klink")]
        Klink = 599,

        [Description("Klang")]
        Klang = 600,

        [Description("Klinklang")]
        Klinklang = 601,

        [Description("Tynamo")]
        Tynamo = 602,

        [Description("Eelektrik")]
        Eelektrik = 603,

        [Description("Eelektross")]
        Eelektross = 604,

        [Description("Elgyem")]
        Elgyem = 605,

        [Description("Beheeyem")]
        Beheeyem = 606,

        [Description("Litwick")]
        Litwick = 607,

        [Description("Lampent")]
        Lampent = 608,

        [Description("Chandelure")]
        Chandelure = 609,

        [Description("Axew")]
        Axew = 610,

        [Description("Fraxure")]
        Fraxure = 611,

        [Description("Haxorus")]
        Haxorus = 612,

        [Description("Cubchoo")]
        Cubchoo = 613,

        [Description("Beartic")]
        Beartic = 614,

        [Description("Cryogonal")]
        Cryogonal = 615,

        [Description("Shelmet")]
        Shelmet = 616,

        [Description("Accelgor")]
        Accelgor = 617,

        [Description("Stunfisk")]
        Stunfisk = 618,

        [Description("Mienfoo")]
        Mienfoo = 619,

        [Description("Mienshao")]
        Mienshao = 620,

        [Description("Druddigon")]
        Druddigon = 621,

        [Description("Golett")]
        Golett = 622,

        [Description("Golurk")]
        Golurk = 623,

        [Description("Pawniard")]
        Pawniard = 624,

        [Description("Bisharp")]
        Bisharp = 625,

        [Description("Bouffalant")]
        Bouffalant = 626,

        [Description("Rufflet")]
        Rufflet = 627,

        [Description("Braviary")]
        Braviary = 628,

        [Description("Vullaby")]
        Vullaby = 629,

        [Description("Mandibuzz")]
        Mandibuzz = 630,

        [Description("Heatmor")]
        Heatmor = 631,

        [Description("Durant")]
        Durant = 632,

        [Description("Deino")]
        Deino = 633,

        [Description("Zweilous")]
        Zweilous = 634,

        [Description("Hydreigon")]
        Hydreigon = 635,

        [Description("Larvesta")]
        Larvesta = 636,

        [Description("Volcarona")]
        Volcarona = 637,

        [Description("Cobalion")]
        Cobalion = 638,

        [Description("Terrakion")]
        Terrakion = 639,

        [Description("Virizion")]
        Virizion = 640,

        [Description("Tornadus")]
        Tornadus = 641,

        [Description("Thundurus")]
        Thundurus = 642,

        [Description("Reshiram")]
        Reshiram = 643,

        [Description("Zekrom")]
        Zekrom = 644,

        [Description("Landorus")]
        Landorus = 645,

        [Description("Kyurem")]
        Kyurem = 646,

        [Description("Keldeo")]
        Keldeo = 647,

        [Description("Meloetta")]
        Meloetta = 648,

        [Description("Genesect")]
        Genesect = 649,

        [Description("Chespin")]
        Chespin = 650,

        [Description("Quilladin")]
        Quilladin = 651,

        [Description("Chesnaught")]
        Chesnaught = 652,

        [Description("Fennekin")]
        Fennekin = 653,

        [Description("Braixen")]
        Braixen = 654,

        [Description("Delphox")]
        Delphox = 655,

        [Description("Froakie")]
        Froakie = 656,

        [Description("Frogadier")]
        Frogadier = 657,

        [Description("Greninja")]
        Greninja = 658,

        [Description("Bunnelby")]
        Bunnelby = 659,

        [Description("Diggersby")]
        Diggersby = 660,

        [Description("Fletchling")]
        Fletchling = 661,

        [Description("Fletchinder")]
        Fletchinder = 662,

        [Description("Talonflame")]
        Talonflame = 663,

        [Description("Scatterbug")]
        Scatterbug = 664,

        [Description("Spewpa")]
        Spewpa = 665,

        [Description("Vivillon")]
        Vivillon = 666,

        [Description("Litleo")]
        Litleo = 667,

        [Description("Pyroar")]
        Pyroar = 668,

        [Description("Flabébé")]
        Flabebe = 669,

        [Description("Floette")]
        Floette = 670,

        [Description("Florges")]
        Florges = 671,

        [Description("Skiddo")]
        Skiddo = 672,

        [Description("Gogoat")]
        Gogoat = 673,

        [Description("Pancham")]
        Pancham = 674,

        [Description("Pangoro")]
        Pangoro = 675,

        [Description("Furfrou")]
        Furfrou = 676,

        [Description("Espurr")]
        Espurr = 677,

        [Description("Meowstic")]
        Meowstic = 678,

        [Description("Honedge")]
        Honedge = 679,

        [Description("Doublade")]
        Doublade = 680,

        [Description("Aegislash")]
        Aegislash = 681,

        [Description("Spritzee")]
        Spritzee = 682,

        [Description("Aromatisse")]
        Aromatisse = 683,

        [Description("Swirlix")]
        Swirlix = 684,

        [Description("Slurpuff")]
        Slurpuff = 685,

        [Description("Inkay")]
        Inkay = 686,

        [Description("Malamar")]
        Malamar = 687,

        [Description("Binacle")]
        Binacle = 688,

        [Description("Barbaracle")]
        Barbaracle = 689,

        [Description("Skrelp")]
        Skrelp = 690,

        [Description("Dragalge")]
        Dragalge = 691,

        [Description("Clauncher")]
        Clauncher = 692,

        [Description("Clawitzer")]
        Clawitzer = 693,

        [Description("Helioptile")]
        Helioptile = 694,

        [Description("Heliolisk")]
        Heliolisk = 695,

        [Description("Tyrunt")]
        Tyrunt = 696,

        [Description("Tyrantrum")]
        Tyrantrum = 697,

        [Description("Amaura")]
        Amaura = 698,

        [Description("Aurorus")]
        Aurorus = 699,

        [Description("Sylveon")]
        Sylveon = 700,

        [Description("Hawlucha")]
        Hawlucha = 701,

        [Description("Dedenne")]
        Dedenne = 702,

        [Description("Carbink")]
        Carbink = 703,

        [Description("Goomy")]
        Goomy = 704,

        [Description("Sliggoo")]
        Sliggoo = 705,

        [Description("Goodra")]
        Goodra = 706,

        [Description("Klefki")]
        Klefki = 707,

        [Description("Phantump")]
        Phantump = 708,

        [Description("Trevenant")]
        Trevenant = 709,

        [Description("Pumpkaboo")]
        Pumpkaboo = 710,

        [Description("Gourgeist")]
        Gourgeist = 711,

        [Description("Bergmite")]
        Bergmite = 712,

        [Description("Avalugg")]
        Avalugg = 713,

        [Description("Noibat")]
        Noibat = 714,

        [Description("Noivern")]
        Noivern = 715,

        [Description("Xerneas")]
        Xerneas = 716,

        [Description("Yveltal")]
        Yveltal = 717,

        [Description("Zygarde")]
        Zygarde = 718,

        [Description("Diancie")]
        Diancie = 719,

        [Description("Hoopa")]
        Hoopa = 720,

        [Description("Volcanion")]
        Volcanion = 721
    }

    public enum Moves : ushort
    {
        [Description("No Move")]
        NoMove = 0,

        [Description("Pound")]
        Pound = 1,

        [Description("Karate Chop")]
        Karate_Chop = 2,

        [Description("Double Slap")]
        Double_Slap = 3,

        [Description("Comet Punch")]
        Comet_Punch = 4,

        [Description("Mega Punch")]
        Mega_Punch = 5,

        [Description("Pay Day")]
        Pay_Day = 6,

        [Description("Fire Punch")]
        Fire_Punch = 7,

        [Description("Ice Punch")]
        Ice_Punch = 8,

        [Description("Thunder Punch")]
        Thunder_Punch = 9,

        [Description("Scratch")]
        Scratch = 10,

        [Description("Vice Grip")]
        Vice_Grip = 11,

        [Description("Guillotine")]
        Guillotine = 12,

        [Description("Razor Wind")]
        Razor_Wind = 13,

        [Description("Swords Dance")]
        Swords_Dance = 14,

        [Description("Cut")]
        Cut = 15,

        [Description("Gust")]
        Gust = 16,

        [Description("Wing Attack")]
        Wing_Attack = 17,

        [Description("Whirlwind")]
        Whirlwind = 18,

        [Description("Fly")]
        Fly = 19,

        [Description("Bind")]
        Bind = 20,

        [Description("Slam")]
        Slam = 21,

        [Description("Vine Whip")]
        Vine_Whip = 22,

        [Description("Stomp")]
        Stomp = 23,

        [Description("Double Kick")]
        Double_Kick = 24,

        [Description("Mega Kick")]
        Mega_Kick = 25,

        [Description("Jump Kick")]
        Jump_Kick = 26,

        [Description("Rolling Kick")]
        Rolling_Kick = 27,

        [Description("Sand Attack")]
        Sand_Attack = 28,

        [Description("Headbutt")]
        Headbutt = 29,

        [Description("Horn Attack")]
        Horn_Attack = 30,

        [Description("Fury Attack")]
        Fury_Attack = 31,

        [Description("Horn Drill")]
        Horn_Drill = 32,

        [Description("Tackle")]
        Tackle = 33,

        [Description("Body Slam")]
        Body_Slam = 34,

        [Description("Wrap")]
        Wrap = 35,

        [Description("Take Down")]
        Take_Down = 36,

        [Description("Thrash")]
        Thrash = 37,

        [Description("Double-Edge")]
        Double_Edge = 38,

        [Description("Tail Whip")]
        Tail_Whip = 39,

        [Description("Poison Sting")]
        Poison_Sting = 40,

        [Description("Twineedle")]
        Twineedle = 41,

        [Description("Pin Missile")]
        Pin_Missile = 42,

        [Description("Leer")]
        Leer = 43,

        [Description("Bite")]
        Bite = 44,

        [Description("Growl")]
        Growl = 45,

        [Description("Roar")]
        Roar = 46,

        [Description("Sing")]
        Sing = 47,

        [Description("Supersonic")]
        Supersonic = 48,

        [Description("Sonic Boom")]
        Sonic_Boom = 49,

        [Description("Disable")]
        Disable = 50,

        [Description("Acid")]
        Acid = 51,

        [Description("Ember")]
        Ember = 52,

        [Description("Flamethrower")]
        Flamethrower = 53,

        [Description("Mist")]
        Mist = 54,

        [Description("Water Gun")]
        Water_Gun = 55,

        [Description("Hydro Pump")]
        Hydro_Pump = 56,

        [Description("Surf")]
        Surf = 57,

        [Description("Ice Beam")]
        Ice_Beam = 58,

        [Description("Blizzard")]
        Blizzard = 59,

        [Description("Psybeam")]
        Psybeam = 60,

        [Description("Bubble Beam")]
        Bubble_Beam = 61,

        [Description("Aurora Beam")]
        Aurora_Beam = 62,

        [Description("Hyper Beam")]
        Hyper_Beam = 63,

        [Description("Peck")]
        Peck = 64,

        [Description("Drill Peck")]
        Drill_Peck = 65,

        [Description("Submission")]
        Submission = 66,

        [Description("Low Kick")]
        Low_Kick = 67,

        [Description("Counter")]
        Counter = 68,

        [Description("Seismic Toss")]
        Seismic_Toss = 69,

        [Description("Strength")]
        Strength = 70,

        [Description("Absorb")]
        Absorb = 71,

        [Description("Mega Drain")]
        Mega_Drain = 72,

        [Description("Leech Seed")]
        Leech_Seed = 73,

        [Description("Growth")]
        Growth = 74,

        [Description("Razor Leaf")]
        Razor_Leaf = 75,

        [Description("Solar Beam")]
        Solar_Beam = 76,

        [Description("Poison Powder")]
        Poison_Powder = 77,

        [Description("Stun Spore")]
        Stun_Spore = 78,

        [Description("Sleep Powder")]
        Sleep_Powder = 79,

        [Description("Petal Dance")]
        Petal_Dance = 80,

        [Description("String Shot")]
        String_Shot = 81,

        [Description("Dragon Rage")]
        Dragon_Rage = 82,

        [Description("Fire Spin")]
        Fire_Spin = 83,

        [Description("Thunder Shock")]
        Thunder_Shock = 84,

        [Description("Thunderbolt")]
        Thunderbolt = 85,

        [Description("Thunder Wave")]
        Thunder_Wave = 86,

        [Description("Thunder")]
        Thunder = 87,

        [Description("Rock Throw")]
        Rock_Throw = 88,

        [Description("Earthquake")]
        Earthquake = 89,

        [Description("Fissure")]
        Fissure = 90,

        [Description("Dig")]
        Dig = 91,

        [Description("Toxic")]
        Toxic = 92,

        [Description("Confusion")]
        Confusion = 93,

        [Description("Psychic")]
        Psychic = 94,

        [Description("Hypnosis")]
        Hypnosis = 95,

        [Description("Meditate")]
        Meditate = 96,

        [Description("Agility")]
        Agility = 97,

        [Description("Quick Attack")]
        Quick_Attack = 98,

        [Description("Rage")]
        Rage = 99,

        [Description("Teleport")]
        Teleport = 100,

        [Description("Night Shade")]
        Night_Shade = 101,

        [Description("Mimic")]
        Mimic = 102,

        [Description("Screech")]
        Screech = 103,

        [Description("Double Team")]
        Double_Team = 104,

        [Description("Recover")]
        Recover = 105,

        [Description("Harden")]
        Harden = 106,

        [Description("Minimize")]
        Minimize = 107,

        [Description("Smokescreen")]
        Smokescreen = 108,

        [Description("Confuse Ray")]
        Confuse_Ray = 109,

        [Description("Withdraw")]
        Withdraw = 110,

        [Description("Defense Curl")]
        Defense_Curl = 111,

        [Description("Barrier")]
        Barrier = 112,

        [Description("Light Screen")]
        Light_Screen = 113,

        [Description("Haze")]
        Haze = 114,

        [Description("Reflect")]
        Reflect = 115,

        [Description("Focus Energy")]
        Focus_Energy = 116,

        [Description("Bide")]
        Bide = 117,

        [Description("Metronome")]
        Metronome = 118,

        [Description("Mirror Move")]
        Mirror_Move = 119,

        [Description("Self-Destruct")]
        Self_Destruct = 120,

        [Description("Egg Bomb")]
        Egg_Bomb = 121,

        [Description("Lick")]
        Lick = 122,

        [Description("Smog")]
        Smog = 123,

        [Description("Sludge")]
        Sludge = 124,

        [Description("Bone Club")]
        Bone_Club = 125,

        [Description("Fire Blast")]
        Fire_Blast = 126,

        [Description("Waterfall")]
        Waterfall = 127,

        [Description("Clamp")]
        Clamp = 128,

        [Description("Swift")]
        Swift = 129,

        [Description("Skull Bash")]
        Skull_Bash = 130,

        [Description("Spike Cannon")]
        Spike_Cannon = 131,

        [Description("Constrict")]
        Constrict = 132,

        [Description("Amnesia")]
        Amnesia = 133,

        [Description("Kinesis")]
        Kinesis = 134,

        [Description("Soft-Boiled")]
        Soft_Boiled = 135,

        [Description("High Jump Kick")]
        High_Jump_Kick = 136,

        [Description("Glare")]
        Glare = 137,

        [Description("Dream Eater")]
        Dream_Eater = 138,

        [Description("Poison Gas")]
        Poison_Gas = 139,

        [Description("Barrage")]
        Barrage = 140,

        [Description("Leech Life")]
        Leech_Life = 141,

        [Description("Lovely Kiss")]
        Lovely_Kiss = 142,

        [Description("Sky Attack")]
        Sky_Attack = 143,

        [Description("Transform")]
        Transform = 144,

        [Description("Bubble")]
        Bubble = 145,

        [Description("Dizzy Punch")]
        Dizzy_Punch = 146,

        [Description("Spore")]
        Spore = 147,

        [Description("Flash")]
        Flash = 148,

        [Description("Psywave")]
        Psywave = 149,

        [Description("Splash")]
        Splash = 150,

        [Description("Acid Armor")]
        Acid_Armor = 151,

        [Description("Crabhammer")]
        Crabhammer = 152,

        [Description("Explosion")]
        Explosion = 153,

        [Description("Fury Swipes")]
        Fury_Swipes = 154,

        [Description("Bonemerang")]
        Bonemerang = 155,

        [Description("Rest")]
        Rest = 156,

        [Description("Rock Slide")]
        Rock_Slide = 157,

        [Description("Hyper Fang")]
        Hyper_Fang = 158,

        [Description("Sharpen")]
        Sharpen = 159,

        [Description("Conversion")]
        Conversion = 160,

        [Description("Tri Attack")]
        Tri_Attack = 161,

        [Description("Super Fang")]
        Super_Fang = 162,

        [Description("Slash")]
        Slash = 163,

        [Description("Substitute")]
        Substitute = 164,

        [Description("Struggle")]
        Struggle = 165,

        [Description("Sketch")]
        Sketch = 166,

        [Description("Triple Kick")]
        Triple_Kick = 167,

        [Description("Thief")]
        Thief = 168,

        [Description("Spider Web")]
        Spider_Web = 169,

        [Description("Mind Reader")]
        Mind_Reader = 170,

        [Description("Nightmare")]
        Nightmare = 171,

        [Description("Flame Wheel")]
        Flame_Wheel = 172,

        [Description("Snore")]
        Snore = 173,

        [Description("Curse")]
        Curse = 174,

        [Description("Flail")]
        Flail = 175,

        [Description("Conversion 2")]
        Conversion_2 = 176,

        [Description("Aeroblast")]
        Aeroblast = 177,

        [Description("Cotton Spore")]
        Cotton_Spore = 178,

        [Description("Reversal")]
        Reversal = 179,

        [Description("Spite")]
        Spite = 180,

        [Description("Powder Snow")]
        Powder_Snow = 181,

        [Description("Protect")]
        Protect = 182,

        [Description("Mach Punch")]
        Mach_Punch = 183,

        [Description("Scary Face")]
        Scary_Face = 184,

        [Description("Feint Attack")]
        Feint_Attack = 185,

        [Description("Sweet Kiss")]
        Sweet_Kiss = 186,

        [Description("Belly Drum")]
        Belly_Drum = 187,

        [Description("Sludge Bomb")]
        Sludge_Bomb = 188,

        [Description("Mud-Slap")]
        Mud_Slap = 189,

        [Description("Octazooka")]
        Octazooka = 190,

        [Description("Spikes")]
        Spikes = 191,

        [Description("Zap Cannon")]
        Zap_Cannon = 192,

        [Description("Foresight")]
        Foresight = 193,

        [Description("Destiny Bond")]
        Destiny_Bond = 194,

        [Description("Perish Song")]
        Perish_Song = 195,

        [Description("Icy Wind")]
        Icy_Wind = 196,

        [Description("Detect")]
        Detect = 197,

        [Description("Bone Rush")]
        Bone_Rush = 198,

        [Description("Lock-On")]
        Lock_On = 199,

        [Description("Outrage")]
        Outrage = 200,

        [Description("Sandstorm")]
        Sandstorm = 201,

        [Description("Giga Drain")]
        Giga_Drain = 202,

        [Description("Endure")]
        Endure = 203,

        [Description("Charm")]
        Charm = 204,

        [Description("Rollout")]
        Rollout = 205,

        [Description("False Swipe")]
        False_Swipe = 206,

        [Description("Swagger")]
        Swagger = 207,

        [Description("Milk Drink")]
        Milk_Drink = 208,

        [Description("Spark")]
        Spark = 209,

        [Description("Fury Cutter")]
        Fury_Cutter = 210,

        [Description("Steel Wing")]
        Steel_Wing = 211,

        [Description("Mean Look")]
        Mean_Look = 212,

        [Description("Attract")]
        Attract = 213,

        [Description("Sleep Talk")]
        Sleep_Talk = 214,

        [Description("Heal Bell")]
        Heal_Bell = 215,

        [Description("Return")]
        Return = 216,

        [Description("Present")]
        Present = 217,

        [Description("Frustration")]
        Frustration = 218,

        [Description("Safeguard")]
        Safeguard = 219,

        [Description("Pain Split")]
        Pain_Split = 220,

        [Description("Sacred Fire")]
        Sacred_Fire = 221,

        [Description("Magnitude")]
        Magnitude = 222,

        [Description("Dynamic Punch")]
        Dynamic_Punch = 223,

        [Description("Megahorn")]
        Megahorn = 224,

        [Description("Dragon Breath")]
        Dragon_Breath = 225,

        [Description("Baton Pass")]
        Baton_Pass = 226,

        [Description("Encore")]
        Encore = 227,

        [Description("Pursuit")]
        Pursuit = 228,

        [Description("Rapid Spin")]
        Rapid_Spin = 229,

        [Description("Sweet Scent")]
        Sweet_Scent = 230,

        [Description("Iron Tail")]
        Iron_Tail = 231,

        [Description("Metal Claw")]
        Metal_Claw = 232,

        [Description("Vital Throw")]
        Vital_Throw = 233,

        [Description("Morning Sun")]
        Morning_Sun = 234,

        [Description("Synthesis")]
        Synthesis = 235,

        [Description("Moonlight")]
        Moonlight = 236,

        [Description("Hidden Power")]
        Hidden_Power = 237,

        [Description("Cross Chop")]
        Cross_Chop = 238,

        [Description("Twister")]
        Twister = 239,

        [Description("Rain Dance")]
        Rain_Dance = 240,

        [Description("Sunny Day")]
        Sunny_Day = 241,

        [Description("Crunch")]
        Crunch = 242,

        [Description("Mirror Coat")]
        Mirror_Coat = 243,

        [Description("Psych Up")]
        Psych_Up = 244,

        [Description("Extreme Speed")]
        Extreme_Speed = 245,

        [Description("Ancient Power")]
        Ancient_Power = 246,

        [Description("Shadow Ball")]
        Shadow_Ball = 247,

        [Description("Future Sight")]
        Future_Sight = 248,

        [Description("Rock Smash")]
        Rock_Smash = 249,

        [Description("Whirlpool")]
        Whirlpool = 250,

        [Description("Beat Up")]
        Beat_Up = 251,

        [Description("Fake Out")]
        Fake_Out = 252,

        [Description("Uproar")]
        Uproar = 253,

        [Description("Stockpile")]
        Stockpile = 254,

        [Description("Spit Up")]
        Spit_Up = 255,

        [Description("Swallow")]
        Swallow = 256,

        [Description("Heat Wave")]
        Heat_Wave = 257,

        [Description("Hail")]
        Hail = 258,

        [Description("Torment")]
        Torment = 259,

        [Description("Flatter")]
        Flatter = 260,

        [Description("Will-O-Wisp")]
        Will_O_Wisp = 261,

        [Description("Memento")]
        Memento = 262,

        [Description("Facade")]
        Facade = 263,

        [Description("Focus Punch")]
        Focus_Punch = 264,

        [Description("Smelling Salts")]
        Smelling_Salts = 265,

        [Description("Follow Me")]
        Follow_Me = 266,

        [Description("Nature Power")]
        Nature_Power = 267,

        [Description("Charge")]
        Charge = 268,

        [Description("Taunt")]
        Taunt = 269,

        [Description("Helping Hand")]
        Helping_Hand = 270,

        [Description("Trick")]
        Trick = 271,

        [Description("Role Play")]
        Role_Play = 272,

        [Description("Wish")]
        Wish = 273,

        [Description("Assist")]
        Assist = 274,

        [Description("Ingrain")]
        Ingrain = 275,

        [Description("Superpower")]
        Superpower = 276,

        [Description("Magic Coat")]
        Magic_Coat = 277,

        [Description("Recycle")]
        Recycle = 278,

        [Description("Revenge")]
        Revenge = 279,

        [Description("Brick Break")]
        Brick_Break = 280,

        [Description("Yawn")]
        Yawn = 281,

        [Description("Knock Off")]
        Knock_Off = 282,

        [Description("Endeavor")]
        Endeavor = 283,

        [Description("Eruption")]
        Eruption = 284,

        [Description("Skill Swap")]
        Skill_Swap = 285,

        [Description("Imprison")]
        Imprison = 286,

        [Description("Refresh")]
        Refresh = 287,

        [Description("Grudge")]
        Grudge = 288,

        [Description("Snatch")]
        Snatch = 289,

        [Description("Secret Power")]
        Secret_Power = 290,

        [Description("Dive")]
        Dive = 291,

        [Description("Arm Thrust")]
        Arm_Thrust = 292,

        [Description("Camouflage")]
        Camouflage = 293,

        [Description("Tail Glow")]
        Tail_Glow = 294,

        [Description("Luster Purge")]
        Luster_Purge = 295,

        [Description("Mist Ball")]
        Mist_Ball = 296,

        [Description("Feather Dance")]
        Feather_Dance = 297,

        [Description("Teeter Dance")]
        Teeter_Dance = 298,

        [Description("Blaze Kick")]
        Blaze_Kick = 299,

        [Description("Mud Sport")]
        Mud_Sport = 300,

        [Description("Ice Ball")]
        Ice_Ball = 301,

        [Description("Needle Arm")]
        Needle_Arm = 302,

        [Description("Slack Off")]
        Slack_Off = 303,

        [Description("Hyper Voice")]
        Hyper_Voice = 304,

        [Description("Poison Fang")]
        Poison_Fang = 305,

        [Description("Crush Claw")]
        Crush_Claw = 306,

        [Description("Blast Burn")]
        Blast_Burn = 307,

        [Description("Hydro Cannon")]
        Hydro_Cannon = 308,

        [Description("Meteor Mash")]
        Meteor_Mash = 309,

        [Description("Astonish")]
        Astonish = 310,

        [Description("Weather Ball")]
        Weather_Ball = 311,

        [Description("Aromatherapy")]
        Aromatherapy = 312,

        [Description("Fake Tears")]
        Fake_Tears = 313,

        [Description("Air Cutter")]
        Air_Cutter = 314,

        [Description("Overheat")]
        Overheat = 315,

        [Description("Odor Sleuth")]
        Odor_Sleuth = 316,

        [Description("Rock Tomb")]
        Rock_Tomb = 317,

        [Description("Silver Wind")]
        Silver_Wind = 318,

        [Description("Metal Sound")]
        Metal_Sound = 319,

        [Description("Grass Whistle")]
        Grass_Whistle = 320,

        [Description("Tickle")]
        Tickle = 321,

        [Description("Cosmic Power")]
        Cosmic_Power = 322,

        [Description("Water Spout")]
        Water_Spout = 323,

        [Description("Signal Beam")]
        Signal_Beam = 324,

        [Description("Shadow Punch")]
        Shadow_Punch = 325,

        [Description("Extrasensory")]
        Extrasensory = 326,

        [Description("Sky Uppercut")]
        Sky_Uppercut = 327,

        [Description("Sand Tomb")]
        Sand_Tomb = 328,

        [Description("Sheer Cold")]
        Sheer_Cold = 329,

        [Description("Muddy Water")]
        Muddy_Water = 330,

        [Description("Bullet Seed")]
        Bullet_Seed = 331,

        [Description("Aerial Ace")]
        Aerial_Ace = 332,

        [Description("Icicle Spear")]
        Icicle_Spear = 333,

        [Description("Iron Defense")]
        Iron_Defense = 334,

        [Description("Block")]
        Block = 335,

        [Description("Howl")]
        Howl = 336,

        [Description("Dragon Claw")]
        Dragon_Claw = 337,

        [Description("Frenzy Plant")]
        Frenzy_Plant = 338,

        [Description("Bulk Up")]
        Bulk_Up = 339,

        [Description("Bounce")]
        Bounce = 340,

        [Description("Mud Shot")]
        Mud_Shot = 341,

        [Description("Poison Tail")]
        Poison_Tail = 342,

        [Description("Covet")]
        Covet = 343,

        [Description("Volt Tackle")]
        Volt_Tackle = 344,

        [Description("Magical Leaf")]
        Magical_Leaf = 345,

        [Description("Water Sport")]
        Water_Sport = 346,

        [Description("Calm Mind")]
        Calm_Mind = 347,

        [Description("Leaf Blade")]
        Leaf_Blade = 348,

        [Description("Dragon Dance")]
        Dragon_Dance = 349,

        [Description("Rock Blast")]
        Rock_Blast = 350,

        [Description("Shock Wave")]
        Shock_Wave = 351,

        [Description("Water Pulse")]
        Water_Pulse = 352,

        [Description("Doom Desire")]
        Doom_Desire = 353,

        [Description("Psycho Boost")]
        Psycho_Boost = 354,

        [Description("Roost")]
        Roost = 355,

        [Description("Gravity")]
        Gravity = 356,

        [Description("Miracle Eye")]
        Miracle_Eye = 357,

        [Description("Wake-Up Slap")]
        Wake_Up_Slap = 358,

        [Description("Hammer Arm")]
        Hammer_Arm = 359,

        [Description("Gyro Ball")]
        Gyro_Ball = 360,

        [Description("Healing Wish")]
        Healing_Wish = 361,

        [Description("Brine")]
        Brine = 362,

        [Description("Natural Gift")]
        Natural_Gift = 363,

        [Description("Feint")]
        Feint = 364,

        [Description("Pluck")]
        Pluck = 365,

        [Description("Tailwind")]
        Tailwind = 366,

        [Description("Acupressure")]
        Acupressure = 367,

        [Description("Metal Burst")]
        Metal_Burst = 368,

        [Description("U-turn")]
        U_turn = 369,

        [Description("Close Combat")]
        Close_Combat = 370,

        [Description("Payback")]
        Payback = 371,

        [Description("Assurance")]
        Assurance = 372,

        [Description("Embargo")]
        Embargo = 373,

        [Description("Fling")]
        Fling = 374,

        [Description("Psycho Shift")]
        Psycho_Shift = 375,

        [Description("Trump Card")]
        Trump_Card = 376,

        [Description("Heal Block")]
        Heal_Block = 377,

        [Description("Wring Out")]
        Wring_Out = 378,

        [Description("Power Trick")]
        Power_Trick = 379,

        [Description("Gastro Acid")]
        Gastro_Acid = 380,

        [Description("Lucky Chant")]
        Lucky_Chant = 381,

        [Description("Me First")]
        Me_First = 382,

        [Description("Copycat")]
        Copycat = 383,

        [Description("Power Swap")]
        Power_Swap = 384,

        [Description("Guard Swap")]
        Guard_Swap = 385,

        [Description("Punishment")]
        Punishment = 386,

        [Description("Last Resort")]
        Last_Resort = 387,

        [Description("Worry Seed")]
        Worry_Seed = 388,

        [Description("Sucker Punch")]
        Sucker_Punch = 389,

        [Description("Toxic Spikes")]
        Toxic_Spikes = 390,

        [Description("Heart Swap")]
        Heart_Swap = 391,

        [Description("Aqua Ring")]
        Aqua_Ring = 392,

        [Description("Magnet Rise")]
        Magnet_Rise = 393,

        [Description("Flare Blitz")]
        Flare_Blitz = 394,

        [Description("Force Palm")]
        Force_Palm = 395,

        [Description("Aura Sphere")]
        Aura_Sphere = 396,

        [Description("Rock Polish")]
        Rock_Polish = 397,

        [Description("Poison Jab")]
        Poison_Jab = 398,

        [Description("Dark Pulse")]
        Dark_Pulse = 399,

        [Description("Night Slash")]
        Night_Slash = 400,

        [Description("Aqua Tail")]
        Aqua_Tail = 401,

        [Description("Seed Bomb")]
        Seed_Bomb = 402,

        [Description("Air Slash")]
        Air_Slash = 403,

        [Description("X-Scissor")]
        X_Scissor = 404,

        [Description("Bug Buzz")]
        Bug_Buzz = 405,

        [Description("Dragon Pulse")]
        Dragon_Pulse = 406,

        [Description("Dragon Rush")]
        Dragon_Rush = 407,

        [Description("Power Gem")]
        Power_Gem = 408,

        [Description("Drain Punch")]
        Drain_Punch = 409,

        [Description("Vacuum Wave")]
        Vacuum_Wave = 410,

        [Description("Focus Blast")]
        Focus_Blast = 411,

        [Description("Energy Ball")]
        Energy_Ball = 412,

        [Description("Brave Bird")]
        Brave_Bird = 413,

        [Description("Earth Power")]
        Earth_Power = 414,

        [Description("Switcheroo")]
        Switcheroo = 415,

        [Description("Giga Impact")]
        Giga_Impact = 416,

        [Description("Nasty Plot")]
        Nasty_Plot = 417,

        [Description("Bullet Punch")]
        Bullet_Punch = 418,

        [Description("Avalanche")]
        Avalanche = 419,

        [Description("Ice Shard")]
        Ice_Shard = 420,

        [Description("Shadow Claw")]
        Shadow_Claw = 421,

        [Description("Thunder Fang")]
        Thunder_Fang = 422,

        [Description("Ice Fang")]
        Ice_Fang = 423,

        [Description("Fire Fang")]
        Fire_Fang = 424,

        [Description("Shadow Sneak")]
        Shadow_Sneak = 425,

        [Description("Mud Bomb")]
        Mud_Bomb = 426,

        [Description("Psycho Cut")]
        Psycho_Cut = 427,

        [Description("Zen Headbutt")]
        Zen_Headbutt = 428,

        [Description("Mirror Shot")]
        Mirror_Shot = 429,

        [Description("Flash Cannon")]
        Flash_Cannon = 430,

        [Description("Rock Climb")]
        Rock_Climb = 431,

        [Description("Defog")]
        Defog = 432,

        [Description("Trick Room")]
        Trick_Room = 433,

        [Description("Draco Meteor")]
        Draco_Meteor = 434,

        [Description("Discharge")]
        Discharge = 435,

        [Description("Lava Plume")]
        Lava_Plume = 436,

        [Description("Leaf Storm")]
        Leaf_Storm = 437,

        [Description("Power Whip")]
        Power_Whip = 438,

        [Description("Rock Wrecker")]
        Rock_Wrecker = 439,

        [Description("Cross Poison")]
        Cross_Poison = 440,

        [Description("Gunk Shot")]
        Gunk_Shot = 441,

        [Description("Iron Head")]
        Iron_Head = 442,

        [Description("Magnet Bomb")]
        Magnet_Bomb = 443,

        [Description("Stone Edge")]
        Stone_Edge = 444,

        [Description("Captivate")]
        Captivate = 445,

        [Description("Stealth Rock")]
        Stealth_Rock = 446,

        [Description("Grass Knot")]
        Grass_Knot = 447,

        [Description("Chatter")]
        Chatter = 448,

        [Description("Judgment")]
        Judgment = 449,

        [Description("Bug Bite")]
        Bug_Bite = 450,

        [Description("Charge Beam")]
        Charge_Beam = 451,

        [Description("Wood Hammer")]
        Wood_Hammer = 452,

        [Description("Aqua Jet")]
        Aqua_Jet = 453,

        [Description("Attack Order")]
        Attack_Order = 454,

        [Description("Defend Order")]
        Defend_Order = 455,

        [Description("Heal Order")]
        Heal_Order = 456,

        [Description("Head Smash")]
        Head_Smash = 457,

        [Description("Double Hit")]
        Double_Hit = 458,

        [Description("Roar of Time")]
        Roar_of_Time = 459,

        [Description("Spacial Rend")]
        Spacial_Rend = 460,

        [Description("Lunar Dance")]
        Lunar_Dance = 461,

        [Description("Crush Grip")]
        Crush_Grip = 462,

        [Description("Magma Storm")]
        Magma_Storm = 463,

        [Description("Dark Void")]
        Dark_Void = 464,

        [Description("Seed Flare")]
        Seed_Flare = 465,

        [Description("Ominous Wind")]
        Ominous_Wind = 466,

        [Description("Shadow Force")]
        Shadow_Force = 467,

        [Description("Hone Claws")]
        Hone_Claws = 468,

        [Description("Wide Guard")]
        Wide_Guard = 469,

        [Description("Guard Split")]
        Guard_Split = 470,

        [Description("Power Split")]
        Power_Split = 471,

        [Description("Wonder Room")]
        Wonder_Room = 472,

        [Description("Psyshock")]
        Psyshock = 473,

        [Description("Venoshock")]
        Venoshock = 474,

        [Description("Autotomize")]
        Autotomize = 475,

        [Description("Rage Powder")]
        Rage_Powder = 476,

        [Description("Telekinesis")]
        Telekinesis = 477,

        [Description("Magic Room")]
        Magic_Room = 478,

        [Description("Smack Down")]
        Smack_Down = 479,

        [Description("Storm Throw")]
        Storm_Throw = 480,

        [Description("Flame Burst")]
        Flame_Burst = 481,

        [Description("Sludge Wave")]
        Sludge_Wave = 482,

        [Description("Quiver Dance")]
        Quiver_Dance = 483,

        [Description("Heavy Slam")]
        Heavy_Slam = 484,

        [Description("Synchronoise")]
        Synchronoise = 485,

        [Description("Electro Ball")]
        Electro_Ball = 486,

        [Description("Soak")]
        Soak = 487,

        [Description("Flame Charge")]
        Flame_Charge = 488,

        [Description("Coil")]
        Coil = 489,

        [Description("Low Sweep")]
        Low_Sweep = 490,

        [Description("Acid Spray")]
        Acid_Spray = 491,

        [Description("Foul Play")]
        Foul_Play = 492,

        [Description("Simple Beam")]
        Simple_Beam = 493,

        [Description("Entrainment")]
        Entrainment = 494,

        [Description("After You")]
        After_You = 495,

        [Description("Round")]
        Round = 496,

        [Description("Echoed Voice")]
        Echoed_Voice = 497,

        [Description("Chip Away")]
        Chip_Away = 498,

        [Description("Clear Smog")]
        Clear_Smog = 499,

        [Description("Stored Power")]
        Stored_Power = 500,

        [Description("Quick Guard")]
        Quick_Guard = 501,

        [Description("Ally Switch")]
        Ally_Switch = 502,

        [Description("Scald")]
        Scald = 503,

        [Description("Shell Smash")]
        Shell_Smash = 504,

        [Description("Heal Pulse")]
        Heal_Pulse = 505,

        [Description("Hex")]
        Hex = 506,

        [Description("Sky Drop")]
        Sky_Drop = 507,

        [Description("Shift Gear")]
        Shift_Gear = 508,

        [Description("Circle Throw")]
        Circle_Throw = 509,

        [Description("Incinerate")]
        Incinerate = 510,

        [Description("Quash")]
        Quash = 511,

        [Description("Acrobatics")]
        Acrobatics = 512,

        [Description("Reflect Type")]
        Reflect_Type = 513,

        [Description("Retaliate")]
        Retaliate = 514,

        [Description("Final Gambit")]
        Final_Gambit = 515,

        [Description("Bestow")]
        Bestow = 516,

        [Description("Inferno")]
        Inferno = 517,

        [Description("Water Pledge")]
        Water_Pledge = 518,

        [Description("Fire Pledge")]
        Fire_Pledge = 519,

        [Description("Grass Pledge")]
        Grass_Pledge = 520,

        [Description("Volt Switch")]
        Volt_Switch = 521,

        [Description("Struggle Bug")]
        Struggle_Bug = 522,

        [Description("Bulldoze")]
        Bulldoze = 523,

        [Description("Frost Breath")]
        Frost_Breath = 524,

        [Description("Dragon Tail")]
        Dragon_Tail = 525,

        [Description("Work Up")]
        Work_Up = 526,

        [Description("Electroweb")]
        Electroweb = 527,

        [Description("Wild Charge")]
        Wild_Charge = 528,

        [Description("Drill Run")]
        Drill_Run = 529,

        [Description("Dual Chop")]
        Dual_Chop = 530,

        [Description("Heart Stamp")]
        Heart_Stamp = 531,

        [Description("Horn Leech")]
        Horn_Leech = 532,

        [Description("Sacred Sword")]
        Sacred_Sword = 533,

        [Description("Razor Shell")]
        Razor_Shell = 534,

        [Description("Heat Crash")]
        Heat_Crash = 535,

        [Description("Leaf Tornado")]
        Leaf_Tornado = 536,

        [Description("Steamroller")]
        Steamroller = 537,

        [Description("Cotton Guard")]
        Cotton_Guard = 538,

        [Description("Night Daze")]
        Night_Daze = 539,

        [Description("Psystrike")]
        Psystrike = 540,

        [Description("Tail Slap")]
        Tail_Slap = 541,

        [Description("Hurricane")]
        Hurricane = 542,

        [Description("Head Charge")]
        Head_Charge = 543,

        [Description("Gear Grind")]
        Gear_Grind = 544,

        [Description("Searing Shot")]
        Searing_Shot = 545,

        [Description("Techno Blast")]
        Techno_Blast = 546,

        [Description("Relic Song")]
        Relic_Song = 547,

        [Description("Secret Sword")]
        Secret_Sword = 548,

        [Description("Glaciate")]
        Glaciate = 549,

        [Description("Bolt Strike")]
        Bolt_Strike = 550,

        [Description("Blue Flare")]
        Blue_Flare = 551,

        [Description("Fiery Dance")]
        Fiery_Dance = 552,

        [Description("Freeze Shock")]
        Freeze_Shock = 553,

        [Description("Ice Burn")]
        Ice_Burn = 554,

        [Description("Snarl")]
        Snarl = 555,

        [Description("Icicle Crash")]
        Icicle_Crash = 556,

        [Description("V-create")]
        V_create = 557,

        [Description("Fusion Flare")]
        Fusion_Flare = 558,

        [Description("Fusion Bolt")]
        Fusion_Bolt = 559,

        [Description("Flying Press")]
        Flying_Press = 560,

        [Description("Mat Block")]
        Mat_Block = 561,

        [Description("Belch")]
        Belch = 562,

        [Description("Rototiller")]
        Rototiller = 563,

        [Description("Sticky Web")]
        Sticky_Web = 564,

        [Description("Fell Stinger")]
        Fell_Stinger = 565,

        [Description("Phantom Force")]
        Phantom_Force = 566,

        [Description("Trick-or-Treat")]
        Trick_or_Treat = 567,

        [Description("Noble Roar")]
        Noble_Roar = 568,

        [Description("Ion Deluge")]
        Ion_Deluge = 569,

        [Description("Parabolic Charge")]
        Parabolic_Charge = 570,

        [Description("Forest's Curse")]
        Forests_Curse = 571,

        [Description("Petal Blizzard")]
        Petal_Blizzard = 572,

        [Description("Freeze-Dry")]
        Freeze_Dry = 573,

        [Description("Disarming Voice")]
        Disarming_Voice = 574,

        [Description("Parting Shot")]
        Parting_Shot = 575,

        [Description("Topsy-Turvy")]
        Topsy_Turvy = 576,

        [Description("Draining Kiss")]
        Draining_Kiss = 577,

        [Description("Crafty Shield")]
        Crafty_Shield = 578,

        [Description("Flower Shield")]
        Flower_Shield = 579,

        [Description("Grassy Terrain")]
        Grassy_Terrain = 580,

        [Description("Misty Terrain")]
        Misty_Terrain = 581,

        [Description("Electrify")]
        Electrify = 582,

        [Description("Play Rough")]
        Play_Rough = 583,

        [Description("Fairy Wind")]
        Fairy_Wind = 584,

        [Description("Moonblast")]
        Moonblast = 585,

        [Description("Boomburst")]
        Boomburst = 586,

        [Description("Fairy Lock")]
        Fairy_Lock = 587,

        [Description("King's Shield")]
        Kings_Shield = 588,

        [Description("Play Nice")]
        Play_Nice = 589,

        [Description("Confide")]
        Confide = 590,

        [Description("Diamond Storm")]
        Diamond_Storm = 591,

        [Description("Steam Eruption")]
        Steam_Eruption = 592,

        [Description("Hyperspace Hole")]
        Hyperspace_Hole = 593,

        [Description("Water Shuriken")]
        Water_Shuriken = 594,

        [Description("Mystical Fire")]
        Mystical_Fire = 595,

        [Description("Spiky Shield")]
        Spiky_Shield = 596,

        [Description("Aromatic Mist")]
        Aromatic_Mist = 597,

        [Description("Eerie Impulse")]
        Eerie_Impulse = 598,

        [Description("Venom Drench")]
        Venom_Drench = 599,

        [Description("Powder")]
        Powder = 600,

        [Description("Geomancy")]
        Geomancy = 601,

        [Description("Magnetic Flux")]
        Magnetic_Flux = 602,

        [Description("Happy Hour")]
        Happy_Hour = 603,

        [Description("Electric Terrain")]
        Electric_Terrain = 604,

        [Description("Dazzling Gleam")]
        Dazzling_Gleam = 605,

        [Description("Celebrate")]
        Celebrate = 606,

        [Description("Hold Hands")]
        Hold_Hands = 607,

        [Description("Baby-Doll Eyes")]
        Baby_Doll_Eyes = 608,

        [Description("Nuzzle")]
        Nuzzle = 609,

        [Description("Hold Back")]
        Hold_Back = 610,

        [Description("Infestation")]
        Infestation = 611,

        [Description("Power-Up Punch")]
        Power_Up_Punch = 612,

        [Description("Oblivion Wing")]
        Oblivion_Wing = 613,

        [Description("Thousand Arrows")]
        Thousand_Arrows = 614,

        [Description("Thousand Waves")]
        Thousand_Waves = 615,

        [Description("Land's Wrath")]
        Lands_Wrath = 616,

        [Description("Light of Ruin")]
        Light_of_Ruin = 617,

        [Description("Origin Pulse")]
        Origin_Pulse = 618,

        [Description("Precipice Blades")]
        Precipice_Blades = 619,

        [Description("Dragon Ascent")]
        Dragon_Ascent = 620,

        [Description("Hyperspace Fury")]
        Hyperspace_Fury = 621
    }

    public enum Items : ushort
    {
        [Description("No Item")]
        NoItem = 0x0000,

        [Description("Master Ball")]
        Master_Ball = 0x0001,

        [Description("Ultra Ball")]
        Ultra_Ball = 0x0002,

        [Description("Great Ball")]
        Great_Ball = 0x0003,

        [Description("Poké Ball")]
        Poke_Ball = 0x0004,

        [Description("Safari Ball")]
        Safari_Ball = 0x0005,

        [Description("Net Ball")]
        Net_Ball = 0x0006,

        [Description("Dive Ball")]
        Dive_Ball = 0x0007,

        [Description("Nest Ball")]
        Nest_Ball = 0x0008,

        [Description("Repeat Ball")]
        Repeat_Ball = 0x0009,

        [Description("Timer Ball")]
        Timer_Ball = 0x000A,

        [Description("Luxury Ball")]
        Luxury_Ball = 0x000B,

        [Description("Premier Ball")]
        Premier_Ball = 0x000C,

        [Description("Dusk Ball")]
        Dusk_Ball = 0x000D,

        [Description("Heal Ball")]
        Heal_Ball = 0x000E,

        [Description("Quick Ball")]
        Quick_Ball = 0x000F,

        [Description("Cherish Ball")]
        Cherish_Ball = 0x0010,

        [Description("Potion")]
        Potion = 0x0011,

        [Description("Antidote")]
        Antidote = 0x0012,

        [Description("Burn Heal")]
        Burn_Heal = 0x0013,

        [Description("Ice Heal")]
        Ice_Heal = 0x0014,

        [Description("Awakening")]
        Awakening = 0x0015,

        [Description("Paralyze Heal")]
        Paralyze_Heal = 0x0016,

        [Description("Full Restore")]
        Full_Restore = 0x0017,

        [Description("Max Potion")]
        Max_Potion = 0x0018,

        [Description("Hyper Potion")]
        Hyper_Potion = 0x0019,

        [Description("Super Potion")]
        Super_Potion = 0x001A,

        [Description("Full Heal")]
        Full_Heal = 0x001B,

        [Description("Revive")]
        Revive = 0x001C,

        [Description("Max Revive")]
        Max_Revive = 0x001D,

        [Description("Fresh Water")]
        Fresh_Water = 0x001E,

        [Description("Soda Pop")]
        Soda_Pop = 0x001F,

        [Description("Lemonade")]
        Lemonade = 0x0020,

        [Description("Moomoo Milk")]
        Moomoo_Milk = 0x0021,

        [Description("Energy Powder")]
        Energy_Powder = 0x0022,

        [Description("Energy Root")]
        Energy_Root = 0x0023,

        [Description("Heal Powder")]
        Heal_Powder = 0x0024,

        [Description("Revival Herb")]
        Revival_Herb = 0x0025,

        [Description("Ether")]
        Ether = 0x0026,

        [Description("Max Ether")]
        Max_Ether = 0x0027,

        [Description("Elixir")]
        Elixir = 0x0028,

        [Description("Max Elixir")]
        Max_Elixir = 0x0029,

        [Description("Lava Cookie")]
        Lava_Cookie = 0x002A,

        [Description("Berry Juice")]
        Berry_Juice = 0x002B,

        [Description("Sacred Ash")]
        Sacred_Ash = 0x002C,

        [Description("HP Up")]
        HP_Up = 0x002D,

        [Description("Protein")]
        Protein = 0x002E,

        [Description("Iron")]
        Iron = 0x002F,

        [Description("Carbos")]
        Carbos = 0x0030,

        [Description("Calcium")]
        Calcium = 0x0031,

        [Description("Rare Candy")]
        Rare_Candy = 0x0032,

        [Description("PP Up")]
        PP_Up = 0x0033,

        [Description("Zinc")]
        Zinc = 0x0034,

        [Description("PP Max")]
        PP_Max = 0x0035,

        [Description("Old Gateau")]
        Old_Gateau = 0x0036,

        [Description("Guard Spec.")]
        Guard_Spec = 0x0037,

        [Description("Dire Hit")]
        Dire_Hit = 0x0038,

        [Description("X Attack")]
        X_Attack = 0x0039,

        [Description("X Defense")]
        X_Defense = 0x003A,

        [Description("X Speed")]
        X_Speed = 0x003B,

        [Description("X Accuracy")]
        X_Accuracy = 0x003C,

        [Description("X Sp. Atk")]
        X_Sp_Atk = 0x003D,

        [Description("X Sp. Def")]
        X_Sp_Def = 0x003E,

        [Description("Poké Doll")]
        Poke_Doll = 0x003F,

        [Description("Fluffy Tail")]
        Fluffy_Tail = 0x0040,

        [Description("Blue Flute")]
        Blue_Flute = 0x0041,

        [Description("Yellow Flute")]
        Yellow_Flute = 0x0042,

        [Description("Red Flute")]
        Red_Flute = 0x0043,

        [Description("Black Flute")]
        Black_Flute = 0x0044,

        [Description("White Flute")]
        White_Flute = 0x0045,

        [Description("Shoal Salt")]
        Shoal_Salt = 0x0046,

        [Description("Shoal Shell")]
        Shoal_Shell = 0x0047,

        [Description("Red Shard")]
        Red_Shard = 0x0048,

        [Description("Blue Shard")]
        Blue_Shard = 0x0049,

        [Description("Yellow Shard")]
        Yellow_Shard = 0x004A,

        [Description("Green Shard")]
        Green_Shard = 0x004B,

        [Description("Super Repel")]
        Super_Repel = 0x004C,

        [Description("Max Repel")]
        Max_Repel = 0x004D,

        [Description("Escape Rope")]
        Escape_Rope = 0x004E,

        [Description("Repel")]
        Repel = 0x004F,

        [Description("Sun Stone")]
        Sun_Stone = 0x0050,

        [Description("Moon Stone")]
        Moon_Stone = 0x0051,

        [Description("Fire Stone")]
        Fire_Stone = 0x0052,

        [Description("Thunder Stone")]
        Thunder_Stone = 0x0053,

        [Description("Water Stone")]
        Water_Stone = 0x0054,

        [Description("Leaf Stone")]
        Leaf_Stone = 0x0055,

        [Description("Tiny Mushroom")]
        Tiny_Mushroom = 0x0056,

        [Description("Big Mushroom")]
        Big_Mushroom = 0x0057,

        [Description("Pearl")]
        Pearl = 0x0058,

        [Description("Big Pearl")]
        Big_Pearl = 0x0059,

        [Description("Stardust")]
        Stardust = 0x005A,

        [Description("Star Piece")]
        Star_Piece = 0x005B,

        [Description("Nugget")]
        Nugget = 0x005C,

        [Description("Heart Scale")]
        Heart_Scale = 0x005D,

        [Description("Honey")]
        Honey = 0x005E,

        [Description("Growth Mulch")]
        Growth_Mulch = 0x005F,

        [Description("Damp Mulch")]
        Damp_Mulch = 0x0060,

        [Description("Stable Mulch")]
        Stable_Mulch = 0x0061,

        [Description("Gooey Mulch")]
        Gooey_Mulch = 0x0062,

        [Description("Root Fossil")]
        Root_Fossil = 0x0063,

        [Description("Claw Fossil")]
        Claw_Fossil = 0x0064,

        [Description("Helix Fossil")]
        Helix_Fossil = 0x0065,

        [Description("Dome Fossil")]
        Dome_Fossil = 0x0066,

        [Description("Old Amber")]
        Old_Amber = 0x0067,

        [Description("Armor Fossil")]
        Armor_Fossil = 0x0068,

        [Description("Skull Fossil")]
        Skull_Fossil = 0x0069,

        [Description("Rare Bone")]
        Rare_Bone = 0x006A,

        [Description("Shiny Stone")]
        Shiny_Stone = 0x006B,

        [Description("Dusk Stone")]
        Dusk_Stone = 0x006C,

        [Description("Dawn Stone")]
        Dawn_Stone = 0x006D,

        [Description("Oval Stone")]
        Oval_Stone = 0x006E,

        [Description("Odd Keystone")]
        Odd_Keystone = 0x006F,

        [Description("Griseous Orb")]
        Griseous_Orb = 0x0070,

        [Description("Douse Drive")]
        Douse_Drive = 0x0074,

        [Description("Shock Drive")]
        Shock_Drive = 0x0075,

        [Description("Burn Drive")]
        Burn_Drive = 0x0076,

        [Description("Chill Drive")]
        Chill_Drive = 0x0077,

        [Description("Sweet Heart")]
        Sweet_Heart = 0x0086,

        [Description("Adamant Orb")]
        Adamant_Orb = 0x0087,

        [Description("Lustrous Orb")]
        Lustrous_Orb = 0x0088,

        [Description("Greet Mail")]
        Greet_Mail = 0x0089,

        [Description("Favored Mail")]
        Favored_Mail = 0x008A,

        [Description("RSVP Mail")]
        RSVP_Mail = 0x008B,

        [Description("Thanks Mail")]
        Thanks_Mail = 0x008C,

        [Description("Inquiry Mail")]
        Inquiry_Mail = 0x008D,

        [Description("Like Mail")]
        Like_Mail = 0x008E,

        [Description("Reply Mail")]
        Reply_Mail = 0x008F,

        [Description("Bridge Mail S")]
        Bridge_Mail_S = 0x0090,

        [Description("Bridge Mail D")]
        Bridge_Mail_D = 0x0091,

        [Description("Bridge Mail T")]
        Bridge_Mail_T = 0x0092,

        [Description("Bridge Mail V")]
        Bridge_Mail_V = 0x0093,

        [Description("Bridge Mail M")]
        Bridge_Mail_M = 0x0094,

        [Description("Cheri Berry")]
        Cheri_Berry = 0x0095,

        [Description("Chesto Berry")]
        Chesto_Berry = 0x0096,

        [Description("Pecha Berry")]
        Pecha_Berry = 0x0097,

        [Description("Rawst Berry")]
        Rawst_Berry = 0x0098,

        [Description("Aspear Berry")]
        Aspear_Berry = 0x0099,

        [Description("Leppa Berry")]
        Leppa_Berry = 0x009A,

        [Description("Oran Berry")]
        Oran_Berry = 0x009B,

        [Description("Persim Berry")]
        Persim_Berry = 0x009C,

        [Description("Lum Berry")]
        Lum_Berry = 0x009D,

        [Description("Sitrus Berry")]
        Sitrus_Berry = 0x009E,

        [Description("Figy Berry")]
        Figy_Berry = 0x009F,

        [Description("Wiki Berry")]
        Wiki_Berry = 0x00A0,

        [Description("Mago Berry")]
        Mago_Berry = 0x00A1,

        [Description("Aguav Berry")]
        Aguav_Berry = 0x00A2,

        [Description("Iapapa Berry")]
        Iapapa_Berry = 0x00A3,

        [Description("Razz Berry")]
        Razz_Berry = 0x00A4,

        [Description("Bluk Berry")]
        Bluk_Berry = 0x00A5,

        [Description("Nanab Berry")]
        Nanab_Berry = 0x00A6,

        [Description("Wepear Berry")]
        Wepear_Berry = 0x00A7,

        [Description("Pinap Berry")]
        Pinap_Berry = 0x00A8,

        [Description("Pomeg Berry")]
        Pomeg_Berry = 0x00A9,

        [Description("Kelpsy Berry")]
        Kelpsy_Berry = 0x00AA,

        [Description("Qualot Berry")]
        Qualot_Berry = 0x00AB,

        [Description("Hondew Berry")]
        Hondew_Berry = 0x00AC,

        [Description("Grepa Berry")]
        Grepa_Berry = 0x00AD,

        [Description("Tamato Berry")]
        Tamato_Berry = 0x00AE,

        [Description("Cornn Berry")]
        Cornn_Berry = 0x00AF,

        [Description("Magost Berry")]
        Magost_Berry = 0x00B0,

        [Description("Rabuta Berry")]
        Rabuta_Berry = 0x00B1,

        [Description("Nomel Berry")]
        Nomel_Berry = 0x00B2,

        [Description("Spelon Berry")]
        Spelon_Berry = 0x00B3,

        [Description("Pamtre Berry")]
        Pamtre_Berry = 0x00B4,

        [Description("Watmel Berry")]
        Watmel_Berry = 0x00B5,

        [Description("Durin Berry")]
        Durin_Berry = 0x00B6,

        [Description("Belue Berry")]
        Belue_Berry = 0x00B7,

        [Description("Occa Berry")]
        Occa_Berry = 0x00B8,

        [Description("Passho Berry")]
        Passho_Berry = 0x00B9,

        [Description("Wacan Berry")]
        Wacan_Berry = 0x00BA,

        [Description("Rindo Berry")]
        Rindo_Berry = 0x00BB,

        [Description("Yache Berry")]
        Yache_Berry = 0x00BC,

        [Description("Chople Berry")]
        Chople_Berry = 0x00BD,

        [Description("Kebia Berry")]
        Kebia_Berry = 0x00BE,

        [Description("Shuca Berry")]
        Shuca_Berry = 0x00BF,

        [Description("Coba Berry")]
        Coba_Berry = 0x00C0,

        [Description("Payapa Berry")]
        Payapa_Berry = 0x00C1,

        [Description("Tanga Berry")]
        Tanga_Berry = 0x00C2,

        [Description("Charti Berry")]
        Charti_Berry = 0x00C3,

        [Description("Kasib Berry")]
        Kasib_Berry = 0x00C4,

        [Description("Haban Berry")]
        Haban_Berry = 0x00C5,

        [Description("Colbur Berry")]
        Colbur_Berry = 0x00C6,

        [Description("Babiri Berry")]
        Babiri_Berry = 0x00C7,

        [Description("Chilan Berry")]
        Chilan_Berry = 0x00C8,

        [Description("Liechi Berry")]
        Liechi_Berry = 0x00C9,

        [Description("Ganlon Berry")]
        Ganlon_Berry = 0x00CA,

        [Description("Salac Berry")]
        Salac_Berry = 0x00CB,

        [Description("Petaya Berry")]
        Petaya_Berry = 0x00CC,

        [Description("Apicot Berry")]
        Apicot_Berry = 0x00CD,

        [Description("Lansat Berry")]
        Lansat_Berry = 0x00CE,

        [Description("Starf Berry")]
        Starf_Berry = 0x00CF,

        [Description("Enigma Berry")]
        Enigma_Berry = 0x00D0,

        [Description("Micle Berry")]
        Micle_Berry = 0x00D1,

        [Description("Custap Berry")]
        Custap_Berry = 0x00D2,

        [Description("Jaboca Berry")]
        Jaboca_Berry = 0x00D3,

        [Description("Rowap Berry")]
        Rowap_Berry = 0x00D4,

        [Description("Bright Powder")]
        Bright_Powder = 0x00D5,

        [Description("White Herb")]
        White_Herb = 0x00D6,

        [Description("Macho Brace")]
        Macho_Brace = 0x00D7,

        [Description("Exp. Share")]
        Exp_Share = 0x00D8,

        [Description("Quick Claw")]
        Quick_Claw = 0x00D9,

        [Description("Soothe Bell")]
        Soothe_Bell = 0x00DA,

        [Description("Mental Herb")]
        Mental_Herb = 0x00DB,

        [Description("Choice Band")]
        Choice_Band = 0x00DC,

        [Description("King's Rock")]
        Kings_Rock = 0x00DD,

        [Description("Silver Powder")]
        Silver_Powder = 0x00DE,

        [Description("Amulet Coin")]
        Amulet_Coin = 0x00DF,

        [Description("Cleanse Tag")]
        Cleanse_Tag = 0x00E0,

        [Description("Soul Dew")]
        Soul_Dew = 0x00E1,

        [Description("Deep Sea Tooth")]
        Deep_Sea_Tooth = 0x00E2,

        [Description("Deep Sea Scale")]
        Deep_Sea_Scale = 0x00E3,

        [Description("Smoke Ball")]
        Smoke_Ball = 0x00E4,

        [Description("Everstone")]
        Everstone = 0x00E5,

        [Description("Focus Band")]
        Focus_Band = 0x00E6,

        [Description("Lucky Egg")]
        Lucky_Egg = 0x00E7,

        [Description("Scope Lens")]
        Scope_Lens = 0x00E8,

        [Description("Metal Coat")]
        Metal_Coat = 0x00E9,

        [Description("Leftovers")]
        Leftovers = 0x00EA,

        [Description("Dragon Scale")]
        Dragon_Scale = 0x00EB,

        [Description("Light Ball")]
        Light_Ball = 0x00EC,

        [Description("Soft Sand")]
        Soft_Sand = 0x00ED,

        [Description("Hard Stone")]
        Hard_Stone = 0x00EE,

        [Description("Miracle Seed")]
        Miracle_Seed = 0x00EF,

        [Description("Black Glasses")]
        Black_Glasses = 0x00F0,

        [Description("Black Belt")]
        Black_Belt = 0x00F1,

        [Description("Magnet")]
        Magnet = 0x00F2,

        [Description("Mystic Water")]
        Mystic_Water = 0x00F3,

        [Description("Sharp Beak")]
        Sharp_Beak = 0x00F4,

        [Description("Poison Barb")]
        Poison_Barb = 0x00F5,

        [Description("Never-Melt Ice")]
        Never_Melt_Ice = 0x00F6,

        [Description("Spell Tag")]
        Spell_Tag = 0x00F7,

        [Description("Twisted Spoon")]
        Twisted_Spoon = 0x00F8,

        [Description("Charcoal")]
        Charcoal = 0x00F9,

        [Description("Dragon Fang")]
        Dragon_Fang = 0x00FA,

        [Description("Silk Scarf")]
        Silk_Scarf = 0x00FB,

        [Description("Up-Grade")]
        Up_Grade = 0x00FC,

        [Description("Shell Bell")]
        Shell_Bell = 0x00FD,

        [Description("Sea Incense")]
        Sea_Incense = 0x00FE,

        [Description("Lax Incense")]
        Lax_Incense = 0x00FF,

        [Description("Lucky Punch")]
        Lucky_Punch = 0x0100,

        [Description("Metal Powder")]
        Metal_Powder = 0x0101,

        [Description("Thick Club")]
        Thick_Club = 0x0102,

        [Description("Stick")]
        Stick = 0x0103,

        [Description("Red Scarf")]
        Red_Scarf = 0x0104,

        [Description("Blue Scarf")]
        Blue_Scarf = 0x0105,

        [Description("Pink Scarf")]
        Pink_Scarf = 0x0106,

        [Description("Green Scarf")]
        Green_Scarf = 0x0107,

        [Description("Yellow Scarf")]
        Yellow_Scarf = 0x0108,

        [Description("Wide Lens")]
        Wide_Lens = 0x0109,

        [Description("Muscle Band")]
        Muscle_Band = 0x010A,

        [Description("Wise Glasses")]
        Wise_Glasses = 0x010B,

        [Description("Expert Belt")]
        Expert_Belt = 0x010C,

        [Description("Light Clay")]
        Light_Clay = 0x010D,

        [Description("Life Orb")]
        Life_Orb = 0x010E,

        [Description("Power Herb")]
        Power_Herb = 0x010F,

        [Description("Toxic Orb")]
        Toxic_Orb = 0x0110,

        [Description("Flame Orb")]
        Flame_Orb = 0x0111,

        [Description("Quick Powder")]
        Quick_Powder = 0x0112,

        [Description("Focus Sash")]
        Focus_Sash = 0x0113,

        [Description("Zoom Lens")]
        Zoom_Lens = 0x0114,

        [Description("Metronome")]
        Metronome = 0x0115,

        [Description("Iron Ball")]
        Iron_Ball = 0x0116,

        [Description("Lagging Tail")]
        Lagging_Tail = 0x0117,

        [Description("Destiny Knot")]
        Destiny_Knot = 0x0118,

        [Description("Black Sludge")]
        Black_Sludge = 0x0119,

        [Description("Icy Rock")]
        Icy_Rock = 0x011A,

        [Description("Smooth Rock")]
        Smooth_Rock = 0x011B,

        [Description("Heat Rock")]
        Heat_Rock = 0x011C,

        [Description("Damp Rock")]
        Damp_Rock = 0x011D,

        [Description("Grip Claw")]
        Grip_Claw = 0x011E,

        [Description("Choice Scarf")]
        Choice_Scarf = 0x011F,

        [Description("Sticky Barb")]
        Sticky_Barb = 0x0120,

        [Description("Power Bracer")]
        Power_Bracer = 0x0121,

        [Description("Power Belt")]
        Power_Belt = 0x0122,

        [Description("Power Lens")]
        Power_Lens = 0x0123,

        [Description("Power Band")]
        Power_Band = 0x0124,

        [Description("Power Anklet")]
        Power_Anklet = 0x0125,

        [Description("Power Weight")]
        Power_Weight = 0x0126,

        [Description("Shed Shell")]
        Shed_Shell = 0x0127,

        [Description("Big Root")]
        Big_Root = 0x0128,

        [Description("Choice Specs")]
        Choice_Specs = 0x0129,

        [Description("Flame Plate")]
        Flame_Plate = 0x012A,

        [Description("Splash Plate")]
        Splash_Plate = 0x012B,

        [Description("Zap Plate")]
        Zap_Plate = 0x012C,

        [Description("Meadow Plate")]
        Meadow_Plate = 0x012D,

        [Description("Icicle Plate")]
        Icicle_Plate = 0x012E,

        [Description("Fist Plate")]
        Fist_Plate = 0x012F,

        [Description("Toxic Plate")]
        Toxic_Plate = 0x0130,

        [Description("Earth Plate")]
        Earth_Plate = 0x0131,

        [Description("Sky Plate")]
        Sky_Plate = 0x0132,

        [Description("Mind Plate")]
        Mind_Plate = 0x0133,

        [Description("Insect Plate")]
        Insect_Plate = 0x0134,

        [Description("Stone Plate")]
        Stone_Plate = 0x0135,

        [Description("Spooky Plate")]
        Spooky_Plate = 0x0136,

        [Description("Draco Plate")]
        Draco_Plate = 0x0137,

        [Description("Dread Plate")]
        Dread_Plate = 0x0138,

        [Description("Iron Plate")]
        Iron_Plate = 0x0139,

        [Description("Odd Incense")]
        Odd_Incense = 0x013A,

        [Description("Rock Incense")]
        Rock_Incense = 0x013B,

        [Description("Full Incense")]
        Full_Incense = 0x013C,

        [Description("Wave Incense")]
        Wave_Incense = 0x013D,

        [Description("Rose Incense")]
        Rose_Incense = 0x013E,

        [Description("Luck Incense")]
        Luck_Incense = 0x013F,

        [Description("Pure Incense")]
        Pure_Incense = 0x0140,

        [Description("Protector")]
        Protector = 0x0141,

        [Description("Electirizer")]
        Electirizer = 0x0142,

        [Description("Magmarizer")]
        Magmarizer = 0x0143,

        [Description("Dubious Disc")]
        Dubious_Disc = 0x0144,

        [Description("Reaper Cloth")]
        Reaper_Cloth = 0x0145,

        [Description("Razor Claw")]
        Razor_Claw = 0x0146,

        [Description("Razor Fang")]
        Razor_Fang = 0x0147,

        [Description("TM01")]
        TM01 = 0x0148,

        [Description("TM02")]
        TM02 = 0x0149,

        [Description("TM03")]
        TM03 = 0x014A,

        [Description("TM04")]
        TM04 = 0x014B,

        [Description("TM05")]
        TM05 = 0x014C,

        [Description("TM06")]
        TM06 = 0x014D,

        [Description("TM07")]
        TM07 = 0x014E,

        [Description("TM08")]
        TM08 = 0x014F,

        [Description("TM09")]
        TM09 = 0x0150,

        [Description("TM10")]
        TM10 = 0x0151,

        [Description("TM11")]
        TM11 = 0x0152,

        [Description("TM12")]
        TM12 = 0x0153,

        [Description("TM13")]
        TM13 = 0x0154,

        [Description("TM14")]
        TM14 = 0x0155,

        [Description("TM15")]
        TM15 = 0x0156,

        [Description("TM16")]
        TM16 = 0x0157,

        [Description("TM17")]
        TM17 = 0x0158,

        [Description("TM18")]
        TM18 = 0x0159,

        [Description("TM19")]
        TM19 = 0x015A,

        [Description("TM20")]
        TM20 = 0x015B,

        [Description("TM21")]
        TM21 = 0x015C,

        [Description("TM22")]
        TM22 = 0x015D,

        [Description("TM23")]
        TM23 = 0x015E,

        [Description("TM24")]
        TM24 = 0x015F,

        [Description("TM25")]
        TM25 = 0x0160,

        [Description("TM26")]
        TM26 = 0x0161,

        [Description("TM27")]
        TM27 = 0x0162,

        [Description("TM28")]
        TM28 = 0x0163,

        [Description("TM29")]
        TM29 = 0x0164,

        [Description("TM30")]
        TM30 = 0x0165,

        [Description("TM31")]
        TM31 = 0x0166,

        [Description("TM32")]
        TM32 = 0x0167,

        [Description("TM33")]
        TM33 = 0x0168,

        [Description("TM34")]
        TM34 = 0x0169,

        [Description("TM35")]
        TM35 = 0x016A,

        [Description("TM36")]
        TM36 = 0x016B,

        [Description("TM37")]
        TM37 = 0x016C,

        [Description("TM38")]
        TM38 = 0x016D,

        [Description("TM39")]
        TM39 = 0x016E,

        [Description("TM40")]
        TM40 = 0x016F,

        [Description("TM41")]
        TM41 = 0x0170,

        [Description("TM42")]
        TM42 = 0x0171,

        [Description("TM43")]
        TM43 = 0x0172,

        [Description("TM44")]
        TM44 = 0x0173,

        [Description("TM45")]
        TM45 = 0x0174,

        [Description("TM46")]
        TM46 = 0x0175,

        [Description("TM47")]
        TM47 = 0x0176,

        [Description("TM48")]
        TM48 = 0x0177,

        [Description("TM49")]
        TM49 = 0x0178,

        [Description("TM50")]
        TM50 = 0x0179,

        [Description("TM51")]
        TM51 = 0x017A,

        [Description("TM52")]
        TM52 = 0x017B,

        [Description("TM53")]
        TM53 = 0x017C,

        [Description("TM54")]
        TM54 = 0x017D,

        [Description("TM55")]
        TM55 = 0x017E,

        [Description("TM56")]
        TM56 = 0x017F,

        [Description("TM57")]
        TM57 = 0x0180,

        [Description("TM58")]
        TM58 = 0x0181,

        [Description("TM59")]
        TM59 = 0x0182,

        [Description("TM60")]
        TM60 = 0x0183,

        [Description("TM61")]
        TM61 = 0x0184,

        [Description("TM62")]
        TM62 = 0x0185,

        [Description("TM63")]
        TM63 = 0x0186,

        [Description("TM64")]
        TM64 = 0x0187,

        [Description("TM65")]
        TM65 = 0x0188,

        [Description("TM66")]
        TM66 = 0x0189,

        [Description("TM67")]
        TM67 = 0x018A,

        [Description("TM68")]
        TM68 = 0x018B,

        [Description("TM69")]
        TM69 = 0x018C,

        [Description("TM70")]
        TM70 = 0x018D,

        [Description("TM71")]
        TM71 = 0x018E,

        [Description("TM72")]
        TM72 = 0x018F,

        [Description("TM73")]
        TM73 = 0x0190,

        [Description("TM74")]
        TM74 = 0x0191,

        [Description("TM75")]
        TM75 = 0x0192,

        [Description("TM76")]
        TM76 = 0x0193,

        [Description("TM77")]
        TM77 = 0x0194,

        [Description("TM78")]
        TM78 = 0x0195,

        [Description("TM79")]
        TM79 = 0x0196,

        [Description("TM80")]
        TM80 = 0x0197,

        [Description("TM81")]
        TM81 = 0x0198,

        [Description("TM82")]
        TM82 = 0x0199,

        [Description("TM83")]
        TM83 = 0x019A,

        [Description("TM84")]
        TM84 = 0x019B,

        [Description("TM85")]
        TM85 = 0x019C,

        [Description("TM86")]
        TM86 = 0x019D,

        [Description("TM87")]
        TM87 = 0x019E,

        [Description("TM88")]
        TM88 = 0x019F,

        [Description("TM89")]
        TM89 = 0x01A0,

        [Description("TM90")]
        TM90 = 0x01A1,

        [Description("TM91")]
        TM91 = 0x01A2,

        [Description("TM92")]
        TM92 = 0x01A3,

        [Description("HM01")]
        HM01 = 0x01A4,

        [Description("HM02")]
        HM02 = 0x01A5,

        [Description("HM03")]
        HM03 = 0x01A6,

        [Description("HM04")]
        HM04 = 0x01A7,

        [Description("HM05")]
        HM05 = 0x01A8,

        [Description("HM06")]
        HM06 = 0x01A9,

        [Description("Explorer Kit")]
        Explorer_Kit = 0x01AC,

        [Description("Loot Sack")]
        Loot_Sack = 0x01AD,

        [Description("Rule Book")]
        Rule_Book = 0x01AE,

        [Description("Poké Radar")]
        Poke_Radar = 0x01AF,

        [Description("Point Card")]
        Point_Card = 0x01B0,

        [Description("Journal")]
        Journal = 0x01B1,

        [Description("Seal Case")]
        Seal_Case = 0x01B2,

        [Description("Fashion Case")]
        Fashion_Case = 0x01B3,

        [Description("Seal Bag")]
        Seal_Bag = 0x01B4,

        [Description("Pal Pad")]
        Pal_Pad = 0x01B5,

        [Description("Works Key")]
        Works_Key = 0x01B6,

        [Description("Old Charm")]
        Old_Charm = 0x01B7,

        [Description("Galactic Key")]
        Galactic_Key = 0x01B8,

        [Description("Red Chain")]
        Red_Chain = 0x01B9,

        [Description("Town Map")]
        Town_Map = 0x01BA,

        [Description("Vs. Seeker")]
        Vs_Seeker = 0x01BB,

        [Description("Coin Case")]
        Coin_Case = 0x01BC,

        [Description("Old Rod")]
        Old_Rod = 0x01BD,

        [Description("Good Rod")]
        Good_Rod = 0x01BE,

        [Description("Super Rod")]
        Super_Rod = 0x01BF,

        [Description("Sprayduck")]
        Sprayduck = 0x01C0,

        [Description("Poffin Case")]
        Poffin_Case = 0x01C1,

        [Description("Bicycle")]
        Bicycle = 0x01C2,

        [Description("Bike")]
        Bike = 0x01C2,

        [Description("Suite Key")]
        Suite_Key = 0x01C3,

        [Description("Oak's Letter")]
        Oaks_Letter = 0x01C4,

        [Description("Lunar Wing")]
        Lunar_Wing = 0x01C5,

        [Description("Member Card")]
        Member_Card = 0x01C6,

        [Description("Azure Flute")]
        Azure_Flute = 0x01C7,

        [Description("S.S. Ticket")]
        SS_Ticket = 0x01C8,

        [Description("Contest Pass")]
        Contest_Pass = 0x01C9,

        [Description("Magma Stone")]
        Magma_Stone = 0x01CA,

        [Description("Parcel")]
        Parcel = 0x01CB,

        [Description("Coupon 1")]
        Coupon_1 = 0x01CC,

        [Description("Coupon 2")]
        Coupon_2 = 0x01CD,

        [Description("Coupon 3")]
        Coupon_3 = 0x01CE,

        [Description("Storage Key")]
        Storage_Key = 0x01CF,

        [Description("Secret Potion")]
        Secret_Potion = 0x01D0,

        [Description("Vs. Recorder")]
        Vs_Recorder = 0x01D1,

        [Description("Gracidea")]
        Gracidea = 0x01D2,

        [Description("Secret Key")]
        Secret_Key = 0x01D3,

        [Description("Apricorn Box")]
        Apricorn_Box = 0x01D4,

        [Description("Unown Report")]
        Unown_Report = 0x01D5,

        [Description("Berry Pots")]
        Berry_Pots = 0x01D6,

        [Description("Dowsing Machine")]
        Dowsing_Machine = 0x01D7,

        [Description("Blue Card")]
        Blue_Card = 0x01D8,

        [Description("Slowpoke Tail")]
        Slowpoke_Tail = 0x01D9,

        [Description("Clear Bell")]
        Clear_Bell = 0x01DA,

        [Description("Card Key")]
        Card_Key = 0x01DB,

        [Description("Basement Key")]
        Basement_Key = 0x01DC,

        [Description("Squirt Bottle")]
        Squirt_Bottle = 0x01DD,

        [Description("Red Scale")]
        Red_Scale = 0x01DE,

        [Description("Lost Item")]
        Lost_Item = 0x01DF,

        [Description("Pass")]
        Pass = 0x01E0,

        [Description("Machine Part")]
        Machine_Part = 0x01E1,

        [Description("Silver Wing")]
        Silver_Wing = 0x01E2,

        [Description("Rainbow Wing")]
        Rainbow_Wing = 0x01E3,

        [Description("Mystery Egg")]
        Mystery_Egg = 0x01E4,

        [Description("Red Apricorn")]
        Red_Apricorn = 0x01E5,

        [Description("Yellow Apricorn")]
        Yellow_Apricorn = 0x01E6,

        [Description("Blue Apricorn")]
        Blue_Apricorn = 0x01E7,

        [Description("Green Apricorn")]
        Green_Apricorn = 0x01E8,

        [Description("Pink Apricorn")]
        Pink_Apricorn = 0x01E9,

        [Description("White Apricorn")]
        White_Apricorn = 0x01EA,

        [Description("Black Apricorn")]
        Black_Apricorn = 0x01EB,

        [Description("Fast Ball")]
        Fast_Ball = 0x01EC,

        [Description("Level Ball")]
        Level_Ball = 0x01ED,

        [Description("Lure Ball")]
        Lure_Ball = 0x01EE,

        [Description("Heavy Ball")]
        Heavy_Ball = 0x01EF,

        [Description("Love Ball")]
        Love_Ball = 0x01F0,

        [Description("Friend Ball")]
        Friend_Ball = 0x01F1,

        [Description("Moon Ball")]
        Moon_Ball = 0x01F2,

        [Description("Sport Ball")]
        Sport_Ball = 0x01F3,

        [Description("Park Ball")]
        Park_Ball = 0x01F4,

        [Description("Photo Album")]
        Photo_Album = 0x01F5,

        [Description("GB Sounds")]
        GB_Sounds = 0x01F6,

        [Description("Tidal Bell")]
        Tidal_Bell = 0x01F7,

        [Description("Rage Candy Bar")]
        Rage_Candy_Bar = 0x01F8,

        [Description("Data Card 01")]
        Data_Card_01 = 0x01F9,

        [Description("Data Card 02")]
        Data_Card_02 = 0x01FA,

        [Description("Data Card 03")]
        Data_Card_03 = 0x01FB,

        [Description("Data Card 04")]
        Data_Card_04 = 0x01FC,

        [Description("Data Card 05")]
        Data_Card_05 = 0x01FD,

        [Description("Data Card 06")]
        Data_Card_06 = 0x01FE,

        [Description("Data Card 07")]
        Data_Card_07 = 0x01FF,

        [Description("Data Card 08")]
        Data_Card_08 = 0x0200,

        [Description("Data Card 09")]
        Data_Card_09 = 0x0201,

        [Description("Data Card 10")]
        Data_Card_10 = 0x0202,

        [Description("Data Card 11")]
        Data_Card_11 = 0x0203,

        [Description("Data Card 12")]
        Data_Card_12 = 0x0204,

        [Description("Data Card 13")]
        Data_Card_13 = 0x0205,

        [Description("Data Card 14")]
        Data_Card_14 = 0x0206,

        [Description("Data Card 15")]
        Data_Card_15 = 0x0207,

        [Description("Data Card 16")]
        Data_Card_16 = 0x0208,

        [Description("Data Card 17")]
        Data_Card_17 = 0x0209,

        [Description("Data Card 18")]
        Data_Card_18 = 0x020A,

        [Description("Data Card 19")]
        Data_Card_19 = 0x020B,

        [Description("Data Card 20")]
        Data_Card_20 = 0x020C,

        [Description("Data Card 21")]
        Data_Card_21 = 0x020D,

        [Description("Data Card 22")]
        Data_Card_22 = 0x020E,

        [Description("Data Card 23")]
        Data_Card_23 = 0x020F,

        [Description("Data Card 24")]
        Data_Card_24 = 0x0210,

        [Description("Data Card 25")]
        Data_Card_25 = 0x0211,

        [Description("Data Card 26")]
        Data_Card_26 = 0x0212,

        [Description("Data Card 27")]
        Data_Card_27 = 0x0213,

        [Description("Jade Orb")]
        Jade_Orb = 0x0214,

        [Description("Lock Capsule")]
        Lock_Capsule = 0x0215,

        [Description("Red Orb")]
        Red_Orb = 0x0216,

        [Description("Blue Orb")]
        Blue_Orb = 0x0217,

        [Description("Enigma Stone")]
        Enigma_Stone = 0x0218,

        [Description("Prism Scale")]
        Prism_Scale = 0x0219,

        [Description("Eviolite")]
        Eviolite = 0x021A,

        [Description("Float Stone")]
        Float_Stone = 0x021B,

        [Description("Rocky Helmet")]
        Rocky_Helmet = 0x021C,

        [Description("Air Balloon")]
        Air_Balloon = 0x021D,

        [Description("Red Card")]
        Red_Card = 0x021E,

        [Description("Ring Target")]
        Ring_Target = 0x021F,

        [Description("Binding Band")]
        Binding_Band = 0x0220,

        [Description("Absorb Bulb")]
        Absorb_Bulb = 0x0221,

        [Description("Cell Battery")]
        Cell_Battery = 0x0222,

        [Description("Eject Button")]
        Eject_Button = 0x0223,

        [Description("Fire Gem")]
        Fire_Gem = 0x0224,

        [Description("Water Gem")]
        Water_Gem = 0x0225,

        [Description("Electric Gem")]
        Electric_Gem = 0x0226,

        [Description("Grass Gem")]
        Grass_Gem = 0x0227,

        [Description("Ice Gem")]
        Ice_Gem = 0x0228,

        [Description("Fighting Gem")]
        Fighting_Gem = 0x0229,

        [Description("Poison Gem")]
        Poison_Gem = 0x022A,

        [Description("Ground Gem")]
        Ground_Gem = 0x022B,

        [Description("Flying Gem")]
        Flying_Gem = 0x022C,

        [Description("Psychic Gem")]
        Psychic_Gem = 0x022D,

        [Description("Bug Gem")]
        Bug_Gem = 0x022E,

        [Description("Rock Gem")]
        Rock_Gem = 0x022F,

        [Description("Ghost Gem")]
        Ghost_Gem = 0x0230,

        [Description("Dragon Gem")]
        Dragon_Gem = 0x0231,

        [Description("Dark Gem")]
        Dark_Gem = 0x0232,

        [Description("Steel Gem")]
        Steel_Gem = 0x0233,

        [Description("Normal Gem")]
        Normal_Gem = 0x0234,

        [Description("Health Wing")]
        Health_Wing = 0x0235,

        [Description("Muscle Wing")]
        Muscle_Wing = 0x0236,

        [Description("Resist Wing")]
        Resist_Wing = 0x0237,

        [Description("Genius Wing")]
        Genius_Wing = 0x0238,

        [Description("Clever Wing")]
        Clever_Wing = 0x0239,

        [Description("Swift Wing")]
        Swift_Wing = 0x023A,

        [Description("Pretty Wing")]
        Pretty_Wing = 0x023B,

        [Description("Cover Fossil")]
        Cover_Fossil = 0x023C,

        [Description("Plume Fossil")]
        Plume_Fossil = 0x023D,

        [Description("Liberty Pass")]
        Liberty_Pass = 0x023E,

        [Description("Pass Orb")]
        Pass_Orb = 0x023F,

        [Description("Dream Ball")]
        Dream_Ball = 0x0240,

        [Description("Poké Toy")]
        Poke_Toy = 0x0241,

        [Description("Prop Case")]
        Prop_Case = 0x0242,

        [Description("Dragon Skull")]
        Dragon_Skull = 0x0243,

        [Description("Balm Mushroom")]
        Balm_Mushroom = 0x0244,

        [Description("Big Nugget")]
        Big_Nugget = 0x0245,

        [Description("Pearl String")]
        Pearl_String = 0x0246,

        [Description("Comet Shard")]
        Comet_Shard = 0x0247,

        [Description("Relic Copper")]
        Relic_Copper = 0x0248,

        [Description("Relic Silver")]
        Relic_Silver = 0x0249,

        [Description("Relic Gold")]
        Relic_Gold = 0x024A,

        [Description("Relic Vase")]
        Relic_Vase = 0x024B,

        [Description("Relic Band")]
        Relic_Band = 0x024C,

        [Description("Relic Statue")]
        Relic_Statue = 0x024D,

        [Description("Relic Crown")]
        Relic_Crown = 0x024E,

        [Description("Casteliacone")]
        Casteliacone = 0x024F,

        [Description("Dire Hit 2")]
        Dire_Hit_2 = 0x0250,

        [Description("X Speed 2")]
        X_Speed_2 = 0x0251,

        [Description("X Sp. Atk 2")]
        X_Sp_Atk_2 = 0x0252,

        [Description("X Sp. Def 2")]
        X_Sp_Def_2 = 0x0253,

        [Description("X Defense 2")]
        X_Defense_2 = 0x0254,

        [Description("X Attack 2")]
        X_Attack_2 = 0x0255,

        [Description("X Accuracy 2")]
        X_Accuracy_2 = 0x0256,

        [Description("X Speed 3")]
        X_Speed_3 = 0x0257,

        [Description("X Sp. Atk 3")]
        X_Sp_Atk_3 = 0x0258,

        [Description("X Sp. Def 3")]
        X_Sp_Def_3 = 0x0259,

        [Description("X Defense 3")]
        X_Defense_3 = 0x025A,

        [Description("X Attack 3")]
        X_Attack_3 = 0x025B,

        [Description("X Accuracy 3")]
        X_Accuracy_3 = 0x025C,

        [Description("X Speed 6")]
        X_Speed_6 = 0x025D,

        [Description("X Sp. Atk 6")]
        X_Sp_Atk_6 = 0x025E,

        [Description("X Sp. Def 6")]
        X_Sp_Def_6 = 0x025F,

        [Description("X Defense 6")]
        X_Defense_6 = 0x0260,

        [Description("X Attack 6")]
        X_Attack_6 = 0x0261,

        [Description("X Accuracy 6")]
        X_Accuracy_6 = 0x0262,

        [Description("Ability Urge")]
        Ability_Urge = 0x0263,

        [Description("Item Drop")]
        Item_Drop = 0x0264,

        [Description("Item Urge")]
        Item_Urge = 0x0265,

        [Description("Reset Urge")]
        Reset_Urge = 0x0266,

        [Description("Dire Hit 3")]
        Dire_Hit_3 = 0x0267,

        [Description("Light Stone")]
        Light_Stone = 0x0268,

        [Description("Dark Stone")]
        Dark_Stone = 0x0269,

        [Description("TM93")]
        TM93 = 0x026A,

        [Description("TM94")]
        TM94 = 0x026B,

        [Description("TM95")]
        TM95 = 0x026C,

        [Description("Xtransceiver")]
        Xtransceiver = 0x026D,

        [Description("???")]
        UNKNOWN = 0x026E,

        [Description("Gram 1")]
        Gram_1 = 0x026F,

        [Description("Gram 2")]
        Gram_2 = 0x0270,

        [Description("Gram 3")]
        Gram_3 = 0x0271,

        [Description("Xtransceiver")]
        Xtransceiver2 = 0x0272,

        [Description("Medal Box")]
        Medal_Box = 0x0273,

        [Description("DNA Splicers")]
        DNA_Splicers = 0x0274,

        [Description("DNA Splicers")]
        DNA_Splicers2 = 0x0275,

        [Description("Permit")]
        Permit = 0x0276,

        [Description("Oval Charm")]
        Oval_Charm = 0x0277,

        [Description("Shiny Charm")]
        Shiny_Charm = 0x0278,

        [Description("Plasma Card")]
        Plasma_Card = 0x0279,

        [Description("Grubby Hanky")]
        Grubby_Hanky = 0x027A,

        [Description("Colress Machine")]
        Colress_Machine = 0x027B,

        [Description("Dropped Item")]
        Dropped_Item = 0x027C,

        [Description("Dropped Item")]
        Dropped_Item2 = 0x027D,

        [Description("Reveal Glass")]
        Reveal_Glass = 0x027E,

        [Description("Weakness Policy")]
        Weakness_Policy = 0x027F,

        [Description("Assault Vest")]
        Assault_Vest = 0x0280,

        [Description("Holo Caster")]
        Holo_Caster2 = 0x0281,

        [Description("Prof's Letter")]
        Profs_Letter = 0x0282,

        [Description("Roller Skates")]
        Roller_Skates = 0x0283,

        [Description("Pixie Plate")]
        Pixie_Plate = 0x0284,

        [Description("Ability Capsule")]
        Ability_Capsule = 0x0285,

        [Description("Whipped Dream")]
        Whipped_Dream = 0x0286,

        [Description("Sachet")]
        Sachet = 0x0287,

        [Description("Luminous Moss")]
        Luminous_Moss = 0x0288,

        [Description("Snowball")]
        Snowball = 0x0289,

        [Description("Safety Goggles")]
        Safety_Goggles = 0x028A,

        [Description("Poké Flute")]
        Poke_Flute = 0x028B,

        [Description("Rich Mulch")]
        Rich_Mulch = 0x028C,

        [Description("Surprise Mulch")]
        Surprise_Mulch = 0x028D,

        [Description("Boost Mulch")]
        Boost_Mulch = 0x028E,

        [Description("Amaze Mulch")]
        Amaze_Mulch = 0x028F,

        [Description("Gengarite")]
        Gengarite = 0x0290,

        [Description("Gardevoirite")]
        Gardevoirite = 0x0291,

        [Description("Ampharosite")]
        Ampharosite = 0x0292,

        [Description("Venusaurite")]
        Venusaurite = 0x0293,

        [Description("Charizardite X")]
        Charizardite_X = 0x0294,

        [Description("Blastoisinite")]
        Blastoisinite = 0x0295,

        [Description("Mewtwonite X")]
        Mewtwonite_X = 0x0296,

        [Description("Mewtwonite Y")]
        Mewtwonite_Y = 0x0297,

        [Description("Blazikenite")]
        Blazikenite = 0x0298,

        [Description("Medichamite")]
        Medichamite = 0x0299,

        [Description("Houndoominite")]
        Houndoominite = 0x029A,

        [Description("Aggronite")]
        Aggronite = 0x029B,

        [Description("Banettite")]
        Banettite = 0x029C,

        [Description("Tyranitarite")]
        Tyranitarite = 0x029D,

        [Description("Scizorite")]
        Scizorite = 0x029E,

        [Description("Pinsirite")]
        Pinsirite = 0x029F,

        [Description("Aerodactylite")]
        Aerodactylite = 0x02A0,

        [Description("Lucarionite")]
        Lucarionite = 0x02A1,

        [Description("Abomasite")]
        Abomasite = 0x02A2,

        [Description("Kangaskhanite")]
        Kangaskhanite = 0x02A3,

        [Description("Gyaradosite")]
        Gyaradosite = 0x02A4,

        [Description("Absolite")]
        Absolite = 0x02A5,

        [Description("Charizardite Y")]
        Charizardite_Y = 0x02A6,

        [Description("Alakazite")]
        Alakazite = 0x02A7,

        [Description("Heracronite")]
        Heracronite = 0x02A8,

        [Description("Mawilite")]
        Mawilite = 0x02A9,

        [Description("Manectite")]
        Manectite = 0x02AA,

        [Description("Garchompite")]
        Garchompite = 0x02AB,

        [Description("Latiasite")]
        Latiasite = 0x02AC,

        [Description("Latiosite")]
        Latiosite = 0x02AD,

        [Description("Roseli Berry")]
        Roseli_Berry = 0x02AE,

        [Description("Kee Berry")]
        Kee_Berry = 0x02AF,

        [Description("Maranga Berry")]
        Maranga_Berry = 0x02B0,

        [Description("Sprinklotad")]
        Sprinklotad = 0x02B1,

        [Description("TM96")]
        TM96 = 0x02B2,

        [Description("TM97")]
        TM97 = 0x02B3,

        [Description("TM98")]
        TM98 = 0x02B4,

        [Description("TM99")]
        TM99 = 0x02B5,

        [Description("TM100")]
        TM100 = 0x02B6,

        [Description("Power Plant Pass")]
        Power_Plant_Pass = 0x02B7,

        [Description("Mega Ring")]
        Mega_Ring = 0x02B8,

        [Description("Intriguing Stone")]
        Intriguing_Stone = 0x02B9,

        [Description("Common Stone")]
        Common_Stone = 0x02BA,

        [Description("Discount Coupon")]
        Discount_Coupon = 0x02BB,

        [Description("Elevator Key")]
        Elevator_Key = 0x02BC,

        [Description("TMV Pass")]
        TMV_Pass = 0x02BD,

        [Description("Honor of Kalos")]
        Honor_of_Kalos = 0x02BE,

        [Description("Adventure Rules")]
        Adventure_Rules = 0x02BF,

        [Description("Strange Souvenir")]
        Strange_Souvenir = 0x02C0,

        [Description("Lens Case")]
        Lens_Case = 0x02C1,

        [Description("Travel Trunk")]
        Travel_Trunk = 0x02C2,

        [Description("Travel Trunk")]
        Travel_Trunk2 = 0x02C3,

        [Description("Lumiose Galette")]
        Lumiose_Galette = 0x02C4,

        [Description("Shalour Sable")]
        Shalour_Sable = 0x02C5,

        [Description("Jaw Fossil")]
        Jaw_Fossil = 0x02C6,

        [Description("Sail Fossil")]
        Sail_Fossil = 0x02C7,

        [Description("Looker Ticket")]
        Looker_Ticket = 0x02C8,

        [Description("Bicycle")]
        Bicycle2 = 0x02C9,

        [Description("Bike")]
        Bike2 = 0x02C9,

        [Description("Holo Caster")]
        Holo_Caster = 0x02CA,

        [Description("Fairy Gem")]
        Fairy_Gem = 0x02CB,

        [Description("Mega Charm")]
        Mega_Charm = 0x02CC,

        [Description("Mega Glove")]
        Mega_Glove = 0x02CD,

        [Description("Mach Bike")]
        Mach_Bike = 0x02CE,

        [Description("Acro Bike")]
        Acro_Bike = 0x02CF,

        [Description("Wailmer Pail")]
        Wailmer_Pail = 0x02D0,

        [Description("Devon Parts")]
        Devon_Parts = 0x02D1,

        [Description("Soot Sack")]
        Soot_Sack = 0x02D2,

        [Description("Basement Key")]
        Basement_Key2 = 0x02D3,

        [Description("Pokéblock Kit")]
        Pokeblock_Kit = 0x02D4,

        [Description("Letter")]
        Letter = 0x02D5,

        [Description("Eon Ticket")]
        Eon_Ticket = 0x02D6,

        [Description("Scanner")]
        Scanner = 0x02D7,

        [Description("Go-Goggles")]
        Go_Goggles = 0x02D8,

        [Description("Meteorite")]
        Meteorite = 0x02D9,

        [Description("Key to Room 1")]
        Key_to_Room_1 = 0x02DA,

        [Description("Key to Room 2")]
        Key_to_Room_2 = 0x02DB,

        [Description("Key to Room 4")]
        Key_to_Room_4 = 0x02DC,

        [Description("Key to Room 6")]
        Key_to_Room_6 = 0x02DD,

        [Description("Storage Key")]
        Storage_Key2 = 0x02DE,

        [Description("Devon Scope")]
        Devon_Scope = 0x02DF,

        [Description("S.S. Ticket")]
        SS_Ticket2 = 0x02E0,

        [Description("HM07")]
        HM07 = 0x02E1,

        [Description("Devon Scuba Gear")]
        Devon_Scuba_Gear = 0x02E2,

        [Description("Contest Costume")]
        Contest_Costume = 0x02E3,

        [Description("Contest Costume")]
        Contest_Costume2 = 0x02E4,

        [Description("Magma Suit")]
        Magma_Suit = 0x02E5,

        [Description("Aqua Suit")]
        Aqua_Suit = 0x02E6,

        [Description("Pair of Tickets")]
        Pair_of_Tickets = 0x02E7,

        [Description("Mega Bracelet")]
        Mega_Bracelet = 0x02E8,

        [Description("Mega Pendant")]
        Mega_Pendant = 0x02E9,

        [Description("Mega Glasses")]
        Mega_Glasses = 0x02EA,

        [Description("Mega Anchor")]
        Mega_Anchor = 0x02EB,

        [Description("Mega Stickpin")]
        Mega_Stickpin = 0x02EC,

        [Description("Mega Tiara")]
        Mega_Tiara = 0x02ED,

        [Description("Mega Anklet")]
        Mega_Anklet = 0x02EE,

        [Description("Meteorite")]
        Meteorite2 = 0x02EF,

        [Description("Swampertite")]
        Swampertite = 0x02F0,

        [Description("Sceptilite")]
        Sceptilite = 0x02F1,

        [Description("Sablenite")]
        Sablenite = 0x02F2,

        [Description("Altarianite")]
        Altarianite = 0x02F3,

        [Description("Galladite")]
        Galladite = 0x02F4,

        [Description("Audinite")]
        Audinite = 0x02F5,

        [Description("Metagrossite")]
        Metagrossite = 0x02F6,

        [Description("Sharpedonite")]
        Sharpedonite = 0x02F7,

        [Description("Slowbronite")]
        Slowbronite = 0x02F8,

        [Description("Steelixite")]
        Steelixite = 0x02F9,

        [Description("Pidgeotite")]
        Pidgeotite = 0x02FA,

        [Description("Glalitite")]
        Glalitite = 0x02FB,

        [Description("Diancite")]
        Diancite = 0x02FC,

        [Description("Prison Bottle")]
        Prison_Bottle = 0x02FD,

        [Description("Mega Cuff")]
        Mega_Cuff = 0x02FE,

        [Description("Cameruptite")]
        Cameruptite = 0x02FF,

        [Description("Lopunnite")]
        Lopunnite = 0x0300,

        [Description("Salamencite")]
        Salamencite = 0x0301,

        [Description("Beedrillite")]
        Beedrillite = 0x0302,

        [Description("Meteorite")]
        Meteorite3 = 0x0303,

        [Description("Meteorite")]
        Meteorite4 = 0x0304,

        [Description("Key Stone")]
        Key_Stone = 0x0305,

        [Description("Meteorite Shard")]
        Meteorite_Shard = 0x0306,

        [Description("Eon Flute")]
        Eon_Flute = 0x0307
    }

    public enum Locations : ushort
    {
        [Description("Mystery Zone")]
        Mystery_Zone = 0,

        [Description("Mystery Zone")]
        Mystery_Zone2 = 2,

        [Description("Faraway Place")]
        Faraway_Place = 4,

        [Description("Vaniville Town")]
        Vaniville_Town = 6,

        [Description("Route 1")]
        Route_1 = 8,

        [Description("Vaniville Pathway")]
        Vaniville_Pathway = 9,

        [Description("Aquacorde Town")]
        Aquacorde_Town = 10,

        [Description("Route 2")]
        Route_2 = 12,

        [Description("Avance Trail")]
        Avance_Trail = 13,

        [Description("Santalune Forest")]
        Santalune_Forest = 14,

        [Description("Route 3")]
        Route_3 = 16,

        [Description("Ouvert Way")]
        Ouvert_Way = 17,

        [Description("Santalune City")]
        Santalune_City = 18,

        [Description("Route 4")]
        Route_4 = 20,

        [Description("Parterre Way")]
        Parterre_Way = 21,

        [Description("Lumiose City")]
        Lumiose_City = 22,

        [Description("Prism Tower")]
        Prism_Tower = 24,

        [Description("Lysandre Labs")]
        Lysandre_Labs = 26,

        [Description("Route 5")]
        Route_5 = 28,

        [Description("Versant Road")]
        Versant_Road = 29,

        [Description("Camphrier Town")]
        Camphrier_Town = 30,

        [Description("Shabboneau Castle")]
        Shabboneau_Castle = 32,

        [Description("Route 6")]
        Route_6 = 34,

        [Description("Palais Lane")]
        Palais_Lane = 35,

        [Description("Parfum Palace")]
        Parfum_Palace = 36,

        [Description("Route 7")]
        Route_7 = 38,

        [Description("Rivière Walk")]
        Rivière_Walk = 39,

        [Description("Cyllage City")]
        Cyllage_City = 40,

        [Description("Route 8")]
        Route_8 = 42,

        [Description("Muraille Coast")]
        Muraille_Coast = 43,

        [Description("Ambrette Town")]
        Ambrette_Town = 44,

        [Description("Route 9")]
        Route_9 = 46,

        [Description("Spikes Passage")]
        Spikes_Passage = 47,

        [Description("Battle Chateau")]
        Battle_Chateau = 48,

        [Description("Route 10")]
        Route_10 = 50,

        [Description("Menhir Trail")]
        Menhir_Trail = 51,

        [Description("Geosenge Town")]
        Geosenge_Town = 52,

        [Description("Route 11")]
        Route_11 = 54,

        [Description("Miroir Way")]
        Miroir_Way = 55,

        [Description("Reflection Cave")]
        Reflection_Cave = 56,

        [Description("Shalour City")]
        Shalour_City = 58,

        [Description("Tower of Mastery")]
        Tower_of_Mastery = 60,

        [Description("Route 12")]
        Route_12 = 62,

        [Description("Fourrage Road")]
        Fourrage_Road = 63,

        [Description("Coumarine City")]
        Coumarine_City = 64,

        [Description("Route 13")]
        Route_13 = 66,

        [Description("Lumiose Badlands")]
        Lumiose_Badlands = 67,

        [Description("Route 14")]
        Route_14 = 68,

        [Description("Laverre Nature Trail")]
        Laverre_Nature_Trail = 69,

        [Description("Laverre City")]
        Laverre_City = 70,

        [Description("Poke Ball Factory")]
        Poke_Ball_Factory = 72,

        [Description("Route 15")]
        Route_15 = 74,

        [Description("Brun Way")]
        Brun_Way = 75,

        [Description("Dendemille Town")]
        Dendemille_Town = 76,

        [Description("Route 16")]
        Route_16 = 78,

        [Description("Mélancolie Path")]
        Melancolie_Path = 79,

        [Description("Frost Cavern")]
        Frost_Cavern = 82,

        [Description("Route 17")]
        Route_17 = 84,

        [Description("Mamoswine Road")]
        Mamoswine_Road = 85,

        [Description("Anistar City")]
        Anistar_City = 86,

        [Description("Route 18")]
        Route_18 = 88,

        [Description("Vallée Étroite Way")]
        Vallee_Étroite_Way = 89,

        [Description("Couriway Town")]
        Couriway_Town = 90,

        [Description("Route 19")]
        Route_19 = 92,

        [Description("Grande Vallée Way")]
        Grande_Vallee_Way = 93,

        [Description("Snowbelle City")]
        Snowbelle_City = 94,

        [Description("Route 20")]
        Route_20 = 96,

        [Description("Winding Woods")]
        Winding_Woods = 97,

        [Description("Pokémon Village")]
        Pokemon_Village = 98,

        [Description("Route 21")]
        Route_21 = 100,

        [Description("Dernière Way")]
        Dernière_Way = 101,

        [Description("Route 22")]
        Route_22 = 102,

        [Description("Détourner Way")]
        Detourner_Way = 103,

        [Description("Victory Road (Kalos)")]
        Victory_Road_Kalos = 104,

        [Description("Pokémon League (Kalos)")]
        Pokemon_League_Kalos = 106,

        [Description("Kiloude City")]
        Kiloude_City = 108,

        [Description("Battle Maison")]
        Battle_Maison = 110,

        [Description("Azure Bay")]
        Azure_Bay = 112,

        [Description("Dendemille Gate")]
        Dendemille_Gate = 114,

        [Description("Couriway Gate")]
        Couriway_Gate = 116,

        [Description("Ambrette Gate")]
        Ambrette_Gate = 118,

        [Description("Lumiose Gate")]
        Lumiose_Gate = 120,

        [Description("Shalour Gate")]
        Shalour_Gate = 122,

        [Description("Coumarine Gate")]
        Coumarine_Gate = 124,

        [Description("Laverre Gate")]
        Laverre_Gate = 126,

        [Description("Anistar Gate")]
        Anistar_Gate = 128,

        [Description("Snowbelle Gate")]
        Snowbelle_Gate = 130,

        [Description("Glittering Cave")]
        Glittering_Cave = 132,

        [Description("Connecting Cave")]
        Connecting_Cave = 134,

        [Description("Zubat Roost")]
        Zubat_Roost = 135,

        [Description("Kalos Power Plant")]
        Kalos_Power_Plant = 136,

        [Description("Team Flare Secret HQ")]
        Team_Flare_Secret_HQ = 138,

        [Description("Terminus Cave")]
        Terminus_Cave = 140,

        [Description("Lost Hotel")]
        Lost_Hotel = 142,

        [Description("Chamber of Emptiness")]
        Chamber_of_Emptiness = 144,

        [Description("Sea Spirit's Den")]
        Sea_Spirits_Den = 146,

        [Description("Friend Safari")]
        Friend_Safari = 148,

        [Description("Blazing Chamber")]
        Blazing_Chamber = 150,

        [Description("Flood Chamber")]
        Flood_Chamber = 152,

        [Description("Ironworks Chamber")]
        Ironworks_Chamber = 154,

        [Description("Dragonmark Chamber")]
        Dragonmark_Chamber = 156,

        [Description("Radiant Chamber")]
        Radiant_Chamber = 158,

        [Description("Pokémon League Gate")]
        Pokemon_League_Gate = 160,

        [Description("Lumiose Station")]
        Lumiose_Station = 162,

        [Description("Kiloude Station")]
        Kiloude_Station = 164,

        [Description("Ambrette Aquarium")]
        Ambrette_Aquarium = 166,

        [Description("Unknown Dungeon")]
        Unknown_Dungeon = 168,

        [Description("Littleroot Town")]
        Littleroot_Town = 170,

        [Description("Oldale Town")]
        Oldale_Town = 172,

        [Description("Dewford Town")]
        Dewford_Town = 174,

        [Description("Lavaridge Town")]
        Lavaridge_Town = 176,

        [Description("Fallarbor Town")]
        Fallarbor_Town = 178,

        [Description("Verdanturf Town")]
        Verdanturf_Town = 180,

        [Description("Pacifidlog Town")]
        Pacifidlog_Town = 182,

        [Description("Petalburg City")]
        Petalburg_City = 184,

        [Description("Slateport City")]
        Slateport_City = 186,

        [Description("Mauville City")]
        Mauville_City = 188,

        [Description("Rustboro City")]
        Rustboro_City = 190,

        [Description("Fortree City")]
        Fortree_City = 192,

        [Description("Lilycove City")]
        Lilycove_City = 194,

        [Description("Mossdeep City")]
        Mossdeep_City = 196,

        [Description("Sootopolis City")]
        Sootopolis_City = 198,

        [Description("Ever Grande City")]
        Ever_Grande_City = 200,

        [Description("Pokémon League (Hoenn)")]
        Pokemon_League_Hoenn = 202,

        [Description("Route 101")]
        Route_101 = 204,

        [Description("Route 102")]
        Route_102 = 206,

        [Description("Route 103")]
        Route_103 = 208,

        [Description("Route 104")]
        Route_104 = 210,

        [Description("Route 105")]
        Route_105 = 212,

        [Description("Route 106")]
        Route_106 = 214,

        [Description("Route 107")]
        Route_107 = 216,

        [Description("Route 108")]
        Route_108 = 218,

        [Description("Route 109")]
        Route_109 = 220,

        [Description("Route 110")]
        Route_110 = 222,

        [Description("Route 111")]
        Route_111 = 224,

        [Description("Route 112")]
        Route_112 = 226,

        [Description("Route 113")]
        Route_113 = 228,

        [Description("Route 114")]
        Route_114 = 230,

        [Description("Route 115")]
        Route_115 = 232,

        [Description("Route 116")]
        Route_116 = 234,

        [Description("Route 117")]
        Route_117 = 236,

        [Description("Route 118")]
        Route_118 = 238,

        [Description("Route 119")]
        Route_119 = 240,

        [Description("Route 120")]
        Route_120 = 242,

        [Description("Route 121")]
        Route_121 = 244,

        [Description("Route 122")]
        Route_122 = 246,

        [Description("Route 123")]
        Route_123 = 248,

        [Description("Route 124")]
        Route_124 = 250,

        [Description("Route 125")]
        Route_125 = 252,

        [Description("Route 126")]
        Route_126 = 254,

        [Description("Route 127")]
        Route_127 = 256,

        [Description("Route 128")]
        Route_128 = 258,

        [Description("Route 129")]
        Route_129 = 260,

        [Description("Route 130")]
        Route_130 = 262,

        [Description("Route 131")]
        Route_131 = 264,

        [Description("Route 132")]
        Route_132 = 266,

        [Description("Route 133")]
        Route_133 = 268,

        [Description("Route 134")]
        Route_134 = 270,

        [Description("Meteor Falls")]
        Meteor_Falls = 272,

        [Description("Rusturf Tunnel")]
        Rusturf_Tunnel = 274,

        [Description(" ??? (Inside of Truck)")]
        Inside_of_Truck = 276,

        [Description("Desert Ruins")]
        Desert_Ruins = 278,

        [Description("Granite Cave")]
        Granite_Cave = 280,

        [Description("Petalburg Woods")]
        Petalburg_Woods = 282,

        [Description("Mt. Chimney")]
        Mt_Chimney = 284,

        [Description("Jagged Pass")]
        Jagged_Pass = 286,

        [Description("Fiery Path")]
        Fiery_Path = 288,

        [Description("Mt. Pyre")]
        Mt_Pyre = 290,

        [Description("Team Aqua Hideout")]
        Team_Aqua_Hideout = 292,

        [Description("Seafloor Cavern")]
        Seafloor_Cavern = 294,

        [Description("Cave of Origin")]
        Cave_of_Origin = 296,

        [Description("Victory Road (Hoenn)")]
        Victory_Road_Hoenn = 298,

        [Description("Shoal Cave")]
        Shoal_Cave = 300,

        [Description("New Mauville")]
        New_Mauville = 302,

        [Description("Sea Mauville")]
        Sea_Mauville = 304,

        [Description("Island Cave")]
        Island_Cave = 306,

        [Description("Ancient Tomb")]
        Ancient_Tomb = 308,

        [Description("Sealed Chamber")]
        Sealed_Chamber = 310,

        [Description("Scorched Slab")]
        Scorched_Slab = 312,

        [Description("Team Magma Hideout")]
        Team_Magma_Hideout = 314,

        [Description("Sky Pillar")]
        Sky_Pillar = 316,

        [Description("Battle Resort")]
        Battle_Resort = 318,

        [Description("Southern Island")]
        Southern_Island = 320,

        [Description("S.S. Tidal")]
        SS_Tidal = 322,

        [Description("Safari Zone")]
        Safari_Zone = 324,

        [Description("Mirage Forest")]
        Mirage_Forest = 326,

        [Description("Mirage Cave")]
        Mirage_Cave = 328,

        [Description("Mirage Island")]
        Mirage_Island = 330,

        [Description("Mirage Mountain")]
        Mirage_Mountain = 332,

        [Description("Trackless Forest")]
        Trackless_Forest = 334,

        [Description("Pathless Plain")]
        Pathless_Plain = 336,

        [Description("Nameless Cavern")]
        Nameless_Cavern = 338,

        [Description("Fabled Cave")]
        Fabled_Cave = 340,

        [Description("Gnarled Den")]
        Gnarled_Den = 342,

        [Description("Crescent Isle")]
        Crescent_Isle = 344,

        [Description("Secret Islet")]
        Secret_Islet = 346,

        [Description("Soaring in the sky")]
        Soaring_in_the_sky = 348,

        [Description("Secret Shore")]
        Secret_Shore = 350,

        [Description("Secret Meadow")]
        Secret_Meadow = 352,

        [Description("Secret Base")]
        Secret_Base = 354,

        [Description("a Link Trade")]
        a_Link_Trade = 30001,

        [Description("a Link Trade")]
        a_Link_Trade2 = 30002,

        [Description("the Kanto region")]
        the_Kanto_region = 30003,

        [Description("the Johto region")]
        the_Johto_region = 30004,

        [Description("the Hoenn region")]
        the_Hoenn_region = 30005,

        [Description("the Sinnoh region")]
        the_Sinnoh_region = 30006,

        [Description("a distant land")]
        a_distant_land = 30007,

        [Description("----------")]
        __________ = 30008,

        [Description("the Unova region")]
        the_Unova_region = 30009,

        [Description("the Kalos region")]
        the_Kalos_region = 30010,

        [Description("Pokémon Link")]
        Pokemon_Link = 30011,

        [Description("a lovely place")]
        a_lovely_place = 40001,

        [Description("a faraway place")]
        a_faraway_place = 40002,

        [Description("a Pokémon movie")]
        a_Pokemon_movie = 40003,

        [Description("Pokémon Movie 13")]
        Pokemon_Movie_13 = 40004,

        [Description("Pokémon Movie 14")]
        Pokemon_Movie_14 = 40005,

        [Description("Pokémon Movie 15")]
        Pokemon_Movie_15 = 40006,

        [Description("Pokémon Movie 16")]
        Pokemon_Movie_16 = 40007,

        [Description("Pokémon Movie 17")]
        Pokemon_Movie_17 = 40008,

        [Description("Pokémon Movie 18")]
        Pokemon_Movie_18 = 40009,

        [Description("a Pokémon Center")]
        a_Pokemon_Center = 40010,

        [Description("the Pokémon cartoon")]
        the_Pokemon_cartoon = 40011,

        [Description("PC Tokyo")]
        PC_Tokyo = 40012,

        [Description("PC Osaka")]
        PC_Osaka = 40013,

        [Description("PC Fukuoka")]
        PC_Fukuoka = 40014,

        [Description("PC Nagoya")]
        PC_Nagoya = 40015,

        [Description("PC Sapporo")]
        PC_Sapporo = 40016,

        [Description("PC Yokohama")]
        PC_Yokohama = 40017,

        [Description("PC Tohoku")]
        PC_Tohoku = 40018,

        [Description("PC Tokyo Bay")]
        PC_Tokyo_Bay = 40019,

        [Description("a Pokémon Store")]
        a_Pokemon_Store = 40020,

        [Description("a WCS")]
        a_WCS = 40021,

        [Description("WCS 2013")]
        WCS_2013 = 40022,

        [Description("WCS 2014")]
        WCS_2014 = 40023,

        [Description("WCS 2015")]
        WCS_2015 = 40024,

        [Description("WCS 2016")]
        WCS_2016 = 40025,

        [Description("WCS 2017")]
        WCS_2017 = 40026,

        [Description("WCS 2018")]
        WCS_2018 = 40027,

        [Description("Worlds")]
        Worlds = 40028,

        [Description("Worlds 2013")]
        Worlds_2013 = 40029,

        [Description("Worlds 2014")]
        Worlds_2014 = 40030,

        [Description("Worlds 2015")]
        Worlds_2015 = 40031,

        [Description("Worlds 2016")]
        Worlds_2016 = 40032,

        [Description("Worlds 2017")]
        Worlds_2017 = 40033,

        [Description("Worlds 2018")]
        Worlds_2018 = 40034,

        [Description("a VGE")]
        a_VGE = 40035,

        [Description("VGE 2013")]
        VGE_2013 = 40036,

        [Description("VGE 2014")]
        VGE_2014 = 40037,

        [Description("VGE 2015")]
        VGE_2015 = 40038,

        [Description("VGE 2016")]
        VGE_2016 = 40039,

        [Description("VGE 2017")]
        VGE_2017 = 40040,

        [Description("VGE 2018")]
        VGE_2018 = 40041,

        [Description("a Pokémon event")]
        a_Pokemon_event = 40042,

        [Description("a Battle Competition")]
        a_Battle_Competition = 40043,

        [Description("a game event")]
        a_game_event = 40044,

        [Description("the Pokémon Fan Club")]
        the_Pokemon_Fan_Club = 40045,

        [Description("a Pokémon TV program")]
        a_Pokemon_TV_program = 40046,

        [Description("a concert")]
        a_concert = 40047,

        [Description("an online Present")]
        an_online_Present = 40048,

        [Description("the PGL")]
        the_PGL = 40049,

        [Description("Pokémon Event 13")]
        Pokemon_Event_13 = 40050,

        [Description("Pokémon Event 14")]
        Pokemon_Event_14 = 40051,

        [Description("Pokémon Event 15")]
        Pokemon_Event_15 = 40052,

        [Description("Pokémon Event 16")]
        Pokemon_Event_16 = 40053,

        [Description("Pokémon Event 17")]
        Pokemon_Event_17 = 40054,

        [Description("Pokémon Event 18")]
        Pokemon_Event_18 = 40055,

        [Description("Pokémon Festa")]
        Pokemon_Festa = 40056,

        [Description("Pokémon Festa 13")]
        Pokemon_Festa_13 = 40057,

        [Description("Pokémon Festa 14")]
        Pokemon_Festa_14 = 40058,

        [Description("Pokémon Festa 15")]
        Pokemon_Festa_15 = 40059,

        [Description("Pokémon Festa 16")]
        Pokemon_Festa_16 = 40060,

        [Description("Pokémon Festa 17")]
        Pokemon_Festa_17 = 40061,

        [Description("Pokémon Festa 18")]
        Pokemon_Festa_18 = 40062,

        [Description("POKÉPARK")]
        POKEPARK = 40063,

        [Description("POKÉPARK")]
        POKEPARK2 = 40064,

        [Description("POKÉPARK")]
        POKEPARK3 = 40065,

        [Description("POKÉPARK")]
        POKEPARK4 = 40066,

        [Description("POKÉPARK")]
        POKEPARK5 = 40067,

        [Description("POKÉPARK")]
        POKEPARK6 = 40068,

        [Description("POKÉPARK")]
        POKEPARK7 = 40069,

        [Description("an event site")]
        an_event_site = 40070,

        [Description("GAME FREAK")]
        GAME_FREAK = 40071,

        [Description("a stadium")]
        a_stadium = 40072,

        [Description("a VGC")]
        a_VGC = 40073,

        [Description("the VGC 2013")]
        the_VGC_2013 = 40074,

        [Description("the VGC 2014")]
        the_VGC_2014 = 40075,

        [Description("the VGC 2015")]
        the_VGC_2015 = 40076,

        [Description("the VGC 2016")]
        the_VGC_2016 = 40077,

        [Description("the VGC 2017")]
        the_VGC_2017 = 40078,

        [Description("the VGC 2018")]
        the_VGC_2018 = 40079,

        [Description("a stranger")]
        a_stranger = 60001,

        [Description("Day-Care")]
        Day_Care = 60002,

        [Description("a treasure hunter")]
        a_treasure_hunter = 60003,

        [Description("an old hot-springs visitor")]
        an_old_hot_springs_visitor = 60004
    }

    public enum Abilities : byte
    {
        [Description("No Ability")]
        NoAbility = 0,

        [Description("Stench")]
        Stench = 1,

        [Description("Drizzle")]
        Drizzle = 2,

        [Description("Speed Boost")]
        Speed_Boost = 3,

        [Description("Battle Armor")]
        Battle_Armor = 4,

        [Description("Sturdy")]
        Sturdy = 5,

        [Description("Damp")]
        Damp = 6,

        [Description("Limber")]
        Limber = 7,

        [Description("Sand Veil")]
        Sand_Veil = 8,

        [Description("Static")]
        Static = 9,

        [Description("Volt Absorb")]
        Volt_Absorb = 10,

        [Description("Water Absorb")]
        Water_Absorb = 11,

        [Description("Oblivious")]
        Oblivious = 12,

        [Description("Cloud Nine")]
        Cloud_Nine = 13,

        [Description("Compound Eyes")]
        Compound_Eyes = 14,

        [Description("Insomnia")]
        Insomnia = 15,

        [Description("Color Change")]
        Color_Change = 16,

        [Description("Immunity")]
        Immunity = 17,

        [Description("Flash Fire")]
        Flash_Fire = 18,

        [Description("Shield Dust")]
        Shield_Dust = 19,

        [Description("Own Tempo")]
        Own_Tempo = 20,

        [Description("Suction Cups")]
        Suction_Cups = 21,

        [Description("Intimidate")]
        Intimidate = 22,

        [Description("Shadow Tag")]
        Shadow_Tag = 23,

        [Description("Rough Skin")]
        Rough_Skin = 24,

        [Description("Wonder Guard")]
        Wonder_Guard = 25,

        [Description("Levitate")]
        Levitate = 26,

        [Description("Effect Spore")]
        Effect_Spore = 27,

        [Description("Synchronize")]
        Synchronize = 28,

        [Description("Clear Body")]
        Clear_Body = 29,

        [Description("Natural Cure")]
        Natural_Cure = 30,

        [Description("Lightning Rod")]
        Lightning_Rod = 31,

        [Description("Serene Grace")]
        Serene_Grace = 32,

        [Description("Swift Swim")]
        Swift_Swim = 33,

        [Description("Chlorophyll")]
        Chlorophyll = 34,

        [Description("Illuminate")]
        Illuminate = 35,

        [Description("Trace")]
        Trace = 36,

        [Description("Huge Power")]
        Huge_Power = 37,

        [Description("Poison Point")]
        Poison_Point = 38,

        [Description("Inner Focus")]
        Inner_Focus = 39,

        [Description("Magma Armor")]
        Magma_Armor = 40,

        [Description("Water Veil")]
        Water_Veil = 41,

        [Description("Magnet Pull")]
        Magnet_Pull = 42,

        [Description("Soundproof")]
        Soundproof = 43,

        [Description("Rain Dish")]
        Rain_Dish = 44,

        [Description("Sand Stream")]
        Sand_Stream = 45,

        [Description("Pressure")]
        Pressure = 46,

        [Description("Thick Fat")]
        Thick_Fat = 47,

        [Description("Early Bird")]
        Early_Bird = 48,

        [Description("Flame Body")]
        Flame_Body = 49,

        [Description("Run Away")]
        Run_Away = 50,

        [Description("Keen Eye")]
        Keen_Eye = 51,

        [Description("Hyper Cutter")]
        Hyper_Cutter = 52,

        [Description("Pickup")]
        Pickup = 53,

        [Description("Truant")]
        Truant = 54,

        [Description("Hustle")]
        Hustle = 55,

        [Description("Cute Charm")]
        Cute_Charm = 56,

        [Description("Plus")]
        Plus = 57,

        [Description("Minus")]
        Minus = 58,

        [Description("Forecast")]
        Forecast = 59,

        [Description("Sticky Hold")]
        Sticky_Hold = 60,

        [Description("Shed Skin")]
        Shed_Skin = 61,

        [Description("Guts")]
        Guts = 62,

        [Description("Marvel Scale")]
        Marvel_Scale = 63,

        [Description("Liquid Ooze")]
        Liquid_Ooze = 64,

        [Description("Overgrow")]
        Overgrow = 65,

        [Description("Blaze")]
        Blaze = 66,

        [Description("Torrent")]
        Torrent = 67,

        [Description("Swarm")]
        Swarm = 68,

        [Description("Rock Head")]
        Rock_Head = 69,

        [Description("Drought")]
        Drought = 70,

        [Description("Arena Trap")]
        Arena_Trap = 71,

        [Description("Vital Spirit")]
        Vital_Spirit = 72,

        [Description("White Smoke")]
        White_Smoke = 73,

        [Description("Pure Power")]
        Pure_Power = 74,

        [Description("Shell Armor")]
        Shell_Armor = 75,

        [Description("Air Lock")]
        Air_Lock = 76,

        [Description("Tangled Feet")]
        Tangled_Feet = 77,

        [Description("Motor Drive")]
        Motor_Drive = 78,

        [Description("Rivalry")]
        Rivalry = 79,

        [Description("Steadfast")]
        Steadfast = 80,

        [Description("Snow Cloak")]
        Snow_Cloak = 81,

        [Description("Gluttony")]
        Gluttony = 82,

        [Description("Anger Point")]
        Anger_Point = 83,

        [Description("Unburden")]
        Unburden = 84,

        [Description("Heatproof")]
        Heatproof = 85,

        [Description("Simple")]
        Simple = 86,

        [Description("Dry Skin")]
        Dry_Skin = 87,

        [Description("Download")]
        Download = 88,

        [Description("Iron Fist")]
        Iron_Fist = 89,

        [Description("Poison Heal")]
        Poison_Heal = 90,

        [Description("Adaptability")]
        Adaptability = 91,

        [Description("Skill Link")]
        Skill_Link = 92,

        [Description("Hydration")]
        Hydration = 93,

        [Description("Solar Power")]
        Solar_Power = 94,

        [Description("Quick Feet")]
        Quick_Feet = 95,

        [Description("Normalize")]
        Normalize = 96,

        [Description("Sniper")]
        Sniper = 97,

        [Description("Magic Guard")]
        Magic_Guard = 98,

        [Description("No Guard")]
        No_Guard = 99,

        [Description("Stall")]
        Stall = 100,

        [Description("Technician")]
        Technician = 101,

        [Description("Leaf Guard")]
        Leaf_Guard = 102,

        [Description("Klutz")]
        Klutz = 103,

        [Description("Mold Breaker")]
        Mold_Breaker = 104,

        [Description("Super Luck")]
        Super_Luck = 105,

        [Description("Aftermath")]
        Aftermath = 106,

        [Description("Anticipation")]
        Anticipation = 107,

        [Description("Forewarn")]
        Forewarn = 108,

        [Description("Unaware")]
        Unaware = 109,

        [Description("Tinted Lens")]
        Tinted_Lens = 110,

        [Description("Filter")]
        Filter = 111,

        [Description("Slow Start")]
        Slow_Start = 112,

        [Description("Scrappy")]
        Scrappy = 113,

        [Description("Storm Drain")]
        Storm_Drain = 114,

        [Description("Ice Body")]
        Ice_Body = 115,

        [Description("Solid Rock")]
        Solid_Rock = 116,

        [Description("Snow Warning")]
        Snow_Warning = 117,

        [Description("Honey Gather")]
        Honey_Gather = 118,

        [Description("Frisk")]
        Frisk = 119,

        [Description("Reckless")]
        Reckless = 120,

        [Description("Multitype")]
        Multitype = 121,

        [Description("Flower Gift")]
        Flower_Gift = 122,

        [Description("Bad Dreams")]
        Bad_Dreams = 123,

        [Description("Pickpocket")]
        Pickpocket = 124,

        [Description("Sheer Force")]
        Sheer_Force = 125,

        [Description("Contrary")]
        Contrary = 126,

        [Description("Unnerve")]
        Unnerve = 127,

        [Description("Defiant")]
        Defiant = 128,

        [Description("Defeatist")]
        Defeatist = 129,

        [Description("Cursed Body")]
        Cursed_Body = 130,

        [Description("Healer")]
        Healer = 131,

        [Description("Friend Guard")]
        Friend_Guard = 132,

        [Description("Weak Armor")]
        Weak_Armor = 133,

        [Description("Heavy Metal")]
        Heavy_Metal = 134,

        [Description("Light Metal")]
        Light_Metal = 135,

        [Description("Multiscale")]
        Multiscale = 136,

        [Description("Toxic Boost")]
        Toxic_Boost = 137,

        [Description("Flare Boost")]
        Flare_Boost = 138,

        [Description("Harvest")]
        Harvest = 139,

        [Description("Telepathy")]
        Telepathy = 140,

        [Description("Moody")]
        Moody = 141,

        [Description("Overcoat")]
        Overcoat = 142,

        [Description("Poison Touch")]
        Poison_Touch = 143,

        [Description("Regenerator")]
        Regenerator = 144,

        [Description("Big Pecks")]
        Big_Pecks = 145,

        [Description("Sand Rush")]
        Sand_Rush = 146,

        [Description("Wonder Skin")]
        Wonder_Skin = 147,

        [Description("Analytic")]
        Analytic = 148,

        [Description("Illusion")]
        Illusion = 149,

        [Description("Imposter")]
        Imposter = 150,

        [Description("Infiltrator")]
        Infiltrator = 151,

        [Description("Mummy")]
        Mummy = 152,

        [Description("Moxie")]
        Moxie = 153,

        [Description("Justified")]
        Justified = 154,

        [Description("Rattled")]
        Rattled = 155,

        [Description("Magic Bounce")]
        Magic_Bounce = 156,

        [Description("Sap Sipper")]
        Sap_Sipper = 157,

        [Description("Prankster")]
        Prankster = 158,

        [Description("Sand Force")]
        Sand_Force = 159,

        [Description("Iron Barbs")]
        Iron_Barbs = 160,

        [Description("Zen Mode")]
        Zen_Mode = 161,

        [Description("Victory Star")]
        Victory_Star = 162,

        [Description("Turboblaze")]
        Turboblaze = 163,

        [Description("Teravolt")]
        Teravolt = 164,

        [Description("Aroma Veil")]
        Aroma_Veil = 165,

        [Description("Flower Veil")]
        Flower_Veil = 166,

        [Description("Cheek Pouch")]
        Cheek_Pouch = 167,

        [Description("Protean")]
        Protean = 168,

        [Description("Fur Coat")]
        Fur_Coat = 169,

        [Description("Magician")]
        Magician = 170,

        [Description("Bulletproof")]
        Bulletproof = 171,

        [Description("Competitive")]
        Competitive = 172,

        [Description("Strong Jaw")]
        Strong_Jaw = 173,

        [Description("Refrigerate")]
        Refrigerate = 174,

        [Description("Sweet Veil")]
        Sweet_Veil = 175,

        [Description("Stance Change")]
        Stance_Change = 176,

        [Description("Gale Wings")]
        Gale_Wings = 177,

        [Description("Mega Launcher")]
        Mega_Launcher = 178,

        [Description("Grass Pelt")]
        Grass_Pelt = 179,

        [Description("Symbiosis")]
        Symbiosis = 180,

        [Description("Tough Claws")]
        Tough_Claws = 181,

        [Description("Pixilate")]
        Pixilate = 182,

        [Description("Gooey")]
        Gooey = 183,

        [Description("Aerilate")]
        Aerilate = 184,

        [Description("Parental Bond")]
        Parental_Bond = 185,

        [Description("Dark Aura")]
        Dark_Aura = 186,

        [Description("Fairy Aura")]
        Fairy_Aura = 187,

        [Description("Aura Break")]
        Aura_Break = 188,

        [Description("Primordial Sea")]
        Primordial_Sea = 189,

        [Description("Desolate Land")]
        Desolate_Land = 190,

        [Description("Delta Stream")]
        Delta_Stream = 191
    }

    public enum Natures : byte
    {
        [Description("Hardy")]
        Hardy = 0,

        [Description("Lonely")]
        Lonely = 1,

        [Description("Brave")]
        Brave = 2,

        [Description("Adamant")]
        Adamant = 3,

        [Description("Naughty")]
        Naughty = 4,

        [Description("Bold")]
        Bold = 5,

        [Description("Docile")]
        Docile = 6,

        [Description("Relaxed")]
        Relaxed = 7,

        [Description("Impish")]
        Impish = 8,

        [Description("Lax")]
        Lax = 9,

        [Description("Timid")]
        Timid = 10,

        [Description("Hasty")]
        Hasty = 11,

        [Description("Serious")]
        Serious = 12,

        [Description("Jolly")]
        Jolly = 13,

        [Description("Naive")]
        Naive = 14,

        [Description("Modest")]
        Modest = 15,

        [Description("Mild")]
        Mild = 16,

        [Description("Quiet")]
        Quiet = 17,

        [Description("Bashful")]
        Bashful = 18,

        [Description("Rash")]
        Rash = 19,

        [Description("Calm")]
        Calm = 20,

        [Description("Gentle")]
        Gentle = 21,

        [Description("Sassy")]
        Sassy = 22,

        [Description("Careful")]
        Careful = 23,

        [Description("Quirky")]
        Quirky = 24
    }

    public enum PokemonColors
    {
        Black = 0x5A5A5A,
        Blue = 0x318CF7,
        Brown = 0xB57331,
        Gray = 0xA5A5A5,
        Green = 0x42BD6B,
        Pink = 0xFF94CE,
        Purple = 0xAD6BC6,
        Red = 0xF75A6B,
        White = 0xF7F7F7,
        Yellow = 0xF7D64A
    }

    public enum SpindaSpots
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

    public enum SpindaColorsBase : uint
    {
        BaseLight = 0xffe6d6a5,
        BaseShaded = 0xffcea573
    }

    public enum SpindaColorsNormalSpot : uint
    {
        NormalSpotLight = 0xffef524a,
        NormalSpotShaded = 0xffbd4a31
    }

    public enum SpindaColorsShinySpot : uint
    {
        ShinySpotLight = 0xffa5ce10,
        ShinyShaded = 0xff7b9c00
    }

    public enum Markings
    {
        Circle,
        Triangle,
        Square,
        Heart,
        Star,
        Diamond
    }

    public enum Genders
    {
        Male,
        Female,
        Genderless
    }

    public enum NatureStats
    {
        HP = 1,
        Attack,
        Defense,
        SpecialAttack,
        SpecialDefense,
        Speed
    }

    public enum Stats
    {
        HP,
        Attack,
        Defense,
        SpecialAttack,
        SpecialDefense,
        Speed
    }

    public enum Types
    {
        [Description("Normal")]
        Normal,

        [Description("Fighting")]
        Fighting,

        [Description("Flying")]
        Flying,

        [Description("Poison")]
        Poison,

        [Description("Ground")]
        Ground,

        [Description("Rock")]
        Rock,

        [Description("Bug")]
        Bug,

        [Description("Ghost")]
        Ghost,

        [Description("Steel")]
        Steel,

        [Description("Fire")]
        Fire,

        [Description("Water")]
        Water,

        [Description("Grass")]
        Grass,

        [Description("Electric")]
        Electric,

        [Description("Psychic")]
        Psychic,

        [Description("Ice")]
        Ice,

        [Description("Dragon")]
        Dragon,

        [Description("Dark")]
        Dark,

        [Description("Fairy")]
        Fairy
    }

    public enum NatureEffect
    {
        Increase,
        Decrease,
        NoEffect
    }

    [Flags]
    public enum Ribbons_0x30
    {
        [Description("Kalos Champ Ribbon")]
        Kalos_Champ_Ribbon = 0x01,

        [Description("Champion Ribbon")]
        Champion_Ribbon = 0x02,

        [Description("Sinnoh Champ Ribbon")]
        Sinnoh_Champ_Ribbon = 0x04,

        [Description("Best Friends Ribbon")]
        Best_Friends_Ribbon = 0x08,

        [Description("Training Ribbon")]
        Training_Ribbon = 0x10,

        [Description("Skillful Battler Ribbon")]
        Skillful_Battler_Ribbon = 0x20,

        [Description("Expert Battler Ribbon")]
        Expert_Battler_Ribbon = 0x40,

        [Description("Effort Ribbon")]
        Effort_Ribbon = 0x80,
    }

    [Flags]
    public enum Ribbons_0x31
    {
        [Description("Alert Ribbon")]
        Alert_Ribbon = 0x01,

        [Description("Shock Ribbon")]
        Shock_Ribbon = 0x02,

        [Description("Downcast Ribbon")]
        Downcast_Ribbon = 0x04,

        [Description("Careless Ribbon")]
        Careless_Ribbon = 0x08,

        [Description("Relax Ribbon")]
        Relax_Ribbon = 0x10,

        [Description("Snooze Ribbon")]
        Snooze_Ribbon = 0x20,

        [Description("Smile Ribbon")]
        Smile_Ribbon = 0x40,

        [Description("Gorgeous Ribbon")]
        Gorgeous_Ribbon = 0x80,
    }

    [Flags]
    public enum Ribbons_0x32
    {
        [Description("Royal Ribbon")]
        Royal_Ribbon = 0x01,

        [Description("Gorgeous Royal Ribbon")]
        Gorgeous_Royal_Ribbon = 0x02,

        [Description("Artist Ribbon")]
        Artist_Ribbon = 0x04,

        [Description("Footprint Ribbon")]
        Footprint_Ribbon = 0x08,

        [Description("Record Ribbon")]
        Record_Ribbon = 0x10,

        [Description("Legend Ribbon")]
        Legend_Ribbon = 0x20,

        [Description("Country Ribbon")]
        Country_Ribbon = 0x40,

        [Description("National Ribbon")]
        National_Ribbon = 0x80,
    }

    [Flags]
    public enum Ribbons_0x33
    {
        [Description("Earth Ribbon")]
        Earth_Ribbon = 0x01,

        [Description("World Ribbon")]
        World_Ribbon = 0x02,

        [Description("Classic Ribbon")]
        Classic_Ribbon = 0x04,

        [Description("Premier Ribbon")]
        Premier_Ribbon = 0x08,

        [Description("Event Ribbon")]
        Event_Ribbon = 0x10,

        [Description("Birthday Ribbon")]
        Birthday_Ribbon = 0x20,

        [Description("Special Ribbon")]
        Special_Ribbon = 0x40,

        [Description("Souvenir Ribbon")]
        Souvenir_Ribbon = 0x80,
    }

    [Flags]
    public enum Ribbons_0x34
    {
        [Description("Wishing Ribbon")]
        Wishing_Ribbon = 0x01,

        [Description("Battle Champion Ribbon")]
        Battle_Champion_Ribbon = 0x02,

        [Description("Regional Champion Ribbon")]
        Regional_Champion_Ribbon = 0x04,

        [Description("National Champion Ribbon")]
        National_Champion_Ribbon = 0x08,

        [Description("World Champion Ribbon")]
        World_Champion_Ribbon = 0x10,

        [Description("Hoenn Champion Ribbon")]
        Hoenn_Champion_Ribbon = 0x80,
    }

    [Flags]
    public enum Ribbons_0x35
    {
        [Description("Contest Star Ribbon")]
        Contest_Star_Ribbon = 0x01,

        [Description("Coolness Master Ribbon")]
        Coolness_Master_Ribbon = 0x02,

        [Description("Beauty Master Ribbon")]
        Beauty_Master_Ribbon = 0x04,

        [Description("Cuteness Master Ribbon")]
        Cuteness_Master_Ribbon = 0x08,

        [Description("Cleverness Master Ribbon")]
        Cleverness_Master_Ribbon = 0x10,

        [Description("Toughness Master Ribbon")]
        Toughness_Master_Ribbon = 0x20
    }

    [Flags]
    public enum Medals_0x2C
    {
        [Description("Sp. Atk Level 1")]
        Sp_Atk_Level_1 = 0x04,

        [Description("HP Level 1")]
        HP_Level_1 = 0x08,

        [Description("Atk Level 1")]
        Atk_Level_1 = 0x10,

        [Description("Sp. Def Level 1")]
        Sp_Def_Level_1 = 0x20,

        [Description("Speed Level 1")]
        Speed_Level_1 = 0x40,

        [Description("Def Level 1")]
        Def_Level_1 = 0x80,
    }

    [Flags]
    public enum Medals_0x2D
    {
        [Description("Sp. Atk Level 2")]
        Sp_Atk_Level_2 = 0x01,

        [Description("HP Level 2")]
        HP_Level_2 = 0x02,

        [Description("Atk Level 2")]
        Atk_Level_2 = 0x04,

        [Description("Sp. Def Level 2")]
        Sp_Def_Level_2 = 0x08,

        [Description("Speed Level 2")]
        Speed_Level_2 = 0x10,

        [Description("Def Level 2")]
        Def_Level_2 = 0x20,

        [Description("Sp. Atk Level 3")]
        Sp_Atk_Level_3 = 0x40,

        [Description("HP Level 3")]
        HP_Level_3 = 0x80,
    }

    [Flags]
    public enum Medals_0x2E
    {
        [Description("Atk Level 3")]
        Atk_Level_3 = 0x01,

        [Description("Sp. Def Level 3")]
        Sp_Def_Level_3 = 0x02,

        [Description("Speed Level 3")]
        Speed_Level_3 = 0x04,

        [Description("Def Level 3")]
        Def_Level_3 = 0x08,

        [Description("The Troubles Keep on Coming?!")]
        The_Troubles_Keep_on_Coming = 0x10,

        [Description("The Leaf Stone Cup Begins!")]
        The_Leaf_Stone_Cup_Begins = 0x20,

        [Description("The Fire Stone Cup Begins!")]
        The_Fire_Stone_Cup_Begins = 0x40,

        [Description("The Water Stone Cup Begins!")]
        The_Water_Stone_Cup_Begins = 0x80,
    }

    [Flags]
    public enum Medals_0x2F
    {
        [Description("Follow Those Fleeing Goals!")]
        Follow_Those_Fleeing_Goals = 0x01,

        [Description("Watch Out! That's One Tricky Second Half!")]
        Watch_Out_Thats_One_Tricky_Second_Half = 0x02,

        [Description("An Opening of Lighting-Quick Attacks!")]
        An_Opening_of_Lighting_Quick_Attacks = 0x04,

        [Description("Those Long Shots Are No Long Shot!")]
        Those_Long_Shots_Are_No_Long_Shot = 0x08,

        [Description("Scatterbug Lugs Back!")]
        Scatterbug_Lugs_Back = 0x10,

        [Description("A Barrage of Bitbots!")]
        A_Barrage_of_Bitbots = 0x20,

        [Description("Drag Down Hydreigon!")]
        Drag_Down_Hydreigon = 0x40,

        [Description("The Battle for the Best: Version X/Y!")]
        The_Battle_for_the_Best_Version_X_Y = 0x80,
    }

    public class ItemObject
    {
        public ItemObject(Items item)
        {
            Value = item;
        }

        private Items value;

        public Items Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Items), value)
                    ? (Items)value
                    : Items.NoItem;
            }
        }

        public Image Image
        {
            get { return Value == null ? null : Images.GetItemImage((ushort)Value); }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            ItemObject i = obj as ItemObject;
            if ((System.Object)i == null)
            {
                return false;
            }

            return Value == i.Value;
        }

        public bool Equals(Items i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public static bool operator ==(ItemObject a, Items b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(ItemObject a, Items b)
        {
            return !(a == b);
        }
    }

    public class SpeciesObject
    {
        public SpeciesObject(Species species)
        {
            Value = species;
        }

        private Species value;

        public Species Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Species), value)
                    ? (Species)value
                    : Species.NoSpecies;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }
    }

    public class LocationObject
    {
        public LocationObject(Locations location)
        {
            Value = location;
        }

        private Locations value;

        public Locations Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Locations), value)
                    ? (Locations)value
                    : Locations.Mystery_Zone;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }
    }

    public class MovesObject
    {
        public MovesObject(Moves move)
        {
            Value = move;
        }

        private Moves value;

        public Moves Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Moves), value)
                    ? (Moves)value
                    : Moves.NoMove;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public TypeObject? Type
        {
            get
            {
                int typeid = 0;
                var typequery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (typequery.Length == 0) return null;
                string typeidstr = typequery[0].ItemArray[(int)DBTools.MoveDataTableColumns.type_id].ToString();
                if (!int.TryParse(typeidstr, out typeid)) return new TypeObject();
                if (!Enum.IsDefined(typeof(Types), typeid)) return new TypeObject();
                return new TypeObject((Types)typeid);
            }
        }

        public Image TypeImage
        {
            get
            {
                if (!Type.HasValue) return null;
                return Type.Value.Image;
            }
        }

        public int Power
        {
            get
            {
                int power = 0;
                var powerquery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (powerquery.Length != 0)
                {
                    string powerstr = powerquery[0].ItemArray[(int)DBTools.MoveDataTableColumns.power].ToString();
                    int.TryParse(powerstr, out power);
                }
                return power;
            }
        }

        public decimal Accuracy
        {
            get
            {
                decimal accuracy = 0M;
                var accuracyquery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (accuracyquery.Length != 0)
                {
                    string accuracystr = accuracyquery[0].ItemArray[(int)DBTools.MoveDataTableColumns.accuracy].ToString();
                    decimal.TryParse(accuracystr, out accuracy);
                }
                return accuracy;
            }
        }

        public Image CategoryImage
        {
            get
            {
                var damageclassquery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (damageclassquery.Length == 0) return null;
                var damageclassidstr = damageclassquery[0].ItemArray[(int)DBTools.MoveDataTableColumns.damage_class_id].ToString();
                int damageclassid = -1;
                int.TryParse(damageclassidstr, out damageclassid);
                switch (damageclassid)
                {
                    case 1:
                        return Images.GetImageFromResource("physical");

                    case 2:
                        return Images.GetImageFromResource("special");

                    case 0:
                        return Images.GetImageFromResource("other");

                    default:
                        return null;
                }
            }
        }

        public string FlavorText
        {
            get
            {
                var flavor = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (flavor.Length != 0)
                {
                    return flavor[0].ItemArray[(int)DBTools.MoveDataTableColumns.flavor_text].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }
    }

    public class AbilityObject
    {
        public AbilityObject(Abilities abilities)
        {
            Value = abilities;
        }

        private Abilities value;

        public Abilities Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Abilities), value)
                    ? (Abilities)value
                    : Abilities.NoAbility;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }
    }

    public class NatureObject
    {
        public NatureObject(Natures nature)
        {
            Value = nature;
        }

        private Natures value;

        public Natures Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Natures), value)
                    ? (Natures)value
                    : Natures.Hardy;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }
    }

    public struct TypeObject
    {
        public TypeObject(Types Type)
        {
            this.value = Enum.IsDefined(typeof(Types), Type)
                ? (Types)Type
                : Types.Normal;
        }

        private Types value;

        public Types Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Types), value)
                    ? (Types)value
                    : Types.Normal;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public Image Image
        {
            get
            {
                return Images.GetTypeImage(Value);
            }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }
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