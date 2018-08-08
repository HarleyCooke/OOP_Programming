using System;

namespace UnitTestFibonacci.Properties
{
    public class FiboTestClass
    {
        
        int FibocacciRecTest(int num1 = 0, int num2 = 1, int numFibs = 100) {
            
            if (numFibs > 0) {
                
                numFibs--;
                
                num2 = num1 + num2;
                
                return FibocacciRecTest(num2, num2 + num1, numFibs);
            } 
            
            if (numFibs != 0)
            {
                throw new InvalidOperationException();
            }
            
            return num2 + num1;
        }
    }
}
        