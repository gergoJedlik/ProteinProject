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

            Writer writer = new Writer();

            Write(writer, 3, m.RelativeMassWriter);
            Write(writer, 4, $"{m.ProteinChainCompositionDisplay}");
            Write(writer, 5, $"{m.ProteinSplittingDisplay}");
            Write(writer, 6, $"A Factor XI általi hasítás utáni első részletben {m.factorXICiszteinCount} Cisztein található.");

            writer.writeToFile();

            Console.ReadKey();
        }

        static void Write(Writer w, int taskNum, string ans)
        {
            Console.WriteLine($"{taskNum}. Feladat: {ans}");
            w.addToData(taskNum, ans);
        }
    }
}
