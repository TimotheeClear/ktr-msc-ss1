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
            /*            Character perso2 = new Mage("Merlin");
                        Character perso1 = new Warrior("Arthure");

                        perso1.Attack("sword");
                        perso2.Attack("magic");*/

            //STEP 04
            /*            Moveable perso2 = new Mage("Merlin");
                        Moveable perso1 = new Warrior("Arthure");

                        perso2.moveLeft();
                        perso2.moveRight();
                        perso2.moveForward();
                        perso2.moveBack();
                        perso1.moveLeft();
                        perso1.moveRight();
                        perso1.moveForward();
                        perso1.moveBack();
    */
            //STEP 05
            Character perso = new Warrior("Merlin");
            perso.Unsheathe();
        }
    }
}
