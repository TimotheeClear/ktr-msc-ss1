using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    class Warrior : Character, MoveableAsAWarrior
    {
        private const string RPGCLASS = "Warrior";
        private List<string> weapons = new List<string> { "sword", "hammer" };

        public Warrior(string name, int life = 100, int agility = 8, int strength = 10, int wit = 3) : base(name, life, agility, strength, wit) 
        {
            onCreate();
        }

        public void onCreate()
        {
            Console.WriteLine(Name + ": May the gods be with me.");
        }

        public override void Attack(String weapon)
        {
            if (weapons.Contains(weapon))
            {
                base.Attack(weapon);
                Console.WriteLine(Name + ": I'll crush you with my " + weapon + "!");
            }
        }

        public override string RpgClass
        {
            get
            {
                return RPGCLASS;
            }
        }
    }
}
