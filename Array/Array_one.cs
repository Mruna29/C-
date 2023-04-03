using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr1 = { 11, 22, 43, 24, 75 };
            

            for(i=0; i<arr1.Length; i++)
            {
                Console.WriteLine("Element : " + arr1[i]);
            }
            Console.ReadLine();
         
        }
    }
    
}
