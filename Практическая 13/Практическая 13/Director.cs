using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Практическая_13
{
    internal class Director
    {
        private string unit { get; set; }

        public Director(string name, string position, int salary, string acceptDate, string unit) : base(name, position, salary, acceptDate)
        {
            this.unit = unit;
        }
        public void AcceptBudget()
        {
            Console.WriteLine($"Возможны премии! Директор {Name} утвердил бюджет на новый проект");
        }
    }
}
