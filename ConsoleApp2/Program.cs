using System;
using System.Collections.Generic;

namespace ConsoleApp2

{
    public class Bankszamla
    {
        private int egyenleg;

        public void Betesz()
        {

        }

        public void Kivesz()
        {

        }
    }

    public class Hallgato : Szemely
    {
        private string neptunkod;

        public string NeptunKod
        {
            get { return neptunkod; }
            set
            {
                if (value.Length <= 6)
                {
                    neptunkod = value;
                }

            }
        }

    }
    public class Szemely
    {
        protected string nev;
        private int kor;

        public int Kor
        {
            get { return kor; }
            set
            {
                if (value > 0)
                {
                    kor = value;
                }

            }
        }

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }


        public override string ToString()
        {
            return $"A tanulo neve {nev} életkora {kor}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely();
            tanulo.Nev = "Kiss péter";
            tanulo.Kor = 34;

            Console.WriteLine(tanulo);
            List<Hallgato> nevsor = new List<Hallgato>();

            for (int i = 0; i < 3; i++)
            {
                Hallgato h1 = new Hallgato();
                Console.WriteLine($"Kérem {i+1}. nevet");
                h1.Nev = Console.ReadLine();
                Console.WriteLine($"Kérem {i + 1}. kort");
                h1.Kor = int.Parse(Console.ReadLine());
                nevsor.Add(h1);
            }
            foreach (var item in nevsor)
            {
                Console.WriteLine(item.Nev);
            }

            //Console.WriteLine(tanulo);
            //Console.WriteLine(tanulo.kor);
        }
    }
}