using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Mini_Challange
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Age = 2018;             
            Student stu1 = new Student("John", "Doe", 1901, 745736);
            Staff sta1 = new Staff("John", "Doe", 1901, "JD");
            Teacher tea1 = new Teacher("History", "John", "Doe", 1901, "JD");
            Admin adm1 = new Admin("John", "Doe", 1901, "JD", 123);

                          
            
            var menuNum = 0;
            var infoMenuNum = 0;             
                          
            Console.WriteLine("Welcome- " + Environment.NewLine +
                              "1. Create Student" + Environment.NewLine +
                              "2. Create Teacher" + Environment.NewLine +
                              "3. Create Admin" + Environment.NewLine +
                              "4. View People" + Environment.NewLine +
                              "5. Exit");
            
            menuNum = Int32.Parse(Console.ReadLine());

            while (menuNum != 5)
            {
                if (menuNum == 1)
                {
                    Console.WriteLine("Create Student- " + Environment.NewLine +
                                      "Enter FirstName: ");
                                       Student.Fname = Console.ReadLine();
                    Console.WriteLine("Enter Surname: ");
                                       Student.Sname = Console.ReadLine();
                    Console.WriteLine("Enter Year of Birth: ");
                                       Student.YearOfBirth = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Id: ");
                                       Student.Id = Int32.Parse(Console.ReadLine());

                                  menuNum = 0;

                }

                if (menuNum == 2)
                {
                    Console.WriteLine("Create Teacher- " + Environment.NewLine +
                                      "Enter Expertise: ");
                                      Teacher.Expertise = Console.ReadLine();                  
                    Console.WriteLine("Enter FirstName: ");
                                      Teacher.Fname = Console.ReadLine();
                    Console.WriteLine("Enter Surname: ");
                                      Teacher.Sname = Console.ReadLine();
                    Console.WriteLine("Enter Year of Birth: ");
                                      Teacher.YearOfBirth = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter UserName: ");
                                      Teacher.Username = Console.ReadLine();
                                  
                                  menuNum = 0;
                    
                }
                
                if (menuNum == 3)
                {
                    Console.WriteLine("Create Admin- " + Environment.NewLine +
                                      "Enter FirstName: ");
                                      Admin.Fname = Console.ReadLine();
                    Console.WriteLine("Enter Surname: ");
                                      Admin.Sname = Console.ReadLine();
                    Console.WriteLine("Enter Year of Birth: ");
                                      Admin.YearOfBirth = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter UserName: ");
                                      Admin.Username = Console.ReadLine();
                    Console.WriteLine("Enter Office Number: ");
                                      Admin.OfficeNo = Int32.Parse(Console.ReadLine());
                                  
                                  menuNum = 0;
                    
                }

                              if (menuNum == 4)
                              {    
                                                Console.WriteLine("1. Student Info: ");                                   
                                                Console.WriteLine("2. Staff Info: ");
                                                Console.WriteLine("3. Teacher Info: ");
                                                Console.WriteLine("4. Admin Info: ");
                                                Console.WriteLine("5. Back: ");
                                                
                                                infoMenuNum = Int32.Parse(Console.ReadLine());

                                                if (infoMenuNum == 1)
                                                {
                                                                  Student.GetInfo();
                                                                  
                                                }

                                                if (infoMenuNum == 2)
                                                {
                                                                  Staff.GetInfo();
                                                                  
                                                }

                                                if (infoMenuNum == 3)
                                                {
                                                                  Teacher.GetInfo();             
                                                }

                                                if (infoMenuNum == 4)
                                                {
                                                                  Admin.GetInfo();           
                                                }

                                                if (infoMenuNum == 5)
                                                {
                                                                 menuNum = 0;
                                                }
                                                                                                                                                                        
                                                                              

                                                break;
                                                
                              }

                              if (menuNum == 0)
                              {
                                                Console.WriteLine("Welcome- " + Environment.NewLine +
                                                                  "1. Create Student" + Environment.NewLine +
                                                                  "2. Create Teacher" + Environment.NewLine +
                                                                  "3. Create Admin" + Environment.NewLine +
                                                                  "4. View People" + Environment.NewLine +
                                                                  "5. Exit");
            
                                                menuNum = Int32.Parse(Console.ReadLine());
                              }
                
            }
        }
    }
}