using System;
using System.Security.Policy;

namespace PolymorphismPrac
{
    public abstract class Cat : Animals.Mammal
    {
        public int Legs = 4;
        
        protected Cat(int legs, float life, int age, string name, float hunger) :base(age, hunger, life, name)
        {
            this.Legs = legs;
        }
        
                public override void Move()
                {
                    Console.WriteLine("Stroll");
                }
                
                public override void Poop()
                {
                    Console.WriteLine("Slide");
                }
                
                public override void Feed()
                {
                    Console.WriteLine("Milk");
                }
    }
}