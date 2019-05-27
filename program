using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //TODO: Create Methods for Density Mass and Volume

    class Program
    {
        static string input;

        static void Main()
        {

            Console.WriteLine("Welcome to area calculations!!");
            CalculateArea();
        }

        static void CalculateArea()
        {

            Console.WriteLine("0: Rectangle");
            Console.WriteLine("1: Triangle");
            Console.WriteLine("2: Density");
            input = Console.ReadLine();

            if (input == "0") 
            {
                RectangleArea();
            }
            else if (input == "1")
            {
                TriangleArea();
            }
            else if (input == "2")
            {
                DensityCalc();
            }
            else
            {
                Console.Clear();
                Main();
            }
        }

        private static void DensityCalc()
        {

            float d, m, v;
            Console.Clear();

            Console.WriteLine("Calculate for \n0: Density \n1: Mass \n2: Volume");
            input = Console.ReadLine();

            if (input == "0") // Density
            {
                Console.WriteLine("Calculating Density");
                Console.WriteLine("M?");

                input = Console.ReadLine();
                m = float.Parse(input);

                Console.WriteLine("V?");
                input = Console.ReadLine();
                v = float.Parse(input);

                d = m / v;

                Console.WriteLine("Density is {0}",d);
                Console.ReadKey();
                Console.Clear();

                Main();
            }
            else if (input == "1") //Mass
            {
                Console.WriteLine("Calculating Mass");
                Console.WriteLine("D?");

                input = Console.ReadLine();
                d = float.Parse(input);

                Console.WriteLine("V?");
                input = Console.ReadLine();

                v = float.Parse(input);

                m = d * v;

                Console.WriteLine("Mass is {0}", m);
                Console.ReadKey();
                Console.Clear();

                Main();
            }
            else if (input == "2") //Volume
            {
                Console.WriteLine("Calculating Volume");
                Console.WriteLine("M?");

                input = Console.ReadLine();
                m = float.Parse(input);

                Console.WriteLine("D?");

                input = Console.ReadLine();
                d = float.Parse(input);

                v = m / d;

                Console.WriteLine("Volume is {0}", v);
                Console.ReadKey();
                Console.Clear();

                Main();
            }
            else
            {
                Console.Clear();
                DensityCalc();
            }
        }

        private static void TriangleArea()
        {
            float b, a, h;


            Console.WriteLine("base?");  //Writes base? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            b = float.Parse(input); // turns input var intpo a float


            Console.WriteLine("height?");  //Writes height? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            h = float.Parse(input); // turns input var intpo a float



            a = b * h / 2;

            Console.WriteLine("The area of the triangle is " + a);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();

            Main();
        }

        private static void RectangleArea()
        {
            float w, l, a;


            Console.WriteLine("width?");  //Writes width? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            w = float.Parse(input); // turns input var intpo a float


            Console.WriteLine("length?");  //Writes length? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            l = float.Parse(input); // turns input var intpo a float

            //formula that calculates area
            a = w * l;


            Console.WriteLine("The area of the rectangle is " + a);

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();

            Console.Clear();

            Main();
        }
        private static void CircleArea()
        {
            float w, l, a;


            Console.WriteLine("width?");  //Writes width? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            w = float.Parse(input); // turns input var intpo a float


            Console.WriteLine("length?");  //Writes length? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            l = float.Parse(input); // turns input var intpo a float

            //formula that calculates area
            a = w * l;


            Console.WriteLine("The area of the rectangle is " + a);

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();

            Console.Clear();

            Main();
        }
        private static void Circumfernce()
        {
            float w, l, a;


            Console.WriteLine("width?");  //Writes width? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            w = float.Parse(input); // turns input var intpo a float


            Console.WriteLine("length?");  //Writes length? to console
            input = Console.ReadLine();  //takes user input and stores into input var

            l = float.Parse(input); // turns input var intpo a float

            //formula that calculates area
            a = w * l;


            Console.WriteLine("The area of the rectangle is " + a);

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();

            Console.Clear();

            Main();
        }

    }
}
