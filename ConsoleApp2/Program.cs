using System;


namespace ConsoleApp2
{

     class Szemely 
    {

        private string nev;
        private int kor;

        public Szemely(string Nev)
        {
          nev = Nev;
        }

        public int Kor
        {
            get { return kor; }
            set
            {
                if (value > 0)
                {
                    { kor = value; }
                }
                else
                {
                    Console.WriteLine("Hibás kor!");
                }

            }
        }
        public string Kiir()
        {
            return nev;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Szemely tanulo = new Szemely("Kiss Péter");
            Console.WriteLine(tanulo.Kiir());
            tanulo.Kor = -1;
            Console.WriteLine(tanulo.Kor);
            //Console.WriteLine( tanulo.nev);
            //Console.WriteLine( tanulo.kor);


        }
    }
}
