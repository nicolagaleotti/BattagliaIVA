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
        public uint Vita { get; private set; } = 100;
        public uint Esperienza { get; private set; } = 1;

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
            if (personaggio == this)
            {
                throw new Exception("Non puoi attaccare lo stesso personaggio!");
            }
            if(Razza.Squadra == personaggio.Razza.Squadra)
            {
                throw new Exception("Non puoi attaccare un personaggio della stessa squadra!");
            }
            uint attacco = GetAttacco();
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

        public override string ToString()
        {
            return ($"{Nome} [{Razza.GetType().Name}]\nVita : {Vita}\nEsperienza : {Esperienza}\nAttacco : {Razza.Attacco}\nDifesa : {Razza.Difesa}\n");
        }
    }
}
