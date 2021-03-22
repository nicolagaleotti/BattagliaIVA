using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public class Troll : Razza
    {
        public static Troll Istanza { get; private set; } = new Troll();
        public Troll()
        {
            Squadra = Squadra.Male;
            Attacco = 12;
            Difesa = 6;
        }
    }
}
