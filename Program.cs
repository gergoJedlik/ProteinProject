﻿using System;
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
            Megoldás m = new Megoldás("../../aminosavak.json", "../../bsa.json");
            //Console.WriteLine(m.SavakSzámaPróba);
            //Console.WriteLine(m.AminosavKiírPróba);
            Console.WriteLine($"4. Feladat: {m.FehérjeLáncÖsszegképletKiírása}");
            Console.WriteLine($"6. Feladat: A Factor XI általi hasítás utáni első részletben {m.factorXICiszteinCount} Cisztein található.");
            Console.ReadKey();
        }
    }
}
