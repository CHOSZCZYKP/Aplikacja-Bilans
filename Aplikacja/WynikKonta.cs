using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    internal class WynikKonta
    {
        
        public string Id { get; set; }
        public string Nazwa {  get; set; }
        public double WynikRokBiezacy { get; set; }
        public double WynikRoKPoprzedni { get; set; }

        public WynikKonta(string id, string nazwa, double wynikB, double wynikP) 
        {
            this.Id = id;
            this.Nazwa = nazwa;
            this.WynikRokBiezacy = wynikB;
            this.WynikRoKPoprzedni = wynikP;
        }

    }
}
