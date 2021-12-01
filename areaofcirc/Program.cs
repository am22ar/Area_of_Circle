using System;

namespace areaofcirc
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.Write("enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double a = Math.PI * r * r;
            Console.Write("area of circle: " + a.ToString("#.00"));
                Console.Read();
        }
    }
}
