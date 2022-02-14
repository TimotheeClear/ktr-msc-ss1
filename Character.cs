using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    abstract class Character : Moveable
    {
        private const string RPGCLASS = "Character";

        private string name;
        private int life;
        private int agility;
        private int strength;
        private int wit;

        public Character(string name, int life = 50, int agility = 2, int strength = 2, int wit = 2)
        {
            this.name = name;
            this.life = life;
            this.agility = agility;
            this.strength = strength;
            this.wit = wit;
        }

        public void Unsheathe()
        {
            Console.WriteLine(Name + " unsheathes his weapon .");
        }

        public virtual void Attack(string weapon)
        {
            Console.WriteLine(Name + ": Rrrrrrrrr ....");
        }


        public virtual string RpgClass
        {
            get
            {
                return RPGCLASS;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }

            set
            {
                life = value;
            }
        }

        public int Agility
        {
            get
            {
                return agility;
            }

            set
            {
                agility = value;
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public int Wit
        {
            get
            {
                return wit;
            }

            set
            {
                wit = value;
            }
        }
    }
}
