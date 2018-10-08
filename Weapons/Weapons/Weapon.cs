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


        public abstract string Info();


    }



    public class Melee : Weapon, IActionPoint, IDamage, IPoke
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

             public override string Info()
             {
                 return "The " + WepType + Environment.NewLine +
                        "Damage " + BaseDamage + Environment.NewLine +
                        "Range " + BaseRange + Environment.NewLine +
                        "Action Cost " + ActionPoint + Environment.NewLine;
             }

             public int Action()
             {
                 return ActionPoint--;
             }

             public int Damage()
             {
                 return BaseDamage;
             }

             public int Poke()
             {
                 return -1;
             }
         }
    
    public class Ranged : Weapon, IActionPoint, IDamage, IPoke
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
            
            public override string Info()
            {
                return "The " + WepType + Environment.NewLine +
                       "Damage " + BaseDamage + Environment.NewLine +
                       "Range " + BaseRange + Environment.NewLine +
                       "Action Cost " + ActionPoint + Environment.NewLine;
            }

            public int Action()
            {
                return ActionPoint -2;
            }

            public int Damage()
            {
                return BaseDamage;
            }

            public int Poke()
            {
                return -1;
            }
        }    
    
}   
