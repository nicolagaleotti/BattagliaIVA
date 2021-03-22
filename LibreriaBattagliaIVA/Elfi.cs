using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public class Elfi : Razza
    {
        public static Elfi Istanza { get; private set; } = new Elfi();
        private Elfi()
        {
            Squadra = Squadra.Bene;
            Attacco = 8;
            Difesa = 11;
        }
    }
}
