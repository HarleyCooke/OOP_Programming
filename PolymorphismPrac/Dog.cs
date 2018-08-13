using System;
using System.Security.Policy;
 
 namespace PolymorphismPrac
 {
     public class Dog : Animals.Mammal
     {
         public Dog(int legs)
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