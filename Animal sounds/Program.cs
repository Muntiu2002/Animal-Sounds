using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>
            {
                new Dog(),
                new Cat(),
                new Cow(),
                new Horse(),
                new Chicken(),
                new Elephant(),
                new Snake(),
                new Sheep()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetTypeName()} makes sound: {animal.MakeSound()}");
            }
        }
    }
}
