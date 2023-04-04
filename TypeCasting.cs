using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First number:");
            int value1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int value2=Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            int addition= value1 + value2;
            Console.WriteLine("The Addition is = " + addition);
            Console.ReadLine();

        }
    }
}
