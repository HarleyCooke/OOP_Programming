using System;

namespace CIV_UnitTesting_Exercises
{
    public class CalcTest
    {
        static void Main(string[] args)
        {           
            var fibonacciTest = new RecursiveCalculations();

            int fibresult = fibonacciTest.FibocacciRec(0, 1, 2);

            if (fibresult != fibonacciTest.FibocacciRec(1, 2, 0))
            {
                throw new InvalidOperationException();
            }
            
            Console.WriteLine(fibresult);

            var factorialTest = new RecursiveCalculations();

            int result = factorialTest.FactorialRec(5, 5);

            if (result != 120)
            {
                throw new InvalidOperationException();
            }
            
            Console.WriteLine(result);
            Console.ReadLine();



        }
    }
}