using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBattagliaIVA
{
    public class Personaggio
    {
        public string Nome { get; private set; }
        public Razza Razza { get; private set; }
        public uint Vita { get; private set; }
        public uint Esperienza { get; private set; }

        public Personaggio(string nome, Razza razza)
        {
            Nome = nome;
            Razza = razza;
        }

        public uint GetAttacco()
        {
            return Razza.Attacco * Esperienza;
        }

        public uint GetDifesa()
        {
            return Razza.Difesa * Esperienza;
        }

        public bool Attacca(Personaggio personaggio)
        {
            uint attacco = this.GetAttacco();
            uint difesa = personaggio.GetDifesa();
            if (attacco - difesa > 0)
            {
                personaggio.Vita--;
                if (Esperienza < 10)
                    Esperienza++;
                return true;
            }
            else
            {
                if (Esperienza < 10)
                    Esperienza++;
                personaggio.Attacca(this);
                return false;
            }
        }
    }
}
