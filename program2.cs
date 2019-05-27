using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class program1
    {
        static string input;

        static void Main()
        {
            Intro();
        }

        private static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Welcome");

            foreach (var item in Calculations.calcType)
            {
                Console.WriteLine("{0}: {1}",item.Key, item.Value);
            }

            input = Console.ReadLine();
            int.TryParse(input, out Calculations.selection);

            GetVars();
        }
        public static void GetVars()
        {
            Console.Clear();
            Console.WriteLine("Calculating {0}",Calculations.calcType[Calculations.selection]);
            SetType();
            Console.WriteLine("{0}: ",Type.y);
            input = Console.ReadLine();
            float.TryParse(input, out Calculations.vars[1]);
            Console.WriteLine("{0}:",Type.z );
            input = Console.ReadLine();
            float.TryParse(input, out Calculations.vars[2]);
            Console.WriteLine("{0}: is {1}", Type.x, Calculations.Formula());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Intro();
        }
        public static void SetType()
        {
            switch (Calculations.selection)
            {
                case 0: Type.x = "a"; Type.y = "w"; Type.z = "l"; Calculations.multiDiv = 0;break;
                case 1: Type.x = "a"; Type.y = "b"; Type.z = "h"; Calculations.multiDiv = 0; break;
                case 2: Type.x = "d"; Type.y = "m"; Type.z = "v"; Calculations.multiDiv = 1; break;
                case 3: Type.x = "m"; Type.y = "d"; Type.z = "v"; Calculations.multiDiv = 0; break;
                case 4: Type.x = "v"; Type.y = "m"; Type.z = "d"; Calculations.multiDiv = 1; break;
            }
        }
    }
    static class Type
    {
        static public string x, y, z; 
    }
    static class Calculations
    {
        static public int selection, multiDiv;
        static public float[] vars = { 0.0f,0.0f,0.0f};
        static public float x, y, z;
        static public Dictionary<int, string> calcType = new Dictionary<int, string>
        {
            {0, "Rectangle Area" },
            {1,"Triangle Area " },
            {2,"Density" },
            {3,"Mass" },
            {4,"Volume" } 
        };
        static public float Formula()
        {
            if (multiDiv == 1)
            {
                vars[0] = vars[1] * vars[2];
            }
            else
            {
                vars[0] = vars[1] / vars[2];
            }
            return vars[0];
        }
    }
}
