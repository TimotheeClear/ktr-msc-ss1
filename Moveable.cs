using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    interface Moveable
    {
        string Name { get; }

        void moveRight()
        {
            Console.WriteLine(Name + " moves right");
        }

        void moveLeft()
        {
            Console.WriteLine(Name + " moves left");
        }

        void moveForward()
        {
            Console.WriteLine(Name + " moves forward");
        }

        void moveBack()
        {
            Console.WriteLine(Name + " moves back");
        }
    }
}
