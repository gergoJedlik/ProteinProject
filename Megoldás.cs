using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Fehérje
{
    internal class Megoldás
    {
        private List<Aminosav> aminoAcids;
        private List<char> bsaString;

        private List<int> MassOfSubstances
        {
            get
            {
                const int Coal = 12, Hydrogen = 1, Oxygen = 16, Nitrogen = 14, Sulfur = 32;

                List<int> MassOfSubs = new List<int> { Coal, Hydrogen, Oxygen, Nitrogen, Sulfur };
                return MassOfSubs;
            }
        }

        private Dictionary<string, int> RelativeMassOfMolecules
        {
            get
            {
                Dictionary<string, int> RelativeMass = new Dictionary<string, int>();

                foreach (var e in aminoAcids)
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

        private Dictionary<string, int> RelativeMassOfMoleculesInOrder
        {
            get
            {
                var Order = RelativeMassOfMolecules.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
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



        private List<int> ProteinChainComposition
        {
            get
            {
                int totalC = 0, totalH = 0, totalN = 0, totalO = 0, totalS = 0;

                foreach (char item in bsaString)
                {
                    var aminoAcid = aminoAcids.FirstOrDefault(a => a.Betujel == item);
                    if (aminoAcid != null)
                    {
                        totalC += aminoAcid.C;
                        totalH += aminoAcid.H;
                        totalN += aminoAcid.N;
                        totalO += aminoAcid.O;
                        totalS += aminoAcid.S;
                    }
                }
                List<int> list = new List<int> { totalC, totalH, totalO, totalN, totalS };
                return list;
            }
        }

        public string ProteinChainCompositionDisplay
        {
            get
            {
                List<int> list = ProteinChainComposition;
                return $"C {list[0]} H {list[1]} O {list[2]} N {list[3]} S {list[4]}";
            }
        }

        private Dictionary<string, int> ProteinSplitting
        {
            get
            {
                Dictionary<string, int> data = new Dictionary<string, int>
                {
                    ["currentLength"] = 0,
                    ["startPosition"] = 0,
                    ["endPosition"] = 0,
                    ["maxLength"] = 0
                };

                for (int i = 0; i < bsaString.Count; i++)
                {
                    data["currentLength"]++;

                    if (bsaString[i] == 'Y' || bsaString[i] == 'F' || bsaString[i] == 'W')
                    {
                        if (data["currentLength"] > data["maxLength"])
                        {
                            data["maxLength"] = data["currentLength"];
                            data["endPosition"] = i;
                        }
                        data["currentLength"] = 0;
                    }
                }

                data["startPosition"] = data["endPosition"] - data["maxLength"] + 1;
                return data;
            }
        }

        public string ProteinSplittingDisplay
        {
            get
            {
                Dictionary<string, int> data = ProteinSplitting;
                return $"Hossza: {data["maxLength"]}; Kezdet helye: {data["startPosition"]}; Vége helye: {data["endPosition"]}";
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
            aminoAcids = r.readJSON();

            bsareader br = new bsareader(bsaforrás);
            bsaString = br.readJSON();
        }

        
    }
}
