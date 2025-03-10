using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
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

        public List<char> readJSON()
        {
            List<char> letters = JsonConvert.DeserializeObject<List<char>>(json_data);

            return letters;
        }
    }
}
