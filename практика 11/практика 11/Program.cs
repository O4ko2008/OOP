using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace практика_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Lada", 150);
            c.Drive();

            c.Speed = 400;
            c.Drive();

            c.Speed = -5;
            c.Drive();

        }
    }
}

