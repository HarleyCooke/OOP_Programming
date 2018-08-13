using NUnit.Framework;
using CIV_UnitTesting_Exercises;


namespace CIV_UnitTesting_Excercises.Tests
{
    [TestFixture]
    public class RecursiveCalculationsTests
    {
        [TestCase]
                 public void Test1()
                 {
                     var ans = RecursiveCalculations.FibocacciRec(0, 1, 3);
                     
                     Assert.AreEqual(3,ans);
                     
         
                 }
        
        [TestCase]

                  public void Test2()
                  {
                      var ans = RecursiveCalculations.FactorialRec(1, 4);
                        
                      Assert.AreEqual(0,1);
                        
            
                  }
    }
}