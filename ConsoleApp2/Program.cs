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
        private int Eletkor;

        public Szemely(string nev, int eletkor)
        {
            Nev = nev;
            Eletkor = eletkor;
        }

        public int Kor
        {
            get { return Eletkor; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Az életkor nem lehet negatív.");
                Eletkor = value;
            }
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
