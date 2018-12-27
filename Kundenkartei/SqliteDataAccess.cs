using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kundenkartei
{
    public class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static DataTable GetKundenData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT * FROM Kunden";//order by termin sysdate...
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }
                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        public static DataTable GetKundenDataToday() //Termine am selben Tag
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT * FROM Kunden WHERE Termin Like @today ORDER BY Termin asc";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@today",  "%" + DateTime.Today.ToString("dd.MM.yyyy") + "%");
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }
                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        public static DataTable GetKundenDataOnDate(DateTime date) //Termine am Tag des Datepickers
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT * FROM Kunden WHERE Termin Like @date ORDER BY Termin asc";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@date", "%"+ date.ToString("dd.MM.yyyy") + "%");
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }
                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        public static long CreateKunde(Kunde kunde)
        {
            long lastRow = 0;
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Kunden (Name, Telefon) VALUES (@name, @telefon)", con);
                insertSQL.Parameters.AddWithValue("@name", kunde.Name);
                insertSQL.Parameters.AddWithValue("@telefon", kunde.Telefon);
                lastRow = con.LastInsertRowId;
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return lastRow;
        }

        public static DataTable LookUpKunde(string name)
        {
            DataTable kunden = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT * FROM Kunden WHERE Name = @name";
                        cmd.Parameters.AddWithValue("@name", name);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            kunden.Load(reader);
                            reader.Close();
                        }
                    }
                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return kunden;
        }

        public static int GetLatestKundenNr()
        {
            int rowId;
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT Max(KundenNr) FROM Kunden";
                        rowId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rowId;
        }

        public static void UpdateKunde(Kunde kunde)
        {
            long lastRow = 0;
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("Update Kunden SET Name = @name , Telefon = @telefon , Termin = @termin , Dienstleistung = @dienstleistung WHERE KundenNr = @kundenNr", con);
                insertSQL.Parameters.AddWithValue("@kundenNr", kunde.KundenNr);
                insertSQL.Parameters.AddWithValue("@name", kunde.Name);
                insertSQL.Parameters.AddWithValue("@telefon", kunde.Telefon);
                insertSQL.Parameters.AddWithValue("@termin", kunde.LetzterTermin);
                insertSQL.Parameters.AddWithValue("@dienstleistung", kunde.Dienstleistung);
                lastRow = con.LastInsertRowId;
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static void DeleteKunde(Kunde kunde)
        {
            long lastRow = 0;
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("DELETE FROM Kunden WHERE KundenNr = @kundenNr", con);
                insertSQL.Parameters.AddWithValue("@kundenNr", kunde.KundenNr);
                lastRow = con.LastInsertRowId;
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static DataTable GetKundeById(int kundenNr)
        {
            DataTable kunde = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("SELECT * FROM Kunden WHERE KundenNr = @kundenNr", con);
                insertSQL.Parameters.AddWithValue("@kundenNr", kundenNr);
                using (SQLiteDataReader reader = insertSQL.ExecuteReader())
                {
                    kunde.Load(reader);
                    reader.Close();
                }

                con.Close();
            }
            return kunde;
        }
    }
}
