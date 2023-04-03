using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr1 = { 10, 20, 30 };
            int[] arr2 = { 11, 22, 55 };
            int[] arr3 = { 34, 45, 87 };

            Console.WriteLine("arr1 Elements are  = ");
            for (i=0; i<arr1.Length; i++) 
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadLine();

            Console.WriteLine("arr2 Elements are  = ");
            for (i=0; i<arr2.Length; i++) 
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadLine();

            Console.WriteLine("arr3 Elements are = ");
            for(i=0; i<arr3.Length; i++) 
            {
                arr3[0] = arr1[1] + arr2[2];
                arr3[1] = arr2[2] + arr1[2];
                arr3[2] = arr1[0] + arr2[0];

                Console.WriteLine(arr3[i]);
            }
            Console.ReadLine();
        }
    }
}
