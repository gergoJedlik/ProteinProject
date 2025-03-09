using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehérje
{
    internal class Megoldás
    {
        private List<Aminosav> aminosavak;
        private List<char> bsaString;

        private List<int> MassOfSubstances
        {
            get
            {
                int Coal = 12;
                int Hydrogen = 1;
                int Oxygen = 16;
                int Nitrogen = 14;
                int Sulfur = 32;

                List<int> MassOfSubs = new List<int> { Coal, Hydrogen, Oxygen, Nitrogen, Sulfur };
                return MassOfSubs;
            }
        }

        private Dictionary<string, int> RelativeMassOfMolecules
        {
            get
            {
                Dictionary<string, int> RelativeMass = new Dictionary<string, int>();

                foreach (var e in aminosavak)
                {
                    int MassSum = 0;
                    MassSum += e.C * MassOfSubstances[0];
                    MassSum += e.H * MassOfSubstances[1];
                    MassSum += e.O * MassOfSubstances[2];
                    MassSum += e.N * MassOfSubstances[3];
                    MassSum += e.S * MassOfSubstances[4];
                    RelativeMass.Add(e.Rovidites, MassSum);
                }
                return RelativeMass;
            }
        }

        private IOrderedEnumerable<KeyValuePair<string, int>> RelativeMassOfMoleculesInOrder
        {
            get
            {
                var Order = RelativeMassOfMolecules.OrderBy(x => x.Value);
                return Order;
            }
        }
        public string RelativeMassWriter
        {
            get
            {
                string Output = "";
                foreach (var e in RelativeMassOfMoleculesInOrder)
                {
                    Output += $"{e.Key} {e.Value}; ";
                }
                return Output;
            }
        }

        

        private List<int> FehérjeLáncÖsszegképlete
        {
            get
            {
                int összesC = 0, összesH = 0, összesN = 0, összesO = 0, összesS = 0;

                foreach (char item in bsaString)
                {
                    var aminosav = aminosavak.FirstOrDefault(a => a.Betujel == item);
                    if (aminosav != null)
                    {
                        összesC += aminosav.S;
                        összesH += aminosav.H;
                        összesN += aminosav.N;
                        összesO += aminosav.O;
                        összesS += aminosav.S;
                    }
                }
                List<int> lista = new List<int> { összesC, összesH, összesO, összesN, összesS };
                return lista;
            }
        }

        public string FehérjeLáncÖsszegképletKiírása
        {
            get
            {
                List<int> lista = FehérjeLáncÖsszegképlete;
                return $"C {lista[0]} H {lista[1]} O {lista[2]} N {lista[3]} S {lista[4]}";
            }

        }

        private Dictionary<string, int> FehérjeHasítás
        {
            get
            {
                Dictionary<string, int> adatok = new Dictionary<string, int>
                {
                    ["hosszaAktuális"] = 0,
                    ["kezdetHelye"] = 0,
                    ["végeHelye"] = 0,
                    ["maxHossza"] = 0
                };

                for (int i = 0; i < bsaString.Count; i++)
                {
                    adatok["hosszaAktuális"]++;

                    if (bsaString[i] == 'Y' || bsaString[i] == 'F' || bsaString[i] == 'W')
                    {
                        if (adatok["hosszaAktuális"] > adatok["maxHossza"])
                        {
                            adatok["maxHossza"] = adatok["hosszaAktuális"];
                            adatok["végeHelye"] = i;
                        }
                        adatok["hosszaAktuális"] = 0;
                    }
                }

                adatok["kezdetHelye"] = adatok["végeHelye"] - adatok["maxHossza"] + 1;
                return adatok;
            }
        }

        public string FehérjeHasításKiír
        {
            get
            {
                Dictionary<string, int> adatok = FehérjeHasítás;
                return $"Hossza: {adatok["maxHossza"]}; Kezdet helye: {adatok["kezdetHelye"]}; Vége helye: {adatok["végeHelye"]}";
            }
        }



        public int factorXICiszteinCount
        {
            get
            {
                int CiszteinCount = 0;
                char prevLetter = bsaString[0];
                foreach (char letter in bsaString.Skip(1))
                {
                    if (prevLetter == 'R' && (letter == 'A' || letter == 'V')) break;
                    if (letter == 'C') CiszteinCount++;
                    prevLetter = letter;
                }

                return CiszteinCount;
            }
        }


        public Megoldás(string forrás, string bsaforrás)
        {
            reader r = new reader(forrás);
            aminosavak = r.readJSON();

            bsareader br = new bsareader(bsaforrás);
            bsaString = br.readJSON();
        }

        
    }
}
