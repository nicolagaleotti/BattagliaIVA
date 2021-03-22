using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public class Maghi : Razza
    {
        public static Maghi Istanza { get; private set; } = new Maghi();
        public Maghi()
        {
            Squadra = Squadra.Bene;
            Attacco = 13;
            Difesa = 10;
        }
    }
}
