using System;

namespace Mini_Challange
{ 
    public class Person
    {
        public static int Age = 2018;
        public static string Fname { get; set; }
        public static string Sname { get; set; }
        public static int YearOfBirth { get; set; }

        public Person(string fname, string sname, int yearOfBirth)
        {
            Fname = fname;
            Sname = sname;
            YearOfBirth = yearOfBirth;
        }

        public void GetName()
        {
            Console.WriteLine("Name: " + Fname + " " + Sname);
        }

        public static void GetAge(int YearOfBirth,int Date)
        {
            Age = YearOfBirth - Date;
            Console.WriteLine(Age);
        }

    }
}