using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoLibrary;
using ErrosLibrary;

namespace Simulador
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new ContaCorrente();
            c1.Numero = 1;
            c1.Depositar(100);

            var c2 = new ContaCorrente();
            c2.Numero = 1;
            c2.Depositar(100);

            if (c1 == c2)
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");

            ContaCorrente c3 = new ContaCorrente();
            c3 = c1;
            if (c1 == c3)
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");

            if (c1.Equals(c2))
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");

            var c4 = new ContaCorrente();
            c4.Numero = 2;
            c4.Depositar(100);

            if (c1.Equals(c4))
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");

            if (c1.Equals("Oi"))
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");

            Console.WriteLine();
            Console.WriteLine(c4.ToString());

            Console.Read();

            //List<string> dev = null;
            ICollection<string> dev = null;
            dev = BuscaLibrary.GeradorDevedores.GeraListaT();

            foreach (var d in dev)
            {
                Console.WriteLine(d.ToString());
            }

            Console.ReadLine();
        }
    }
}
