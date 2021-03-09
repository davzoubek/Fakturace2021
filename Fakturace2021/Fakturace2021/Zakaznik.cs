using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturace2021
{
    public class Zakaznik
    {       

        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Typ { get; set; }
        public string Adresa { get; set; }
        public int Ico { get; set; }
        public string Mail { get; set; }
        public int Telefon { get; set; }

        public Zakaznik(int id, string jmeno, string prijmeni, string typ, string adresa, int ico, string mail, int telefon)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Typ = typ;
            Adresa = adresa;
            Ico = ico;
            Mail = mail;
            Telefon = telefon;
        }
    }
}
