using System;

namespace Polymorphism2
{
    public abstract class Animal : Object, IMoveable, ISpeakable
    {

        protected Animal(string name, string species) : base(name)
        {
            Species = species;
        }

        public string Species { get; set; }


        public abstract string GetSpecies();

        public string Move()
        {
            return "Forwards";
        }

        public string Speak()
        {
            return "Sounds";
        }
    }
}