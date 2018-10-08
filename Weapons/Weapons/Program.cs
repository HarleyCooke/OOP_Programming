using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;


namespace Weapons
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Weapon> Weapons = new List<Weapon>();
            Weapons.AddRange(new Weapon[]
            {
                new Melee("Rusty LongSword",35, 2, 1, 70),
                new Melee("Vensul's Dagger", 15, 1, 1, 30),
                new Ranged("Airsoft Bow", 5, 8, 2, 10),
                new Ranged("CrossBow of Jello", 9, 9, 2, 18),
                new Melee("Rusty Blunt Knife", 11, 1, 1, 22) 
                
            });



            Player P1 = new Player();
            
            AI A1 = new AI();

            var menuNum = 0;
            var atkNum = 0;
            
            void Ai()
            {
                Random rnd = new Random();    
                int a = rnd.Next(3);

                if (a == 0)
                {
                    Console.WriteLine("AI attacked");
                
                    Random rndo = new Random();    
                    int b = rndo.Next(1);

                    if (b == 0 && 2 <= P1.Postion)
                    {
                        Console.WriteLine(Environment.NewLine + "With a Melee Weapon");
                        P1.Health -= 25;

                    } if (b == 1 && 8 <= P1.Postion)
                    {
                        Console.WriteLine(Environment.NewLine + "With a Ranged Weapon");
                        P1.Health -= 8;

                    }
                    else
                    {
                        Console.WriteLine(Environment.NewLine + "AI missed wasn't within Range! " + Environment.NewLine);
                    }
                }

                if (a == 1)
                {
                    A1.Move();
                    Console.WriteLine("AI is now in Position  " + A1.Postion);
                }

                if (a == 2)
                {
                    A1.Block();
                    Console.WriteLine("AI has blacked Half the incoming damage!");
                }

                if (a == 3 && 2 <= P1.Postion)
                {
                    Console.WriteLine("AI has Poked you for 1 damage!");
                    P1.Health -= 1;
                }
            }
            
            
            Console.WriteLine("Welcome to a Shitty Game" + Environment.NewLine +
                              "Please State Your Name: " + Environment.NewLine);
            
            P1.Name = Console.ReadLine();

            Console.WriteLine(Environment.NewLine + "Ok then " + P1.Name + " Whats is the name of your Foe! " + Environment.NewLine);

            A1.Name = Console.ReadLine();
            
            Console.WriteLine(Environment.NewLine + "Now that's out of the way ");
            
            Console.ReadLine();  Console.WriteLine("That person you just gave a name to, well you have too kill them...");
            Console.ReadLine();
            
            Console.WriteLine(Environment.NewLine + "Ok these are your randomly selected weapons of choice! " + Environment.NewLine);
            Console.ReadLine();
            
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                
                int r = rnd.Next(Weapons.Count);
                
                Console.Write(Weapons[r].Info());
               
                Console.ReadLine();
                
            }
            
            Console.WriteLine(Environment.NewLine + "Take Note of your weapon attributes! are you ready " + Environment.NewLine);
          
            while (P1.Health != 0)
            {
                Console.WriteLine("1: Move Forward " + Environment.NewLine +
                                  "2: Block " + Environment.NewLine +
                                  "3: Attack " + Environment.NewLine + 
                                  "4: Poke " + Environment.NewLine);
                
                menuNum = Int32.Parse(Console.ReadLine());

                if (menuNum == 1)
                {
                    P1.Move();
                    Console.WriteLine("You are now in Position  " + P1.Postion + Environment.NewLine);
                    Console.WriteLine("ActionPoints:  " + P1.ActionPoint + Environment.NewLine);
                    Ai();
                    
                    

                }   if (menuNum == 2)
                        {
                            P1.Block();
                            Console.WriteLine("You Have Blocked Half the incoming damage!");
                            Ai();
                        }

                if (menuNum == 3)
                {
                    Console.WriteLine("1: Melee Attack.." + Environment.NewLine +
                                      "2: Ranged Attack..");
                    
                    atkNum = Int32.Parse(Console.ReadLine());

                    if (atkNum == 1)
                    {
                        
                    }
                }
                

            }
            
            Console.WriteLine("You Died");
        }

    }
    
}