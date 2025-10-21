using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп_задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Pet max = new Pet("Deniska", 150);
                max.Play();
                max.Rest();
                max.Play();
            Console.ReadKey();
            }
        }
}


    
