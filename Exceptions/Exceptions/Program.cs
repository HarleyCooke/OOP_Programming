using System;
using System.Collections.Generic;


namespace Exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            var sum = 0;
            var Digits = 0;



            try
            {
                Console.WriteLine(Environment.NewLine + "Please add a new number to the list !!");
                Digits = Int32.Parse(Console.ReadLine());
                Console.Write(DateTime.UtcNow);
                if (Digits <= 0)
                {
                    throw new ZeroException();
                }

                if (Digits >= 15)
                {
                    throw new BoringException();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer", Digits);
                Console.Write(DateTime.UtcNow);
            }
            catch (ZeroException)
            {
                Console.WriteLine("{0} is Zero or less", Digits);
                Console.Write(DateTime.UtcNow);
            }
            catch (BoringException)
            {
                Console.WriteLine("{0} is Fifthteen or Higher", Digits);
                Console.Write(DateTime.UtcNow);
            }


            for (int i = Digits; i >= 0; i /= 10) 
            {
                if (i > 0)
                {
                    numbers.Add(i % 10);
                    
                }
                else
                {
                    for (int j = 0; j < numbers.Count; j=j+1)
                    {
                        sum = sum + numbers[j];
                        Console.WriteLine(Environment.NewLine + sum);
                        Console.Write(DateTime.UtcNow);
                        
                    }

                    break;
                }
                                
            }

           
            Console.ReadLine();  

        }
    }

    public class ZeroException : Exception
    {
       
    }

    public class BoringException : Exception
    {
        
    }
}