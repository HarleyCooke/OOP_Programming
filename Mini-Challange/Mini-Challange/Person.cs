namespace Mini_Challange
{
    public abstract class Person
    {
        public string Fname { get; set; }
        public string Sname { get; set; }
        public int YearOfBirth { get; set; }

        protected Person(string fname, string sname, int yearOfBirth)
        {
            Fname = fname;
            Sname = sname;
            YearOfBirth = yearOfBirth;
        }

        public abstract void GetName();
        public abstract void GetAge();

    }
}