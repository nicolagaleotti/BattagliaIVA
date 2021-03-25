using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public abstract class Razza
    {
        public Squadra Squadra { get; protected set; }
        public uint Attacco { get; protected set; }
        public uint Difesa { get; protected set; }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
