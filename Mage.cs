using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    class Mage : Character
    {
        private const string RPGCLASS = "Mage";
        private List<string> weapons = new List<string> { "magic", "wand" };

        public Mage(string name, int life = 70, int agility = 10, int strength = 3, int wit = 10) : base(name, life, agility, strength, wit)
        {
            onCreate();
        }

        public void onCreate()
        {
            Console.WriteLine(Name + ":  My name will go down in history !");
        }

        public override void Attack(String weapon)
        {
            if (weapons.Contains(weapon))
            {
                base.Attack(weapon);
                Console.WriteLine(Name + ": Feel the power of my " + weapon + "!");
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
