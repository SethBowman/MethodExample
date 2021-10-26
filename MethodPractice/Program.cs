using System;
using System.Collections.Generic;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleCheck(PasswordCheck()));

            Console.WriteLine();
            Console.WriteLine("Press any key to continue to next method..");
            Console.ReadKey();
            Console.Clear();

            CanVote();

        }

        public static bool CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int age);

            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age:");
                canParse = int.TryParse(Console.ReadLine(), out age);
            }

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough to vote.");
                return false;
            }
            
        }


        public static string PasswordCheck()
        {
            Console.Write("Enter a new password: ");
            return Console.ReadLine();
           
        }

        public static string DoubleCheck(string password)
        {
            Console.Write("Enter password again: ");
            var passwordAgain = Console.ReadLine();

            while (password != passwordAgain)
            {
                Console.Clear();
                Console.WriteLine("Passwords did not match, try again.");


                password = PasswordCheck();
                Console.Clear();

                Console.Write("Enter password again: ");
                passwordAgain = Console.ReadLine();
            }

            return "Password updated.";
        }


    }
}
