using System;
using System.Collections.Generic;
using Shapes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square Sq1 = new Square("Colour", 0);
            
            Rectangle Rec1 = new Rectangle("Colour", 0, 0);
            
            
            var menuNum = 0;
            var infoMenuNum = 0;             
                          
            Console.WriteLine("Welcome- " + Environment.NewLine +
                              "1. Create Square" + Environment.NewLine +
                              "2. Create Rectangle" + Environment.NewLine +
                              "5. Exit");
            
            menuNum = Int32.Parse(Console.ReadLine());

            while (menuNum != 5)
            {
                if (menuNum == 1)
                {
                    Console.WriteLine("Create Square- " + Environment.NewLine +
                                      "Enter Colour: ");
                    Sq1.Colour = Console.ReadLine();

                    try
                    {
                        Console.WriteLine("Enter Size Value: " + Environment.NewLine);
                        Sq1.Size = Int32.Parse(Console.ReadLine());
                        if (Sq1.Size <= 0)
                        {
                            throw new ZeroException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("{0} is not an integer", Sq1.Colour);
                    }
                    catch (ZeroException)
                    {
                        Console.WriteLine("{0} is Zero or less", Sq1.Colour);
                    }
                    
                    
                    Sq1.GetInfo();

                    menuNum = 0;

                }

                if (menuNum == 2)
                {
                    Console.WriteLine("Create Rectangle- " + Environment.NewLine +
                                      "Enter Colour: ");
                    Rec1.Colour = Console.ReadLine();

                    try
                    {
                        Console.WriteLine("Enter Width: ");
                        Rec1.Width = Int32.Parse(Console.ReadLine());
                        if (Rec1.Width <= 0)
                        {
                            throw new ZeroException();
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("{0} is not an integer", Rec1.Width);
                    }
                    catch (ZeroException)
                    {
                        Console.WriteLine("{0} is Zero or less", Rec1.Width);
                    }
                    
                    try
                    {
                        Console.WriteLine("Enter Height: " + Environment.NewLine);
                        Rec1.Height = Int32.Parse(Console.ReadLine());
                        if (Rec1.Height <= 0)
                        {
                            throw new ZeroException();
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("{0} is not an integer", Rec1.Height);
                    }
                    catch (ZeroException)
                    {
                        Console.WriteLine("{0} is Zero or less", Rec1.Height);
                    }
                    
                    
                    
                    
                    Rec1.GetInfo();

                    menuNum = 0;

                }

                if (menuNum == 0)
                {
                    Console.WriteLine("Welcome- " + Environment.NewLine +
                                      "1. Create Square" + Environment.NewLine +
                                      "2. Create Rectangle" + Environment.NewLine +
                                      "5. Exit");
            
                    menuNum = Int32.Parse(Console.ReadLine());
                }
            }
        }
        
        public class ZeroException : Exception
        {
       
        }
    }
}
