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

            //req9
            Console.WriteLine("What is your name? (type your name and press enter)");
            userName = Console.ReadLine();



            do
            {
                //req1
                Console.WriteLine("Enter a number between 1 & 100");
                userNumber = Int32.Parse(Console.ReadLine());

                //req2
                if (userNumber % 2 == 0)
                {
                    //req4
                    if (userNumber < 25)
                    {
                        Console.Write("Even and less than 25");
                        Console.Read();
                    }
                    //req5
                    else if (userNumber > 60)
                    {
                        //req6
                        Console.Write($"{userNumber} Even {userName}");
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
                    //req3 & req7
                    Console.Write($"{userNumber} Odd {userName}");
                    Console.Read();


                }
                    Console.WriteLine("Continue? y/n");
                    response = Console.ReadLine();
                   
                } while (response.ToLower() == "y") ;

                // req8
                Console.WriteLine($"Byyyeee {userName.ToUpper()}");
            }
        }
    }


    

