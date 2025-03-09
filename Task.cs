using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehérje
{
    class Task
    {
        public int TaskNumber { get; private set; }

        public string Answer { get; private set; }
        public Task(int taskNumber, string answer)
        {
            TaskNumber = taskNumber;
            Answer = answer;
        }

    }
}
