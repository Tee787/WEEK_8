using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("***********************Convert Miles to Kilometers*******************");
            Console.WriteLine("*********************************************************************");

            double miles, kilometers;

            Console.WriteLine("\nPlease enter miles: ");
            miles = Convert.ToDouble(Console.ReadLine());

            kilometers = miles * 1.6;

            ConvertToKms(kilometers);
            
            //Console.WriteLine(kilometers + "kilometers");

        }
        public static void ConvertToKms(double kilometers)
        {
            Console.WriteLine(kilometers + "kilometers");
        }
    }
}
