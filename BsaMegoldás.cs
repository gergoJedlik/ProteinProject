using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehérje
{
    internal class BsaMegoldás
    {
        private List<string> bsa;

        //public string BsaKiír
        //{
        //    get
        //    {
        //        string vissza = "";
        //        foreach (string s in bsa) { 
        //        vissza += s;
        //        }
        //        return vissza;
        //    }
        //} 
        public BsaMegoldás(string forrás)
        {
            bsareader r = new bsareader(forrás);
            bsa = r.readJSON();
        }
    }
}
