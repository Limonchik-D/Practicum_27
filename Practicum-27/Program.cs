using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Points[] points = new Points[]
            {
                    new Points (4, 2),
                    new Points (3.5, 4.9),
                    new Points (4, 6)
            };
            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
            }
            Console.Read();
        }
    }
}
