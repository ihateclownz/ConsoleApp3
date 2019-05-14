using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        public static string file = @"wordlist.ini";
        public static Dictionary<string, string> Spanish2Eng = new Dictionary<string, string>();
        public static List<KeyValuePair<string,string>> Spanglish = new List<KeyValuePair<string, string>>();

        static void Main()
        {
            AddWordsToDictionary();

            Intro();
        }

        private static void AddWordsToDictionary()
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("adding words from wordlist");
                //Iterate over the list 
                foreach (var item in WordList.Eng2Spanish)
                {
                    Spanish2Eng.Add(item.Value, item.Key);
                }
                using (StreamWriter sw = new StreamWriter(file))
                    foreach (var entry in WordList.Eng2Spanish)
                        sw.WriteLine("[{0}, {1}]", entry.Key, entry.Value);
            }
            else
            {
                Console.WriteLine("reading words from file5");
                StreamReader sr = new StreamReader(file);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    //Spanish2Eng.Add(arr[0], arr[1]);
                    Spanglish.Add(new KeyValuePair<string,string>(arr[0], arr[1]));
                    
                }
            }
        }

        public static void Intro()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1: English");
            Console.WriteLine("2: Spanish");
            Console.WriteLine("3: Add Word");

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
                else if (selection == "3")
                {
                    AddWord();
                }
                else
                {
                    Console.Clear();
                    Intro();
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

            private static void AddWord()
            {
                string english, spanish;
                Console.Write("English: ");
                english = Console.ReadLine();
                Console.Write("Spanish: ");
                spanish = Console.ReadLine();

                if (WordList.Eng2Spanish.ContainsKey(english))
                {
                    Console.WriteLine("Word already exists.");
                    Console.ReadKey();
                    Console.Clear();
                    AddWord();
                }
                else
                {
                    WordList.Eng2Spanish.Add(english, spanish);
                    using (StreamWriter file = new StreamWriter("wordlist.ini"))
                        foreach (var entry in WordList.Eng2Spanish)
                            file.WriteLine("[{0}, {1}]", entry.Key, entry.Value);
                }
                Console.WriteLine("{0}- {1}: was added to dictionary",english,spanish);
            }
        } 
    }
}