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
        public override string ToString()
        {
            return nev + " " + kor + " éves";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Szemely tanulo = new Szemely("Kiss Péter");
            tanulo.Kor = 21;
            Console.WriteLine(tanulo.Kor);
            //Console.WriteLine( tanulo.nev);
            //Console.WriteLine( tanulo.kor);


        }
    }
}
