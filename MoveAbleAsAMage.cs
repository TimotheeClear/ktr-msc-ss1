using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    interface MoveableAsAMage : Moveable
    {
        void Moveable.moveRight()
        {
            Console.WriteLine(Name + " moves right furtively");
        }

        void Moveable.moveLeft()
        {
            Console.WriteLine(Name + " moves left furtively");
        }

        void Moveable.moveForward()
        {
            Console.WriteLine(Name + " moves forward furtively");
        }

        void Moveable.moveBack()
        {
            Console.WriteLine(Name + " moves back furtively");
        }
    }
}
