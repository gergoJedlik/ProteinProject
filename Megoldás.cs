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

        //public int SavakSzámaPróba
        //{
        //    get
        //    {
        //        return aminosavak.Count;
        //    }
        //}
        //public Aminosav ElsőAminosavPróba
        //{
        //    get
        //    {
        //        return aminosavak.First();
        //    }
        //}
        //public string AminosavKiírPróba
        //{
        //    get
        //    {
        //        string vissza = "";
        //        vissza += $"\n\tVálasztott aminosav: {ElsőAminosavPróba.Nev}";
        //        vissza += $"\n\tVálasztott aminosav betűjele: {ElsőAminosavPróba.Betujel}";
        //        vissza += $"\n\tVálasztott aminosav rövidítése: {ElsőAminosavPróba.Rovidites}";
        //        vissza += $"\n\tC száma: {ElsőAminosavPróba.C}";
        //        vissza += $"\n\tH száma: {ElsőAminosavPróba.H}";
        //        vissza += $"\n\tO száma: {ElsőAminosavPróba.O}";
        //        vissza += $"\n\tN száma: {ElsőAminosavPróba.N}";
        //        vissza += $"\n\tS száma: {ElsőAminosavPróba.S}";
        //        return vissza;
        //    }
        //}


        //public string BsaKiír
        //{
        //    get
        //    {
        //        string vissza = "";
        //        foreach (string s in bsaString)
        //        {
        //            vissza += s;
        //        }
        //        return vissza;
        //    }
        //}
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


        public Megoldás(string forrás, string bsaforrás)
        {
            reader r = new reader(forrás);
            aminosavak = r.readJSON();

            bsareader br = new bsareader(bsaforrás);
            bsaString = br.readJSON();
        }
    }
}
