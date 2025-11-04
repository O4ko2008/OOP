using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Phone p = new Phone("Iphone", 99);
            p.Use();
            p.Use();
            p.Use();
            p.BatteryLevel = 150;
            p.Use();
        }
    }
}