using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fehérje
{
    internal class bsareader
    {
        private string json_data { get; }

        public bsareader(string file)
        {
            json_data = File.ReadAllText(file, encoding: UTF8Encoding.UTF8);
        }

        public List<string> readJSON()
        {
            List<string> letters = JsonConvert.DeserializeObject<List<string>>(json_data);

            return letters;
        }
    }
}
