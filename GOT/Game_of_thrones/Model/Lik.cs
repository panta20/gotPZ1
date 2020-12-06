using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_thrones.Model
{
    public class Lik
    {
        public string Ime { get; set; }
        public string Kuca { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
        public int BrojSezona { get; set; }
        public string PutanjaSlike { get; set; }

        public Lik()
        {

        }

        public Lik(string ime, string kuca, string opis, DateTime datum, int brojSezona, string putanjaSlike)
        {
            Ime = ime;
            Kuca = kuca;
            Datum = datum;
            BrojSezona = brojSezona;
            PutanjaSlike = putanjaSlike;
            Opis = opis;
        }
    }
}
