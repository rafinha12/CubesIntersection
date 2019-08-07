using EjGPM.GeometricFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGPM
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube c1 = getCube();
            Cube c2 = getCube();
            decimal volume = c1.OrthoedronIntersection(c2);
            Console.WriteLine("The intersection volume is: " + volume +".");
            Console.WriteLine("Press Q to quit.");
            string mystring = Console.ReadLine();
            while (!mystring.Equals("Q") && !mystring.Equals("q"))
            {
                Console.WriteLine("Press Q to quit.");
                mystring = Console.ReadLine();
            }
        }
        //Function for build a cube with the parameters received by console
        static Cube getCube()
        {
            string mystring = null;
            int arist;
            int x, y, z;
            Console.WriteLine("Define the length of the cube's artists as a Natural number greater than 0: ");
            mystring = Console.ReadLine();
            while (int.TryParse(mystring, out arist) == false || arist <= 0)
            {
                Console.WriteLine("Define the length of the cube's artists as a Natural number greater than 0: ");
                mystring = Console.ReadLine();
            }
            mystring = null;
            Console.WriteLine(" Define the coordinates of the center of the cube:");
            Console.WriteLine(" X Coordinate:");
            mystring = Console.ReadLine();
            while (int.TryParse(mystring, out y) == false)
            {
                Console.WriteLine("ERROR: Define the X coordinate as an integer ");
                Console.WriteLine(" X Coordinate:");
                mystring = Console.ReadLine();
            }
            mystring = null;
            Console.WriteLine(" Y Coordinate:");
            mystring = Console.ReadLine();
            while (int.TryParse(mystring, out z) == false)
            {
                Console.WriteLine("ERROR: Define the Y coordinate as an integer ");
                Console.WriteLine(" Y Coordinate:");
                mystring = Console.ReadLine();
            }
            mystring = null;
            Console.WriteLine(" Z Coordinate:");
            mystring = Console.ReadLine();
            while (int.TryParse(mystring, out x) == false)
            {
                Console.WriteLine("ERROR: Define the Z coordinate as an integer ");
                Console.WriteLine(" Z Coordinate:");
                mystring = Console.ReadLine();
            }
            return new Cube(arist, x, y, z);
        }
    }
}
