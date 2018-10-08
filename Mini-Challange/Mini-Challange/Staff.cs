using System;

namespace Mini_Challange
{
    public class Staff : Person
    {
        public static string Username { get; set; }

        public Staff(string fname, string sname, int yearOfBirth, string username) : base(fname, sname, yearOfBirth)
        {
            Username = username;
        }

        public static void GetInfo()
        {
            Console.WriteLine("Name: " + Fname + " " + Sname + "Username: " + Username + "Year of Birth: " + YearOfBirth);
        }
    }
}


