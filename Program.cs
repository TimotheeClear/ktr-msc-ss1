using System;

namespace ktr_msc_ss1
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 01
/*            Character perso = new Character("Timothée");
            Console.WriteLine(perso.Name);
            Console.WriteLine(perso.Life);
            Console.WriteLine(perso.Agility);
            Console.WriteLine(perso.Strength);
            Console.WriteLine(perso.Wit);
            Console.WriteLine(perso.RpgClass);
            perso.Attack("my weapon");*/

            //STEP 02
            Character perso2 = new Mage("Merlin");
            Character perso1 = new Warrior("Arthure");

            perso1.Attack("sword");
            perso2.Attack("magic");
        }
    }
}
