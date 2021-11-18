using System;
using System.Collections.Generic;
using System.Text;

namespace OOpsAbstraction
{
    abstract class Animal
    {

        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

}
