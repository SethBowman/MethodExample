using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(KosysMethod("true"));

            Console.WriteLine(Add(5, 10));
            


           
            


        }


        // access modifier = public
        // return type = void
        // name = LiterallyAnything
        // parameters = ()
        // scope = { }

        public static void LiterallyAnything()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine($"Hello, {name}.");
        }

        



        // access modifier = public
        // return type = string
        // name = ReturnString
        // parameters = ()
        // scope = { }
        // notice the return type is a string and the word "hey" is a string
        public static string ReturnString()
        {
            return "hey";
        } 

        // access modifier = public
        // return type = int
        // name = Add
        // parameters = (int num1, int num2) passing 2 parameters that have a type of int or number
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        public static string Greeting(string firstName, string lastName, bool hasHair)
        {
            return $"Hello, {firstName} {lastName}, it is {hasHair} that you have hair.";
        }

        public static bool KosysMethod(string whatever)
        {
            return bool.Parse(whatever);
        }

    }
}
