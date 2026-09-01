using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class Calculation
    {

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Operation { get; set; }
        public Calculation(int number1, int number2, string operation)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;
        }
        public double Calculate()
        {
            switch (Operation)
            {
                case "+":
                    return Number1 + Number2;
                case "-":
                    return Number1 - Number2;
                case "*":
                    return Number1 * Number2;
                case "/":
                    if (Number2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return (double)Number1 / Number2;
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }
    }
}
