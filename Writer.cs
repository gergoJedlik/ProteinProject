using Newtonsoft.Json;
using System.Collections.Generic;

namespace Fehérje
{
    class Writer
    {
        private List<Task> Taskdata { get; set; }

        public Writer()
        {
            Taskdata = new List<Task>();
        }

        public void addToData(int taskNum, string answer)
        {
            Taskdata.Add(new Task(taskNum, answer));
        }

        public void writeToFile() {
            string json = JsonConvert.SerializeObject(Taskdata);
            System.IO.File.WriteAllText("../../eredmenyek.json", json);
        }
    }
}
