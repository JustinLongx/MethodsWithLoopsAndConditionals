﻿namespace MethodsWithLoopsAndConditionals
{
    public class Program
    {
                
        static void Main(string[] args)
        {
            PrintNumbers();
            Console.WriteLine("--------------------------");
            PrintEveryThirdNumber();
            Console.WriteLine("--------------------------");
            AreNumbersEqual(5,5);
            Console.WriteLine("--------------------------");
            IsEven(2);
            Console.WriteLine("--------------------------");
            IsInRange();
            Console.WriteLine("--------------------------");
            DisplayMultiplacationTable(5);
        }

        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("This number is positive.");
            }
            else
            {
                Console.WriteLine("This number is negative.");
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static bool CanVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
                return true;
            }
            else
            {
                Console.WriteLine("You are not old enough to vote.");
                return false;
            }
        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange()
        {
            Console.WriteLine("Give me a number to determine if its within the range of -10 & 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput <= 10 && userInput >= -10)
            {
                Console.WriteLine("This number is between -10 & 10");
                return true;
            }
            else
            {
                Console.WriteLine("This number is not between -10 & 10");
                return false;
            }
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplacationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = i * number;
                Console.WriteLine($"{i} * {number} = {result}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.
    }
}
