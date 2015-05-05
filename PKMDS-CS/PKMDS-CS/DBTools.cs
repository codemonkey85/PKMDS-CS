using System;
using System.Data;
using System.Data.Common;
using System.Text;

namespace PKMDS_CS
{
    public static class DBTools
    {
        private static DbConnection con;

        private static DataTable PokemonDataTable;
        private static DataTable ItemDataTable;
        private static DataTable NatureDataTable;

        public enum PokemonDataTableColumns
        {
            name,
            form_identifier,
            identifier,
            species_id,
            form_id,
            color_id,
            gender_rate,
            hatch_counter,
            has_gender_differences,
            growth_rate_id,
            type_1_id,
            type_1_name,
            type_2_id,
            type_2_name,
            hp,
            attack,
            defense,
            speed,
            sp_attack,
            sp_defense
        }

        public enum ItemDataTableColumns
        {
            id,
            identifier,
            name
        }

        public enum NatureDataTableColumns
        {
            game_index,
            name,
            decreased_stat_id,
            increased_stat_id
        }

        public static void OpenDB(string DBFile)
        {
            if (con != null) return;
            try
            {
                var connString = string.Format(@"Data Source={0}; Pooling=false; FailIfMissing=false;", DBFile);
                using (var factory = new System.Data.SQLite.SQLiteFactory())
                    con = factory.CreateConnection();
                con.ConnectionString = connString;
                con.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error opening database: {0}", ex.Message);
            }
        }

