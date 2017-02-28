using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            string radius = Console.ReadLine();
            int radiusNum = int.Parse(radius);
            double area = Math.PI * radiusNum * radiusNum;
            string areaStr = area.ToString();
            Console.WriteLine("The area of a circle with radius "+ radius + " is: " + areaStr);
            Console.ReadLine();
        }
    }
}
