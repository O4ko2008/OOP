using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Практическая_13
{
    internal class Manager
    {
        private int teamSize;
        private int TeamSize
        {
            get { return teamSize; }
            set
            {
                if (teamSize >= 0) { teamSize = value; }
                else { teamSize = 0; }
            }
        }
        public Manager(string name, string position, int salary, string acceptDate, int teamSize) : base(name, position, salary, acceptDate)
        {
            this.teamSize = teamSize;
        }
        public void HoldMeeting()
        {
            Console.WriteLine($"Менеджер {Name} провел собрание с командой из {TeamSize} человек");

        }
    }
}