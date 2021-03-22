using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public class Orchi : Razza
    {
        public static Orchi Istanza { get; private set; } = new Orchi();
        public Orchi()
        {
            Squadra = Squadra.Male;
            Attacco = 9;
            Difesa = 12;
        }
    }
}
