using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusAndArea_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("*******************************Radius / Area_Circle******************************");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine("Calculator for Radius, Diameter, Circumference and Area of a circle.\n");    

            double diameter, circumference, area;                                                       

            Console.Write("\nEnter the radius: ");                                                      
            int radius = Convert.ToInt32(Console.ReadLine());                                           
            Console.WriteLine("\nThe radius is: {0}cm ", radius);                                       
            Console.WriteLine("\nThe diameter is: {0}cm ", 2 * radius);
            Circumference(int, radius);
            //Console.WriteLine("\nThe circumference is: {0}cm ", Math.Round(2 * Math.PI * radius, 1));  
            Console.WriteLine("\nThe area is: {0}cm ", Math.Round(Math.PI * (radius * radius), 1));
        }

        static void Circumference(int radius)
        {
            Console.WriteLine("\nThe circumference is: {0}cm ", Math.Round(2 * Math.PI * 2 * radius, 1));
        }
    }
}
