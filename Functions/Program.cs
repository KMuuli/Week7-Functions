﻿using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe:(sisesta '+', '-', '*' või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwonumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }
        
        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        // lahutamine
        private static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
        //korrutamine
        private static void MultiplyTwonumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
    }
}
