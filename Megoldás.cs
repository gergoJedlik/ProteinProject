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
        private List<string> bsaString;

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


        public string BsaKiír
        {
            get
            {
                string vissza = "";
                foreach (string s in bsaString)
                {
                    vissza += s;
                }
                return vissza;
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
