using System;
using System.Security.Policy;
 
namespace PolymorphismPrac
{
    public abstract class Sanke : Animals.Reptile
    {

        protected Sanke(int age, float hunger, float life, string name, int legs) : base(age, hunger, life, name)
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