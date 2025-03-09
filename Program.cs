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
            Megoldás m = new Megoldás("../../aminosavak.json", "../../bsa.json");
            Writer writer = new Writer();

            //Console.WriteLine(m.SavakSzámaPróba);
            //Console.WriteLine(m.AminosavKiírPróba);
            //Console.WriteLine($"4. Feladat: {m.FehérjeLáncÖsszegképletKiírása}");
            //Console.WriteLine($"6. Feladat: A Factor XI általi hasítás utáni első részletben {m.factorXICiszteinCount} Cisztein található.");
            //Console.WriteLine(m.RelativeMassWriter);
            Write(writer, 3, m.RelativeMassWriter);
            Write(writer, 4, $"{m.FehérjeLáncÖsszegképletKiírása}");

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
