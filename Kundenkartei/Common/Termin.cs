namespace Kundenkartei
{
    public class Termin
    {
        #region Properties    

        public int TerminNr { get; set; }
        public string Datum { get; set; }
        public string Dienstleistung { get; set; }
        public string Mitarbeiter { get; set; }
        public int KundenNr { get; set; }

        #endregion

        #region Constructors        

        public Termin(string datum, string dienstleistung, string mitarbeiter, int kundenNr)             
        {
            Datum = datum;
            Dienstleistung = dienstleistung;
            Mitarbeiter = mitarbeiter;
            KundenNr = kundenNr;
        }

        public Termin(int terminNr, string datum, string dienstleistung, string mitarbeiter, int kundenNr)
            :this(datum, dienstleistung, mitarbeiter, kundenNr)
        {
            TerminNr = terminNr;
        }


        #endregion

        #region Methods
        public void WriteTerminToDB()
        {
            SqliteDataAccess.CreateTermin(this);
        }

        #endregion 
    }
}
