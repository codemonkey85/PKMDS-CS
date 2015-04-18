﻿using PKMDS_CS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMDS_Save_Editor
{
    public static class Images
    {
        public static Image GetImageFromResource(string identifier)
        {
            try
            {
                return (Image)Properties.Resources.ResourceManager.GetObject(identifier);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("There was an issue in GetImageFromResource: {0}", ex.Message);
                return null;
            }
        }
        public static Image GetItemImage(ushort item)
        {
            return GetImageFromResource(DBTools.GetItemDataTable.Select(string.Format("id = {0}", item))[0].ItemArray[(int)DBTools.ItemDataTableColumns.identifier].ToString());
        }
        public static Image GetPokemonImage(ushort species, byte formid = 0, Genders gender = Genders.Male)
        {
            string formidstr = string.Empty;
            if (formid != 0)
            {
                var results = DBTools.GetPokemonDataTable.Select(string.Format("species_id = {0} and game_index = {1}", species, formid));
                if (results.Length > 0)
                {
                    formidstr = string.Format("-{0}",
                        results[0].ItemArray[(int)DBTools.ItemDataTableColumns.identifier]
                        );
                }
                else
                {
                    int row = 0;
                    if (species == (ushort)Species.Unown & formid == 27) { formid--; row = 1; }
                    results = DBTools.GetPokemonDataTable.Select(string.Format("species_id = {0} and form_id = {1}", species, formid));
                    if (results.Length > 0)
                    {
                        formidstr = string.Format("-{0}",
                            results[row].ItemArray[(int)DBTools.ItemDataTableColumns.identifier]
                            );
                    }
                }
            }
            if (gender == Genders.Female)
                if (
                    species == (ushort)Species.Unfezant ||
                    species == (ushort)Species.Frillish ||
                    species == (ushort)Species.Jellicent ||
                    species == (ushort)Species.Pyroar ||
                    species == (ushort)Species.Meowstic
                    )
                    formidstr = "-f";
            return GetImageFromResource(string.Format("_{0}{1}", species, formidstr));
        }
    }
}