using System;

namespace Mini_Challange
{
    public  class Teacher : Staff
    {
        public static string Expertise { get; set; }
        
        public Teacher(string expertise, string fname, string sname, int yearOfBirth, string username) : base(fname, sname, yearOfBirth, username)
        {
            Expertise = expertise;
        }
        
        public static void GetInfo()
        {
            Console.WriteLine("Name: " + Fname + " " + Sname + " Username: " + Username + " Expertise: " + Expertise + " Year of Birth: " + YearOfBirth);
        }
    }
}