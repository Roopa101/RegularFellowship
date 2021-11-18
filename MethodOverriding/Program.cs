using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
           

            myAnimal.animalSound();
            myPig.animalSound();
          
        }

    }
}