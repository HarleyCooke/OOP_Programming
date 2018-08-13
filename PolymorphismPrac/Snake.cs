using System;
using System.Security.Policy;
 
namespace PolymorphismPrac
{
    public class Sanke : Animals.Reptile
    {
        public Sanke(int legs)
        {
            Legs = legs;
        }

        private int Legs { get; }
 
         
        public override void Move()
        {
            Console.WriteLine("Slither");
        }
         
        public override void Poop()
        {
            Console.WriteLine("Does it Really");
        }
         
        public override void Feed()
        {
            Console.WriteLine("Rats");
        }
    }
}