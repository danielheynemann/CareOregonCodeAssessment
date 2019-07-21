using System;

namespace FibonacciTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] requestedPositions = { 10, 40 };
            
            Calculator codeAssessmentCalculator = new Calculator();
            
            foreach (int position in requestedPositions)
            {
                Console.WriteLine(codeAssessmentCalculator.CalculateFibonacci(position));
            }

            Console.ReadLine();
        }         
    }
}
