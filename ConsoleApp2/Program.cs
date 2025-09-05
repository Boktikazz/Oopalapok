using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Szemely 
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }

        public Szemely(string nev, int eletkor)
        {
            Nev = nev;
            Eletkor = eletkor;
        }

        public void Kiir()
        {
            Console.WriteLine($"Név: {Nev}, Életkor: {Eletkor}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely("Kiss Péter", 30);
            tanulo.Kiir();
            Console.ReadLine();

        }
    }
}
