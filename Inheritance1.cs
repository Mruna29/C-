using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Vehicle
    {
        public string brand = "BNW";

        public void mymethod()
        {
            Console.WriteLine("The brand name is =");
        }
    }

    class Car:Vehicle
    {
        public string modelname = "BMW X5 Roadster";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.mymethod();
            Console.WriteLine(c1.brand + "\nand modelname is " + c1.modelname);
            Console.ReadLine();

        }
    }
}
/*output
The brand name is =
BNW
and modelname is BMW X5 Roadster
*/
