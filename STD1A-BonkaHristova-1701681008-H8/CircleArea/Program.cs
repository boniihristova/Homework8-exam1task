using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int radius =rand.Next(33,187);
            double pi = Math.PI;
            double area = pi * (radius * radius);
            Console.WriteLine(" The circle random height {0}",radius);
            Console.WriteLine("The circle area {0}", Math.Round(area,2));
        }
    }
}
