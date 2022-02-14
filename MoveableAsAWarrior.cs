using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    interface MoveableAsAWarrior : Moveable
    {
        void Moveable.moveRight()
        {
            Console.WriteLine(Name + " moves right like a bad boy");
        }

        void Moveable.moveLeft()
        {
            Console.WriteLine(Name + " moves left like a bad boy");
        }

        void Moveable.moveForward()
        {
            Console.WriteLine(Name + " moves forward like a bad boy");
        }

        void Moveable.moveBack()
        {
            Console.WriteLine(Name + " moves back like a bad boy");
        }
    }
}
