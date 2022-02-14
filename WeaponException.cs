using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    public class WeaponException : Exception
    {
        string Name { get; }
     
        public void noWeapon()
        {
            Console.WriteLine(Name + "  I refuse to fight with my bare hands .");
        }

        public void wrongWeaponWarrior(string weapon)
        {
            Console.WriteLine(Name + " A " + weapon + " I refuse to fight with my bare hands.");
        }

        public void wrongWeaponMage(string weapon)
        {
            Console.WriteLine(Name + " I don 't need this stupid " + weapon + "! Don 't misjudge my powers !");
        }
    }
}
