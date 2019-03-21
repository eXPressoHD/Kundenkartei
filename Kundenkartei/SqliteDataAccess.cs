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
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static DataTable GetKundenBirthday(Kunde k)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT Geburtstag FROM Kunden WHERE KundenNr = @kundenNr";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@kundenNr", k.KundenNr);
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
                        cmd.CommandText = "SELECT * FROM Kunden k Inner join Termine t ON k.KundenNr = t.KundenNr WHERE t.Datum Like @today ORDER BY t.Datum asc";//order by termin sysdate...
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

        public static DataTable GetCustomerTypes()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT DISTINCT Typ FROM Preisliste";
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

        public static DataTable GetPriceList(string para)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT Titel, Preis FROM Preisliste WHERE Typ = @typ";
                        cmd.Parameters.AddWithValue("@typ", para);
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

        public static DataTable GetKundenHistorie(Kunde k) //Alle Einträge eines Kunden
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT * FROM Kunden k Inner join Termine t ON k.KundenNr = t.KundenNr WHERE k.KundenNr = @kundenNr ORDER BY t.Datum desc";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@kundenNr", k.KundenNr);
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

        public static DataTable GetTerminInfos(Termin t) //Alle Einträge eines Kunden
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT t.TerminNR FROM Kunden k Inner join Termine t ON k.KundenNr = t.KundenNr WHERE t.Datum = @datum";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@datum", t.Datum);
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

        public static DataTable GetKundenTerminAndDienstleistung(Kunde k, string date)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT t.Datum, t.Dienstleistung, t.Mitarbeiter FROM Kunden k Inner Join Termine t ON k.KundenNr = t.KundenNr WHERE k.KundenNr = @kundenNr AND t.Datum LIKE @date";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@kundenNr", k.KundenNr);
                        cmd.Parameters.AddWithValue("@date", date);
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

        public static DataTable GetKundenAdresse(Kunde k)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT Strasse, PLZ, Stadt FROM Kunden WHERE KundenNr = @kundenNr";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@kundenNr", k.KundenNr);
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

        public static DataTable GetKundenEmail(Kunde k)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT Email FROM Kunden WHERE KundenNr = @kundenNr";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@kundenNr", k.KundenNr);
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

        public static DataTable GetKundenTerminAndDienstleistungAll(Kunde k)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT t.Datum, t.Dienstleistung, t.Mitarbeiter FROM Kunden k Inner Join Termine t ON k.KundenNr = t.KundenNr WHERE k.KundenNr = @kundenNr ORDER BY t.Datum DESC";//order by termin sysdate...
                        cmd.Parameters.AddWithValue("@kundenNr", k.KundenNr);
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
                        cmd.CommandText = "SELECT * FROM Kunden k INNER JOIN Termine t ON k.KundenNr = t.KundenNr WHERE t.Datum Like @date  ORDER BY t.Datum asc";//order by termin sysdate...
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
                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Kunden (Name, Telefon, Strasse, PLZ, Stadt, Email, Geburtstag) VALUES (@name, @telefon, @strasse, @plz, @stadt, @email, @geb)", con);
                insertSQL.Parameters.AddWithValue("@name", kunde.Name);
                insertSQL.Parameters.AddWithValue("@telefon", kunde.Telefon);
                insertSQL.Parameters.AddWithValue("@strasse", kunde.Strasse);
                insertSQL.Parameters.AddWithValue("@plz", kunde.Plz);
                insertSQL.Parameters.AddWithValue("@stadt", kunde.Stadt);
                insertSQL.Parameters.AddWithValue("@email", kunde.Email);
                insertSQL.Parameters.AddWithValue("@geb", kunde.Geburtstag);
                lastRow = con.LastInsertRowId;
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    _logger.Error(ex);
                }
            }

            return lastRow;
        }

        public static void CreateTermin(Termin t)
        {
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Termine (Datum, Dienstleistung, KundenNr, Mitarbeiter) VALUES (@datum, @dienstleistung, @kundenNr, @mitarbeiter)", con);
                insertSQL.Parameters.AddWithValue("@datum", t.Datum);
                insertSQL.Parameters.AddWithValue("@dienstleistung", t.Dienstleistung);
                insertSQL.Parameters.AddWithValue("@kundenNr", t.KundenNr);
                insertSQL.Parameters.AddWithValue("@mitarbeiter", t.Mitarbeiter);
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    _logger.Error(ex);
                }
            }
        }

        public static void UpdateTermin(Termin t)
        {
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("Update Termine SET Datum = @datum, Dienstleistung = @dienstleistung, Mitarbeiter = @mitarbeiter WHERE TerminNr = @terminNr", con);
                insertSQL.Parameters.AddWithValue("@datum", t.Datum);
                insertSQL.Parameters.AddWithValue("@dienstleistung", t.Dienstleistung);
                insertSQL.Parameters.AddWithValue("@mitarbeiter", t.Mitarbeiter);
                insertSQL.Parameters.AddWithValue("@terminNr", t.TerminNr);
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    _logger.Error(ex);                    
                }
            }
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

        public static DataTable GetKundenNotes(int kNr)
        {
            DataTable notes = new DataTable();
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "SELECT Notizen FROM Kunden WHERE KundenNr = @kundenNr";
                        cmd.Parameters.AddWithValue("@kundenNr", kNr);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            notes.Load(reader);
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
            return notes;
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
                SQLiteCommand insertSQL = new SQLiteCommand("Update Kunden SET Name = @name , Telefon = @telefon, Strasse = @strasse, PLZ = @plz, Stadt = @stadt, Email = @email, Geburtstag = @geb, Notizen = @note WHERE KundenNr = @kundenNr", con);
                insertSQL.Parameters.AddWithValue("@kundenNr", kunde.KundenNr);
                insertSQL.Parameters.AddWithValue("@name", kunde.Name);
                insertSQL.Parameters.AddWithValue("@telefon", kunde.Telefon);
                insertSQL.Parameters.AddWithValue("@strasse", kunde.Strasse);
                insertSQL.Parameters.AddWithValue("@plz", kunde.Plz);
                insertSQL.Parameters.AddWithValue("@stadt", kunde.Stadt);
                insertSQL.Parameters.AddWithValue("@email", kunde.Email);
                insertSQL.Parameters.AddWithValue("@geb", kunde.Geburtstag);
                insertSQL.Parameters.AddWithValue("@note", kunde.Notizen);
                lastRow = con.LastInsertRowId;
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    _logger.Error(ex);                    
                }
            }
        }

        public static void DeleteKunde(string kundenNr)
        {
            long lastRow = 0;
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("DELETE FROM Kunden WHERE KundenNr = @kundenNr", con);
                insertSQL.Parameters.AddWithValue("@kundenNr", kundenNr);
                lastRow = con.LastInsertRowId;
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    _logger.Error(ex);
                }
            }
        }

        public static void DeleteTermin(Termin termin)
        {
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("DELETE FROM Termine WHERE TerminNr = @terminNr", con);
                insertSQL.Parameters.AddWithValue("@terminNr", termin.TerminNr);
                try
                {
                    insertSQL.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    _logger.Error(ex);
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
