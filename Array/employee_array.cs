using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Dept No,Department Name,Designation Code, Designation name and show one record*/

namespace dept_info_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dept_no = { 0,0 };
            string[] dept_name= { "", "" };
            char[] desg_code = { 'a', 'a' };
            string[] desg_name = { "", "" };
            int i;


            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("\n\nEnter the department no : ");
                string a = Console.ReadLine();
                dept_no[i] = int.Parse(a);

                Console.WriteLine("\n\nenter department names : ");
                dept_name[i] = Console.ReadLine();

                Console.WriteLine("\n\nenter designation code : ");
                a = Console.ReadLine();
                desg_code[i] = a[0];


                Console.WriteLine("\n\nenter designation names : ");
                desg_name[i] = Console.ReadLine();
            }

                for (i = 0; i < 2; i++)
                {
                    Console.Write("\n\nEmployee with Emp ID {0} works in {1} Department as a {2} .", dept_no[i], dept_name[i], desg_name[i]);
                }

                Console.ReadLine();
      
        }
    }
}
