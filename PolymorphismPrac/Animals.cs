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
            protected Mammal(int age, float hunger, float life, string name)
            {
                this.Age = age;
                this.Hunger = hunger;
                this.Life = life;
                this.Name = name;
            }

            public abstract void Move();
            public abstract void Poop();
            public abstract void Feed();
            
        }

        public abstract class Reptile : Animals
        {
            protected Reptile(int age, float hunger, float life, string name)
            {
                this.Age = age;
                this.Hunger = hunger;
                this.Life = life;
                this.Name = name;
            }

            public abstract void Move();
            public abstract void Poop();
            public abstract void Feed();
        }


    }
}