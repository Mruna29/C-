using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] arr1 = { "apple", "banana", "kivi", "mango", "grapes", "pineapple" };

            for(i=0; i<arr1.Length; i++) 
            {
                Console.WriteLine("Fruit : " + arr1[i]);
            }
            Console.ReadLine();
        }
    }
}
