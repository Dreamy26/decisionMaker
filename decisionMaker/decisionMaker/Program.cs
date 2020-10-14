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
            int i;

            //req8
            Console.WriteLine("What is your name? (type your name and press enter)");
            userName = Console.ReadLine();



            do
            {
                Console.WriteLine("Enter a number between 1 & 100");
                userNumber = Int32.Parse(Console.ReadLine());

                if (userNumber % 2 == 0)
                {
                    if (userNumber < 25)
                    {
                        Console.Write("Even and less than 25");
                        Console.Read();
                    }
                    else if (userNumber > 60)
                    {
                        Console.Write($"{userNumber} Even");
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("Even");
                        Console.ReadLine();
                    }
                }
                else
                {
                    // since the outcome is the same for odd numbers greater than and less than 60 there is no test condition 
                    Console.Write($"{userNumber} Odd");
                    Console.Read();


                }
                    Console.WriteLine("Continue? y/n");
                    response = Console.ReadLine();
                   
                } while (response.ToLower() == "y") ;

                // req7
                Console.WriteLine($"Byyyeee {userName.ToUpper()}");
            }
        }
    }


    

