﻿using System;

namespace MulticastDelegateApp
{
    public delegate void Calculator(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = Addition;
            calc += Multiplication;
            Console.Write("Please supply first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please supply second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            calc(num1, num2);
        }
        static void Addition(int a, int b)
        {
            Console.WriteLine($"Sum is: {a + b}");
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine($"Multiply: {a * b}");
        }
    }
}
