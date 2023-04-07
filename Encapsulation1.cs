using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    class Car
    {
        //encapsulated field
        private string name;
        //making encapsulated field public to have acces of that feild
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Name = "BMW";
            Console.WriteLine("Car = " + c1.Name);
            Console.ReadLine();
        }
    }
}
/*output
Car = BMW
*/
