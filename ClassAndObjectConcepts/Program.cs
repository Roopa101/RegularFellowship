using OOPsConcepts.ClassAndObjectConcepts;
using System;

namespace OOPsConcepts
{
    class Program
    {
       public static void Main(string[] args)
        {
            Car swift = new Car();
            swift.color = "Black";
            Console.WriteLine("swift color = " + swift.color);
            Car maruthi = new Car();
            maruthi.color = "pink";
            Console.WriteLine("maruthi color = " + maruthi.color);
            Console.ReadKey();
        }

    }
}
