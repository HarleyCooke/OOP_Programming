using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Mini_Challange
{
    public abstract class Student : Person
    {
        public int Id { get; set; }

        protected Student(string fname, string sname, int yearOfBirth, int id) : base(fname, sname, yearOfBirth)
        {
            Id = id;
            
        }


        public void GetInfo()
        {
            Console.WriteLine("Name: " + Fname + " " + Sname + "Id: " + Id + "Year of Birth: " + YearOfBirth);
        }



    }
}