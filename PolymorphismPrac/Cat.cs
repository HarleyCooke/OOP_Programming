using System;
using System.Security.Policy;

namespace PolymorphismPrac
{
    public class Cat : Animals.Mammal
    {
        public Cat(int legs)
        {
            Legs = legs;
        }

        private int Legs { get; }
        
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