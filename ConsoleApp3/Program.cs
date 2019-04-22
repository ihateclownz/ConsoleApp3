using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        public static Dictionary<string, string> Spanish2Eng = new Dictionary<string, string>();
        static void Main()
        {
            //Iterate over the list 
            foreach (var item in WordList.Eng2Spanish)
            {
                Spanish2Eng.Add(item.Value, item.Key);
            }

            Intro();
        }
        public static void Intro()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1: English");
            Console.WriteLine("2: Spanish");

            Translate.Trans(Console.ReadLine());
        }
        public static class Translate
        {
            public static void Trans(string selection)
            {
                string input = "", lang1 = "", lang2 = "";
                
                if (selection == "1")
                {
                    lang1 = "English: ";
                    lang2 = "Spanish: ";
                }
                else if (selection == "2")
                {
                    lang1 = "Spanish: ";
                    lang2 = "English: ";
                }

                Console.Write("{0}: ",lang1);
                // Console.Write(lang1 + ": ");  This is another way of writing the same line. Called String Concatenation.
                input = Console.ReadLine().ToLower();

                if (WordList.Eng2Spanish.ContainsKey(input))  // Looks through the dictionary to see if the word is english and has a match
                {
                    Console.WriteLine(lang2 + WordList.Eng2Spanish[input]);
                }
                else if (Spanish2Eng.ContainsKey(input)) // Looks through the dictionary to see if the word is spanish and has a match
                {
                    Console.WriteLine(lang2 + Spanish2Eng[input]);
                }
                else  // neither the word the user inputed is in the English or Spanish dictionary ...
                {
                    Console.WriteLine("Word does not exist, please try again.");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Intro();
            }
        } 
    }
}