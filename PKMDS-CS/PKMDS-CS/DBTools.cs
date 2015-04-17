using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
namespace PKMDS_CS
{
    public static class DBTools
    {
        private static DbConnection con;
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

            }
        }
        public static int GetLevel(ushort Species, uint EXP)
        {
            int level = 0;
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(@"select experience.level from experience join pokemon_species on pokemon_species.growth_rate_id = experience.growth_rate_id where pokemon_species.id = {0} and experience.experience <= {1} order by experience.level desc limit 1", Species, EXP);
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
            uint exp = 0;
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(@"select experience.experience from experience join pokemon_species on pokemon_species.growth_rate_id = experience.growth_rate_id where pokemon_species.id = {0} and experience.level = {1} order by experience.level desc limit 1", Species, Level);
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
            string pokemonname = string.Empty;
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(@"select pokemon_name from pokemon join pokemon_forms on pokemon.id = pokemon_forms.pokemon_id join pokemon_form_generations on pokemon_form_generations.pokemon_form_id = pokemon_forms.id join pokemon_form_names on pokemon_form_names.pokemon_form_id = pokemon_forms.id 
where pokemon.species_id = {0} and pokemon_form_generations.game_index = {1} and local_language_id = {2}", Species, FormID, langid);
                DataTable dtout = new DataTable();
                dtout.Load(cmd.ExecuteReader());
                if (dtout != null)
                {
                    if (dtout.Rows.Count != 0)
                        pokemonname = dtout.Rows[0].ItemArray[0].ToString();
                }
            }
            return pokemonname;
        }
    }
}
