using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectCreation
{
    class student
    {
        //creating class members that is feild and methods
        public int id = 101;
        public string name = "Mrunmayee";
        public int age = 27;

        public void mymethod()
        {
            Console.WriteLine("Name of student is " + name  +  "\nand id is " + id);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating of object
            student s1=new student();
            s1.mymethod();
            Console.ReadLine();
        }
    }
}
/* output 
 Name of student is Mrunmayee
and id is 101
*/
