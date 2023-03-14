using System;

namespace Method2
{
    class Program
    {
        public static void ageChecker()
        { bool oldEnough;
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello, What is your first name?");
                string userName = Console.ReadLine();
                Console.WriteLine($"How old are you {userName}?");
                int userAge = int.Parse(Console.ReadLine());

                if (userAge < 21)
                {
                    Console.WriteLine("Sorry: Your not old enough to enter website! Next person please!");
                    oldEnough = false;
                }
                else
                {
                    Console.WriteLine("Welcome to the website!");
                    oldEnough = true;

                    Console.WriteLine("By the way. If you could have any 2 sports cars what would they be?");
                    string userName2 = Console.ReadLine();

                    Console.WriteLine($"Nice to meet you {userName}.");
                    Console.WriteLine($" So {userName}. Your {userAge}! That's awesome!");
                    Console.WriteLine($"{userName} I think it's awesome that you like {userName2}.");
                    Console.WriteLine("Now that your offically in the club so to speak . How does it feel to be one of us?");
                    String userInput = Console.ReadLine();
                    Console.WriteLine($"Awesome {userName} Im so glad you like it.");
                    Console.WriteLine($"Now {userName} lets take a little quiz. Give me a number to add.");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Give me another number to add to the first one.");
                    ; int num2 = int.Parse(Console.ReadLine());
                    int sum = (num1 + num2);
                    Console.WriteLine($"With the sum of your 2 numbers the answer is {sum}.");

                }
            } while (oldEnough == false);


        }
        static void Main(string[] args)
        {
            ageChecker();
            Console.WriteLine(Multiply(5,3));
            Console.WriteLine(Divide(10, 2));
            VoidMultiply(20,2);
        } 


        public static int Multiply(int num3, int num4)
        {
          return  num3 * num4;

            

        }

        public static int Divide(int num5, int num6)
        {

            return num5 / num6;
        }

        public static void VoidMultiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }










    }
}
