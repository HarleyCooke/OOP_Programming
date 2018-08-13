using System.Runtime.CompilerServices;

namespace PolymorphismPrac
{
    public abstract class Animals
    {
        public int Age { get; set; }
        public float Life { get; set; }
        public string Name { get; set; }
        public float Hunger { get; set; }


        public abstract class Mammal : Animals
        {
            public abstract void Move();
            public abstract void Poop();
            public abstract void Feed();
            
        }

        public abstract class Reptile : Animals
        {
            public abstract void Move();
            public abstract void Poop();
            public abstract void Feed();
        }


    }
}