using System;
using System.Collections.Generic;
using System.Text;

namespace BadeTidsSystemet
{
    public class Kreds
    {
        public string Id { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int AntelDeltagere { get; set; }

        public Kreds (string Id, string Navn, string Adresse, int AntelDeltagere)
        {
            this.Id = Id;
            this.Navn = Navn;
            this.Adresse = Adresse;
            this.AntelDeltagere= AntelDeltagere;
        }
        public override string ToString()
        {
            return $"ID:{Id}, Navn:{Navn}, Adresse:{Adresse}, Deltagere:{AntelDeltagere}";
        }
    }
}