        public static void CloseDB()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error closing database: {0}", ex.Message);
            }
        }

        public static DataTable GetData(string SQL)
        {
            DataTable table = new DataTable();
            try
            {
                using (System.Data.Common.DbCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SQL;
                    table.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception)
            {
                return null;
            }
            return table;
        }

        private static int GetGrowthRateID(ushort species)
        {
            int growthrateid = 0;
            int.TryParse(DBTools.GetPokemonDataTable.Select(string.Format("{0} = {1}", DBTools.PokemonDataTableColumns.species_id,
                species))[0].ItemArray[(int)DBTools.PokemonDataTableColumns.growth_rate_id].ToString(), out growthrateid);
            return growthrateid;
        }

        public static int GetLevel(ushort species, uint EXP)
        {
            if (con == null) return 0;
            if (con.State != ConnectionState.Open) return 0;
            int level = 0;
            int GrowthRateID = GetGrowthRateID(species);
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(
                                @"select experience.level from experience where experience.growth_rate_id = {0} and experience.experience <= {1} order by experience.level desc limit 1",
                                GrowthRateID, EXP);
                DataTable dtout = new DataTable();
                dtout.Load(cmd.ExecuteReader());
                if (dtout != null)
                {
                    if (dtout.Rows.Count != 0)
                        int.TryParse(dtout.Rows[0].ItemArray[0].ToString(), out level);
                }
            }
            return level;
        }

        public static uint GetEXPAtLevel(ushort Species, int Level)
        {
            if (con == null) return 0u;
            if (con.State != ConnectionState.Open) return 0u;
            uint exp = 0;
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(@"select experience.experience from experience where experience.growth_rate_id = {0} and experience.level = {1} order by experience.level desc limit 1", GetGrowthRateID(Species), Level);
                DataTable dtout = new DataTable();
                dtout.Load(cmd.ExecuteReader());
                if (dtout != null)
                {
                    if (dtout.Rows.Count != 0)
                        uint.TryParse(dtout.Rows[0].ItemArray[0].ToString(), out exp);
                }
            }
            return exp;
        }

        public static string GetFormName(ushort Species, byte FormID, int langid = 9)
        {
            if (FormID == 0) return string.Empty;
            if (con == null) return string.Empty;
            if (con.State != ConnectionState.Open) return string.Empty;
            string formname = string.Empty;
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(@"select form_name from pokemon join pokemon_forms on pokemon.id = pokemon_forms.pokemon_id join pokemon_form_generations on pokemon_form_generations.pokemon_form_id = pokemon_forms.id join pokemon_form_names on pokemon_form_names.pokemon_form_id = pokemon_forms.id
                    where pokemon.species_id = {0} and pokemon_form_generations.game_index = {1} and local_language_id = {2}", Species, FormID, langid);
                DataTable dtout = new DataTable();
                dtout.Load(cmd.ExecuteReader());
                if (dtout != null)
                {
                    if (dtout.Rows.Count != 0)
                        formname = dtout.Rows[0].ItemArray[0].ToString();
                }
            }
            return formname;
        }

        internal static string GetPokemonName(ushort Species, byte FormID, int langid = 9)
        {
            if (con == null) return string.Empty;
            if (con.State != ConnectionState.Open) return string.Empty;
            string pokemonname = string.Empty;
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(@"select pokemon_name from pokemon join pokemon_forms on pokemon.id = pokemon_forms.pokemon_id join pokemon_form_names on pokemon_form_names.pokemon_form_id = pokemon_forms.id where pokemon.species_id = {0} and pokemon_forms.form_order -1 = {1} and local_language_id = {2} order by form_order", Species, FormID, langid);
                DataTable dtout = new DataTable();
                dtout.Load(cmd.ExecuteReader());
                if (dtout != null)
                {
                    if (dtout.Rows.Count != 0)
                    {
                        pokemonname = dtout.Rows[0].ItemArray[0].ToString();
                    }
                    else
                    {
                        dtout.Clear();
                        dtout.Load(cmd.ExecuteReader());
                        if (dtout.Rows.Count != 0)
                        {
                            pokemonname = dtout.Rows[0].ItemArray[0].ToString();
                        }
                    }
                }
            }
            return pokemonname;
        }

        public static DataTable GetPokemonDataTable
        {
            get
            {
                if (con == null) return null;
                if (con.State != ConnectionState.Open) return null;
                if (PokemonDataTable != null) return PokemonDataTable;
                var sbSQL = new StringBuilder();
                sbSQL.Append("--select pokemon_forms.identifier from pokemon join pokemon_forms on pokemon.id = pokemon_forms.pokemon_id join pokemon_form_names on pokemon_form_names.pokemon_form_id = pokemon_forms.id where pokemon.species_id = 666 and local_language_id = 9 and pokemon_forms.form_order -1 = 18 order by form_order \n");
                sbSQL.Append(" \n");
                sbSQL.Append("select \n");
                sbSQL.Append("pokemon_species_names.name as [name], \n");
                sbSQL.Append("pokemon_forms.form_identifier as [form_identifier], \n");
                sbSQL.Append("pokemon.identifier as [identifier], \n");
                sbSQL.Append("pokemon.species_id as [species_id], \n");
                sbSQL.Append("pokemon_forms.form_order -1 as [form_id], \n");
                sbSQL.Append("pokemon_species.color_id as [color_id], \n");
                sbSQL.Append("pokemon_species.gender_rate as [gender_rate], \n");
                sbSQL.Append("pokemon_species.hatch_counter as [hatch_counter], \n");
                sbSQL.Append("pokemon_species.has_gender_differences as [has_gender_differences], \n");
                sbSQL.Append("pokemon_species.growth_rate_id as [growth_rate_id], \n");
                sbSQL.Append("gametypes1.game_index as [type_1_id], \n");
                sbSQL.Append("type1name.name as [type_1_name], \n");
                sbSQL.Append("gametypes2.game_index as [type_2_id], \n");
                sbSQL.Append("type2name.name as [type_2_name], \n");
                sbSQL.Append("pokemonstats.hp as [hp], \n");
                sbSQL.Append("pokemonstats.attack as [attack], \n");
                sbSQL.Append("pokemonstats.defense as [defense], \n");
                sbSQL.Append("pokemonstats.speed as [speed], \n");
                sbSQL.Append("pokemonstats.spattack as [sp_attack], \n");
                sbSQL.Append("pokemonstats.spdefense as [sp_defense] \n");
                sbSQL.Append("from pokemon \n");
                sbSQL.Append("join pokemon_species_names on pokemon_species_names.pokemon_species_id = pokemon_species.id \n");
                sbSQL.Append("join pokemon_species on pokemon_species.id = pokemon.species_id \n");
                sbSQL.Append("join pokemon_forms on pokemon.id = pokemon_forms.pokemon_id \n");
                sbSQL.Append("join (select type1.pokemon_id, type1.type_id as [type_1], type2.type_id as [type_2] from pokemon_types [type1] join pokemon_types [type2] on type1.pokemon_id = type2.pokemon_id where type1.slot = 1 group by type1.pokemon_id) pokemontypes on pokemontypes.pokemon_id = pokemon.id \n");
                sbSQL.Append("join ( \n");
                sbSQL.Append("select \n");
                sbSQL.Append("hpstats.pokemon_id, \n");
                sbSQL.Append("hpstats.base_stat as [hp], \n");
                sbSQL.Append("atkstats.base_stat as [attack], \n");
                sbSQL.Append("defstats.base_stat as [defense], \n");
                sbSQL.Append("spdstats.base_stat as [speed], \n");
                sbSQL.Append("spatkstats.base_stat as [spattack], \n");
                sbSQL.Append("spdefstats.base_stat as [spdefense] \n");
                sbSQL.Append("from pokemon_stats hpstats \n");
                sbSQL.Append("join pokemon_stats atkstats on hpstats.pokemon_id = atkstats.pokemon_id \n");
                sbSQL.Append("join pokemon_stats defstats on atkstats.pokemon_id = defstats.pokemon_id \n");
                sbSQL.Append("join pokemon_stats spdstats on defstats.pokemon_id = spdstats.pokemon_id \n");
                sbSQL.Append("join pokemon_stats spatkstats on spdstats.pokemon_id = spatkstats.pokemon_id \n");
                sbSQL.Append("join pokemon_stats spdefstats on spatkstats.pokemon_id = spdefstats.pokemon_id \n");
                sbSQL.Append("where hpstats.stat_id = 1 and atkstats.stat_id = 2 and defstats.stat_id = 3 and spdstats.stat_id = 6 and spatkstats.stat_id = 4 and spdefstats.stat_id = 5 \n");
                sbSQL.Append(") pokemonstats on pokemonstats.pokemon_id = pokemon.id \n");
                sbSQL.Append("join type_names type1name on type1name.type_id = pokemontypes.type_1 join type_names type2name on pokemontypes.type_2 = type2name.type_id \n");
                sbSQL.Append("join (select type_id, game_index from type_game_indices where generation_id = 6) gametypes1 on gametypes1.type_id = pokemontypes.type_1 \n");
                sbSQL.Append("join (select type_id, game_index from type_game_indices where generation_id = 6) gametypes2 on gametypes2.type_id = pokemontypes.type_2 \n");
                sbSQL.Append("where type1name.local_language_id = 9 \n");
                sbSQL.Append("and type2name.local_language_id = 9 \n");
                sbSQL.Append("and pokemon_species_names.local_language_id = 9 \n");
                sbSQL.Append("order by pokemon.species_id asc, form_order asc");
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(sbSQL.ToString());
                    PokemonDataTable = new DataTable();
                    PokemonDataTable.Load(cmd.ExecuteReader());
                }
                return PokemonDataTable;
            }
        }

        public static DataTable GetItemDataTable
        {
            get
            {
                if (con == null) return null;
                if (con.State != ConnectionState.Open) return null;
                if (ItemDataTable != null) return ItemDataTable;
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select id, identifier, name from items join item_names on item_names.item_id = items.id where item_names.local_language_id = 9";
                    ItemDataTable = new DataTable();
                    ItemDataTable.Load(cmd.ExecuteReader());
                }
                return ItemDataTable;
            }
        }

        public static DataTable GetNatureDataTable
        {
            get
            {
                if (con == null) return null;
                if (con.State != ConnectionState.Open) return null;
                if (NatureDataTable != null) return NatureDataTable;
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(@"select game_index, name, decreased_stat_id, increased_stat_id from natures join nature_names on natures.id = nature_Names.nature_id where local_language_id = 9 order by game_index asc");
                    NatureDataTable = new DataTable();
                    NatureDataTable.Load(cmd.ExecuteReader());
                }
                return NatureDataTable;
            }
        }

        internal static ushort[] CalcStats(
            ushort species, byte formid, byte nature, int level,
            uint HP_IV, uint ATK_IV, uint DEF_IV, uint SPE_IV, uint SPA_IV, uint SPD_IV,
            byte HP_EV, byte ATK_EV, byte DEF_EV, byte SPE_EV, byte SPA_EV, byte SPD_EV
            )
        {
            ushort[] stats = new ushort[6];
            var results = GetPokemonDataTable.Select(string.Format("species_id = {0} and form_id = {1}", species, formid));
            DataRow PokemonDataRow;
            if (results.Length > 0)
            {
                PokemonDataRow = (DataRow)results[0];
            }
            else
            {
                return stats;
            }

            int HP_B = 0, ATK_B = 0, DEF_B = 0, SPA_B = 0, SPD_B = 0, SPE_B = 0;

            int.TryParse(PokemonDataRow["hp"].ToString(), out HP_B);
            int.TryParse(PokemonDataRow["attack"].ToString(), out ATK_B);
            int.TryParse(PokemonDataRow["defense"].ToString(), out DEF_B);
            int.TryParse(PokemonDataRow["sp_attack"].ToString(), out SPA_B);
            int.TryParse(PokemonDataRow["sp_defense"].ToString(), out SPD_B);
            int.TryParse(PokemonDataRow["speed"].ToString(), out SPE_B);

            stats[0] = (HP_B == 1) ? (ushort)1 : (ushort)((((HP_IV + (2 * HP_B) + (HP_EV / 4) + 100) * level) / 100) + 10);
            stats[1] = (ushort)((((ATK_IV + (2 * ATK_B) + (ATK_EV / 4)) * level) / 100) + 5);
            stats[2] = (ushort)((((DEF_IV + (2 * DEF_B) + (DEF_EV / 4)) * level) / 100) + 5);
            stats[3] = (ushort)((((SPE_IV + (2 * SPE_B) + (SPE_EV / 4)) * level) / 100) + 5);
            stats[4] = (ushort)((((SPA_IV + (2 * SPA_B) + (SPA_EV / 4)) * level) / 100) + 5);
            stats[5] = (ushort)((((SPD_IV + (2 * SPD_B) + (SPD_EV / 4)) * level) / 100) + 5);

            int incr = nature / 5 + 1;
            int decr = nature % 5 + 1;
            if (incr == decr) return stats; // if neutral return stats without mod
            stats[incr] *= 11; stats[incr] /= 10;
            stats[decr] *= 9; stats[decr] /= 10;

            return stats;
        }
    }
}