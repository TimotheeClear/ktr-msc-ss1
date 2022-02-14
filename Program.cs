using System;

namespace ktr_msc_ss1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character perso = new Character("Timothée");
            Console.WriteLine(perso.Name);
            Console.WriteLine(perso.Life);
            Console.WriteLine(perso.Agility);
            Console.WriteLine(perso.Strength);
            Console.WriteLine(perso.Wit);
            Console.WriteLine(perso.RpgClass);
            perso.Attack("my weapon");
        }
    }
}
