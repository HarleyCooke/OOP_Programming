using System;

namespace Mini_Challange
{
    public class Student : Person
    {
        public static int Id { get; set; }

        public Student(string fname, string sname, int yearOfBirth, int id) : base(fname, sname, yearOfBirth)
        {
            Id = id;
            
        }

        public static void GetInfo()
        {
            Console.WriteLine("Name: " + Fname + " " + Sname + " Id: " + Id + " Year of Birth: " + YearOfBirth);
        }



    }
}