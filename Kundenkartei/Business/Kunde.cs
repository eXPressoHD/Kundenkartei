using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kundenkartei
{
    public class Kunde
    {
        #region Properties
        public int KundenNr { get; set; }
        public string Name { get; set; }
        public string Telefon { get; set; }
        public string Strasse { get; set; }
        public string Plz { get; set; }
        public string Stadt { get; set; }
        public string Email { get; set; }
        public string Geburtstag { get; set; }
        public string Notizen { get; set; } 
        #endregion

        #region Constructors

        public Kunde(int kundenNr, string name, string telefon, string geburtstag, string strasse, string plz, string stadt, string email, string notizen)
        {
            KundenNr = kundenNr;
            Name = name;
            Telefon = telefon;
            Strasse = strasse;
            Plz = plz;
            Stadt = stadt;
            Email = email;
            Geburtstag = geburtstag;
            Notizen = notizen;
        }

        public Kunde(int kundenNr, string name, string telefon, string geburtstag, string strasse, string plz, string stadt, string email)
        {
            KundenNr = kundenNr;
            Name = name;
            Telefon = telefon;
            Strasse = strasse;
            Plz = plz;
            Stadt = stadt;
            Email = email;
            Geburtstag = geburtstag;
        }

        public Kunde(int kundenNr, string name, string telefon, string strasse, string plz, string stadt, string email)
        {
            KundenNr = kundenNr;
            Name = name;
            Telefon = telefon;
            Strasse = strasse;
            Plz = plz;
            Stadt = stadt;
            Email = email;
        }

        public Kunde(int kundenNr, string name, string telefon)
        {
            KundenNr = kundenNr;
            Name = name;
            Telefon = telefon;
        }

        public Kunde(string name, string telefon)
        {
            Name = name;
            Telefon = telefon;
        }

        public Kunde()
        {
        }

        #endregion

        #region Methods

        public void WriteKundeToDB()
        {
            SqliteDataAccess.CreateKunde(this);
        }

        public string Format()
        {
            return String.Format("{0} {1} {2}", KundenNr, Name, Telefon);
        }

        #endregion
    }
}
