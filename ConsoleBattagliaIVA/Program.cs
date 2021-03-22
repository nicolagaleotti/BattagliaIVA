using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBattagliaIVA;

namespace ConsoleBattagliaIVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaggio p1 = new Personaggio("Mati", Uomini.Istanza);

            Personaggio p2 = new Personaggio("Mati", Elfi.Istanza);

            Console.WriteLine(p1.Attacca(p2));
            Console.ReadLine();
        }
    }
}
