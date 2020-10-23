using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast cirkles radius : ");
            double Radius = double.Parse(Console.ReadLine());
            double Omkreds = 2 * Radius * Math.PI;

            Console.WriteLine("Cirkles omkreds er {0:N2}", Omkreds);
            Console.ReadKey();
        }
    }
}
