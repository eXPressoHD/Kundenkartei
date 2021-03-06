﻿using System;

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
        public Kunde()
        {
        }

        public Kunde(string name, string telefon)
        {
            Name = name;
            Telefon = telefon;
        }

        public Kunde(int kundenNr, string name, string telefon)
            :this(name, telefon)
        {
            KundenNr = kundenNr;
        }

        public Kunde(int kundenNr, string name, string telefon, string strasse, string plz, string stadt, string email)
            :this(kundenNr, name, telefon)
        {
            Strasse = strasse;
            Plz = plz;
            Stadt = stadt;
            Email = email;
        }

        public Kunde(int kundenNr, string name, string telefon, string geburtstag, string strasse, string plz, string stadt, string email)
            :this(kundenNr, name, telefon, strasse, plz, stadt, email)
        {
            Geburtstag = geburtstag;
        }

        public Kunde(int kundenNr, string name, string telefon, string geburtstag, string strasse, string plz, string stadt, string email, string notizen)
            :this(kundenNr, name, telefon, geburtstag, strasse, plz, stadt, email)
        {
            Notizen = notizen;
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
