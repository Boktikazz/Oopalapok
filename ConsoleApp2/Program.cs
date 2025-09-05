using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Szemely 
    { 
     public string nev = "Kiss Péter";
     public int kor = 35;
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely();
            Console.WriteLine("Név: " + tanulo.nev);
            Console.WriteLine("Kor: " + tanulo.kor);
            Console.ReadKey();
        }
    }
}
