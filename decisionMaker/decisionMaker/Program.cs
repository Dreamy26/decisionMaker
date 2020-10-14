// Requirements are listed in notes.md 

using System;

namespace decisionMaker
{
    class MainClass
    {
        private static string response;

        public static void Main(string[] args)
        {
            string userName = string.Empty;
            int userNumber = 0;

            //req8
            Console.WriteLine("What is your name? (type your name and press enter)");
            userName = Console.ReadLine();

            

            do
            {
                Console.WriteLine("Enter a number between 1 & 100");
                userNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Continue? y/n");
                response = Console.ReadLine();
            } while (response.ToLower() == "y");

            // req7
            Console.WriteLine("Bye");

            
        }
    }
}
