using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine("Name is " +  fname);
            Console.ReadLine();
        }
        static int MyMethod(int x, int y)
        {
            return x + y;
        }
        static float MyMethod(float x, float y) 
        {
            return x - y;
        }
        static double MyMethod(double a, double b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            MyMethod("Mrunmayee");
            Console.WriteLine("The Addition is =" + MyMethod(12, 12));
           Console.WriteLine("The subtraction  is =" + MyMethod(2.33f, 6.678f));
           Console.WriteLine("The Multiplication  is =" + MyMethod(10, 20));
            Console.ReadLine();
        }
    }
}
