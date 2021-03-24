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
            try
            {
                Personaggio p1 = new Personaggio("Nicola", Uomini.Istanza);
                Personaggio p2 = new Personaggio("Matilde", Stregoni.Istanza);

                Console.WriteLine(p1);
                Console.WriteLine(p2);

                Console.WriteLine($"{p1.Nome} attacca {p2.Nome}");
                Console.WriteLine($"{p1.Attacca(p2)}\n");

                Console.WriteLine(p1);
                Console.WriteLine(p2);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
