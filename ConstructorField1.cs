using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorField1
{
    //class no 1
    public static class house
    {
        //fields
        public static float hl = 2;  //height and lenght{0}
        public static float hb = 2;  //height and breadth{1}

        //get property
        public static float harea
        {
            get { return (hl * hb); }
        }
    }
    //class no 2
    public class home
    {
        public float l;
        public float b;
        public float area;

        //constructor
        public home()
        {
            l = 10;  //{0}
            b = 5;   //{1}
            area = l * b;  //{2}
        }

        //constructor with parameters(L and B is fiels from parent class home)
        public home(float x, float y)
        {
            l = x;   //{0}
            b = y;   //{1}
            area = l * b;  //{2}
        }
    }

    //class no 3(class Program
    class room
    {
        static void Main()
        {
            //class field calling
            Console.Write("optimal Room dimensions are \n{0} meters. X {1} meters. & area = {2} sq.meters.", house.hl, house.hb, house.harea);

            //object class home
            home h = new home();
            Console.Write("Default Room dimensions are \n{0} meters. X {1} meters. & area = {2} sq.meters.", h.l, h.b, h.area);

            //object with parameters
            home h1 = new home(5, 4);
            Console.Write("Room 1 dimensions are \n{0} meters. X {1} meters. & area = {2} sq.meters.", h1.l, h1.b, h1.area);
            Console.ReadKey();
        }
    }
}
/*output
 optimal Room dimensions are
2 meters. X 2 meters. & area = 4 sq.meters.Default Room dimensions are
10 meters. X 5 meters. & area = 50 sq.meters.Room 1 dimensions are
5 meters. X 4 meters. & area = 20 sq.meters.
*/
