using System;


namespace ConsoleApp2
{

     class Szemely 
    {

        private string nev;
        private int kor;

        public Szemely(string Nev, int Kor)
        {
          nev = Nev;
          kor = Kor;
        }
        public string Kiir()
        {
            return $""nev + " " + kor;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Szemely tanulo = new Szemely("Kiss Péter", 35);
            Console.WriteLine(tanulo.Kiir());
            //Console.WriteLine( tanulo.nev);
            //Console.WriteLine( tanulo.kor);


        }
    }
}
