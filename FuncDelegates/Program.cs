using System;

namespace FuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Calculator\n");

            var AddFunc = new Func<int, int, int>(AddNumber);
            Console.WriteLine($"Sum is {AddFunc.Invoke(4, 3)}");

            var SubFunc = new Func<int, int, int>(substractNumber);
            Console.WriteLine($"Difference is {SubFunc.Invoke(4, 3)}");

            var MultiplyFunc = new Func<int, int, int>(multiplyNumber);
            Console.WriteLine($"Product is { MultiplyFunc.Invoke(4, 3)}");

            var DivideFunc = new Func<float, float, float>(divideNumber);
            Console.WriteLine($"Division is {DivideFunc.Invoke(4, 3)}");

        }


        static int AddNumber(int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int substractNumber(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        static int multiplyNumber(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        static float divideNumber(float firstNumber, float secondNumber)
        {
            return (firstNumber / secondNumber);
        }
    }
}

