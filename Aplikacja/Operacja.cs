using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Aplikacja
{
    public class Operacja
    {
        public DateTime Czas_operacji { get; set; }
        public double Kwota { get; set; }
        public string NrOperacji { get; set; }

        public Operacja(DateTime czas, double kw, string nr) 
        {
            this.Czas_operacji = czas;
            this.Kwota = kw;
            this.NrOperacji = nr;
        }
    }
}
