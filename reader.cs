using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Fehérje
{
    internal class reader
    {
        private string json_data { get; }

        public reader(string file)
        {
           json_data = File.ReadAllText(file, encoding: UTF8Encoding.UTF8);
        }

        public List<Aminosav> readJSON()
        {
            List<Aminosav> Objects = JsonConvert.DeserializeObject<List<Aminosav>>(json_data);

            return Objects;
        }
    }
}
