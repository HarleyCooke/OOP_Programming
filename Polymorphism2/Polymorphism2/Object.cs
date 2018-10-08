namespace Polymorphism2
{
    public abstract class Object
    {
        protected Object(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract string GetName();
    }
}