using System;

namespace Weapons
{
    public abstract class Weapon
    {
        public Weapon(int baseDamage, int baseRange, int actionPoint, int critDamge)
        {
            BaseDamage = baseDamage;
            BaseRange = baseRange;
            ActionPoint = actionPoint;
            CritDamge = critDamge;
           
        }
        

       
        public int BaseDamage { get; set; }
        public int BaseRange { get; set; }
        public int ActionPoint { get; set; }
        public int CritDamge { get; set; }

        public abstract int poke();
        
        public abstract int attack();

    }



    public class Melee : Weapon
         {
             public string WepType { get; set; }
             
             public Melee(string wepType, int baseDamage, int baseRange, int actionPoint, int critDamge) : base(baseDamage, baseRange, actionPoint, critDamge)
             {
                 BaseDamage = baseDamage;
                 BaseRange = baseRange;
                 ActionPoint = actionPoint;
                 CritDamge = critDamge;
                 WepType = wepType;
             }

             public override int poke()
             {
                 return 1;
             }

             public override int attack()
             {
                 return BaseDamage;
             }

             public void Info()
             {
                 Console.WriteLine("The " + WepType + Environment.NewLine + 
                                   "Damage " + BaseDamage + Environment.NewLine +
                                   "Range " + BaseRange + Environment.NewLine +
                                   "Action Cost " + ActionPoint + Environment.NewLine );
             }
         }
    
    public class Ranged : Weapon
        {
            public string WepType { get; set; }
            
            public Ranged(string wepType, int baseDamage, int baseRange, int actionPoint, int critDamge) : base(baseDamage, baseRange, actionPoint, critDamge)
            {
                BaseDamage = baseDamage;
                BaseRange = baseRange;
                ActionPoint = actionPoint;
                CritDamge = critDamge;
                WepType = wepType;
                
            }

            public override int poke()
            {
                return 1;
            }

            public override int attack()
            {
                return BaseDamage;
            }
            
            public void Info()
            {
                Console.WriteLine("The " + WepType + Environment.NewLine + 
                                  "Damage " + BaseDamage + Environment.NewLine +
                                  "Range " + BaseRange + Environment.NewLine +
                                  "Action Cost " + ActionPoint + Environment.NewLine );
            }
        }    
    
}   
