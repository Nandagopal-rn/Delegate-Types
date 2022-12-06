using System;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Calculator using Action Delegate\n");

            var ExecAddAction = new Action<int, int>(AddNumber);
            PerformOperation(ExecAddAction);

            var ExecDiffAction = new Action<int, int>(SubstractNumber);
            PerformOperation(ExecDiffAction);

            var ExecMultiplyAction = new Action<int, int>(MultiplyNumber);
            PerformOperation(ExecMultiplyAction);

            var ExecDivideAction = new Action<int, int>(DivisionNumber);
            PerformOperation(ExecDivideAction);
        }

        static void PerformOperation(Action<int,int> Operations)
        {
            Operations.Invoke(50,20);
        }

        static void AddNumber(int FirstNumber,int SecondNumber)
        {
            Console.WriteLine($"Sum is {FirstNumber+SecondNumber}");
        }
        static void SubstractNumber(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine($"Difference is {FirstNumber - SecondNumber}");
        }
        static void MultiplyNumber(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine($"Product is {FirstNumber * SecondNumber}");
        }
        static void DivisionNumber(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine($"Quotient is {FirstNumber / SecondNumber}");
        }
    }
}
