﻿using System;
using System.Drawing;

namespace PKMDS_CS
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

        public static Image GetTypeImage(Types type)
        {
            return GetImageFromResource(string.Format("type_{0}", (int)type));
        }

        public static Image GetMarkingImage(Markings mark, bool marked)
        {
            string identifier = string.Format("m_{0}{1}", (int)mark, Convert.ToInt16(marked));
            return GetImageFromResource(identifier);
        }

        public static Image GetGenderIcon(Genders gender)
        {
            switch (gender)
            {
                case Genders.Male:
                    return GetImageFromResource("male");

                case Genders.Female:
                    return GetImageFromResource("female");

                default:
                    return null;
            }
        }

        public static Image GetItemImage(ushort item)
        {
            if (item == 0) return null;
            try
            {
                return GetImageFromResource(DBTools.GetItemDataTable.Select(string.Format("game_index = {0}", item))[0].ItemArray[(int)DBTools.ItemDataTableColumns.identifier].ToString().Replace("-", "_"));
            }
            catch (Exception) { return null; }
        }

        public static Image GetPokemonImage(ushort species, byte formid = 0, Genders gender = Genders.Male)
        {
            if (species == (ushort)Species.Arceus)
            {
                return GetImageFromResource(string.Format("_{0}", species));
            }
            string formidstr = string.Empty;
            if (formid != 0)
            {
                var results = DBTools.GetPokemonDataTable.Select(string.Format("species_id = {0} and form_id = {1}", species, formid));
                if (results.Length > 0)
                {
                    formidstr = string.Format("_{0}",
                        results[0].ItemArray[(int)DBTools.PokemonDataTableColumns.form_identifier]
                        );
                }
                else
                {
                    int row = 0;
                    if (species == (ushort)Species.Unown & formid == 27) { formid--; row = 1; }
                    results = DBTools.GetPokemonDataTable.Select(string.Format("species_id = {0} and form_id = {1}", species, formid));
                    if (results.Length > 0)
                    {
                        formidstr = string.Format("_{0}",
                            results[row].ItemArray[(int)DBTools.PokemonDataTableColumns.form_identifier]
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
                    formidstr = "_f";
            return GetImageFromResource(string.Format("_{0}{1}", species, formidstr.Replace("-", "_")));
        }
    }
}