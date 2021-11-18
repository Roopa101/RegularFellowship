using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    class Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
            Console.ReadLine();
        }
    }

}
