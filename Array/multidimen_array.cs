using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimentinal_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;
            int[] Myarray1 = new int[5];
            int[,] arr2 =new int [2, 2];
            int j;
            
            Console.WriteLine("Enter any five values in your array");
            for (i = 0; i < Myarray1.Length; i++)
            {
                Myarray1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Entered elements are : ");
            for (i = 0; i < Myarray1.Length; i++)
            {

                Console.WriteLine(Myarray1[i]);
            }
           // Console.ReadLine();

            //2nd array
            
            Console.WriteLine("Enter the elements in 2nd array");
            for (i=0; i<2; i++) 
            {
                
                for (j = 0; j < 2; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
            for (i = 0; i < 2; i++)
            {
                 
                for (j = 0; j < 2; j++)
                {
                        Console.WriteLine("Element({0},{1})={2}",i,j,arr2[i,j] );
                }
            }
            Console.ReadLine();
           
        }
    }
}
