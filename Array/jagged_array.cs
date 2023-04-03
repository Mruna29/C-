using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main()
        {
            //Jagged array - array of arrays
            int[][] arr1 = new int[3][];
            arr1[0] = new int[2];
            arr1[1] = new int[3];
            arr1[2] = new int[2];

           
            arr1[0][0] = 444; arr1[0][1] = 555; arr1[1][0] = 666;

          
            Console.WriteLine("\n\n\t jagged array a Elements ");
            Console.WriteLine("\n\n\t arr1[0][0] = {0}\t arr1[0][1] = {1}\t arr1[1][0] = {2} ", arr1[0][0], arr1[0][1], arr1[1][0]);

            Console.ReadLine();
        }
    }
}
