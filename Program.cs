using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehérje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Megoldás m = new Megoldás("../../aminosavak.json");
            BsaMegoldás mb = new BsaMegoldás("../../bsa.json");
            //Console.WriteLine(m.SavakSzámaPróba);
            //Console.WriteLine(m.AminosavKiírPróba);
            Console.WriteLine("1. Feladat: ");
            Console.ReadKey();
        }
    }
}
