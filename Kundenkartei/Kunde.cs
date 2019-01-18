using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kundenkartei
{
    public class Kunde
    {
        public int KundenNr { get; set; }
        public string Name { get; set; }
        public string Telefon { get; set; }

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

        public void WriteKundeToDB()
        {
            SqliteDataAccess.CreateKunde(this);
        }

        public string Format()
        {
            return String.Format("{0} {1} {2}", KundenNr, Name, Telefon);
        }
    }
}
