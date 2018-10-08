namespace Polymorphism2
{
    public abstract class AutoMobile : Object, IMoveable
    {
        protected AutoMobile(string name, string make, string model) : base(name)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }


        public abstract string GetMake();

        public abstract string GetModel();

        public string Move()
        {
            return "Forward" ;
        }

    }
}