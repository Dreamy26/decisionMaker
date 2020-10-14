// Requirements are listed in notes.md 

using System;

namespace decisionMaker
{
    class MainClass
    {
        private static string response;

        public static void Main(string[] args)
        {
            //req8
            Console.WriteLine("What is your name? (type your name and press enter)");

            
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Continue? y/n");
                response = Console.ReadLine();
            } while (response == "y");
            // req7
            Console.WriteLine("Bye");

            
        }
    }
}
