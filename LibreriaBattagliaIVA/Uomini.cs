using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public class Uomini : Razza
    {
        public static Uomini Istanza { get; private set; } = new Uomini();
        private Uomini()
        {
            Squadra = Squadra.Bene;
            Attacco = 10;
            Difesa = 10;
        }
    }
}
