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
            try
            {
                var connString = string.Format(@"Data Source={0}; Pooling=false; FailIfMissing=false;", DBFile);
                using (var factory = new System.Data.SQLite.SQLiteFactory())
                    con = factory.CreateConnection();
                con.ConnectionString = connString;
                con.Open();
                test();
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
        public static void test()
        {
            using (System.Data.Common.DbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"select * from pokemon";
                DataTable dtout = new DataTable();
                dtout.Load(cmd.ExecuteReader());
                if (dtout != null)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0}", dtout.Rows.Count));
                }
            }
        }
    }
}
