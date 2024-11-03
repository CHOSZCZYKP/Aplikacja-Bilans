using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Aplikacja
{
    public class Konto
    {
        public string nazwa;
        public string PolaczenieBilansowe;
        public List<Operacja> DT;
        public List<Operacja> CT;
        public double saldo;

        public Konto(string nazwa, string polaczenieBilansowe)
        {
            this.nazwa = nazwa;
            DT = new List<Operacja>();
            CT = new List<Operacja>();
            this.saldo = 0.0;
            this.PolaczenieBilansowe = polaczenieBilansowe;  
        }

        public override string ToString()
        {
            return nazwa;
        }

        public void DodajDoKontaDT(Operacja operacja)
        {
            DT.Add(operacja);
        }

        public void DodajDoKontaCT(Operacja operacja)
        {
            CT.Add(operacja);
        }

        public double SumaSaldKoncowychDT(DateTime data)
        {
            double saldoDT = 0.0;
            foreach (var item in DT)
            {
                if (data >= item.Czas_operacji && data.Year == item.Czas_operacji.Year)
                {
                    saldoDT += item.Kwota;
                }
            }
            return saldoDT;
        }
        public double SumaSaldKoncowychCT(DateTime data)
        {
            double saldoCT = 0.0;
            foreach (var item in CT)
            {
                if (data >= item.Czas_operacji && data.Year == item.Czas_operacji.Year)
                {
                    saldoCT += item.Kwota;
                }
            }
            return saldoCT;
        }

        /*public double SumaSaldKoncowych(DateTime data)
        {
            saldo = 0.0;
            saldo = Math.Abs(SumaSaldKoncowychDT(data) - SumaSaldKoncowychCT(data));
            return saldo;
        }*/

        public double SumaSaldDT(DateTime data)
        {
            return SumaSaldKoncowychDT(data) - SumaSaldKoncowychCT(data);
        }

        public double SumaSaldCT(DateTime data)
        {
            return SumaSaldKoncowychCT(data) - SumaSaldKoncowychDT(data);
        }

    }
}
