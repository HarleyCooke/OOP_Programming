using System;

namespace Mini_Challange
{
    public class Admin : Staff
    {
        public static int OfficeNo { get; set; }
        
        public Admin(string fname, string sname, int yearOfBirth, string username, int officeNo) : base(fname, sname, yearOfBirth, username)
        {
            OfficeNo = officeNo;
        }
        
        public static void GetInfo()
        {
            Console.WriteLine("Name: " + Fname + " " + Sname + " Username: " + Username + " Office Number: " + OfficeNo + " Year of Birth: " + YearOfBirth);
        }

        
    }
}