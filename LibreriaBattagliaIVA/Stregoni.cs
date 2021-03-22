using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public class Stregoni : Razza
    {
        public static Stregoni Istanza { get; private set; } = new Stregoni();
        public Stregoni()
        {
            Squadra = Squadra.Male;
            Attacco = 11;
            Difesa = 9;
        }
    }
}
