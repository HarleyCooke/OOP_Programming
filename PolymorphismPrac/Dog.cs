using System;
using System.Security.Policy;
 
 namespace PolymorphismPrac
 {
     public abstract class Dog : Animals.Mammal
     {
         protected Dog(int legs, int age, float hunger, float life, string name) : base(age, hunger, life, name)
         {
             this.Legs = legs;
         }

         private int Legs { get; }
 
         
                 public override void Move()
                 {
                     Console.WriteLine("Run");
                 }
         
                 public override void Poop()
                 {
                     Console.WriteLine("Slip Slop");
                 }
         
                 public override void Feed()
                 {
                     Console.WriteLine("Kibble");
                 }
     }
 }