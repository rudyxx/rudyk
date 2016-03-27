using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) Create an array of Animal objects and object of Animals    
            // print animals with foreach operator for object of Animals 
            Animal[] animalities = new Animal[3] { new Animal("mamals", 100), new Animal("fish", 1), new Animal("birds", 10) };
            Animals animals1 = new Animals(animalities);
            
            foreach (Animal item in animals1.animal)
            {
                Console.WriteLine("Genus - {0}, Weight - {1}", item.Genus, item.Weight);
            }
            // 11) Invoke 3 types of sorting 
            // and print results with foreach operator for array of Animal objects  

            Console.WriteLine("\n     sorted by standart Array.Sort:");
            Array.Sort(animalities);
            foreach (Animal item in animalities)
            {
                Console.WriteLine("Genus - {0}, Weight - {1}", item.Genus, item.Weight);
            }

            Console.WriteLine("\n     sorted by Weight:");
            Array.Sort(animals1.animal, Animal.SortWeightAscending);
            foreach (Animal item in animals1.animal)
            {
                Console.WriteLine("Genus - {0}, Weight - {1}", item.Genus, item.Weight);
            }

            Console.WriteLine("\n    sorted by Genus:");
            Array.Sort(animals1.animal, Animal.SortGenusDescending);
            foreach (Animal item in animals1.animal)
            {
                Console.WriteLine("Genus - {0}, Weight - {1}", item.Genus, item.Weight);
            }

            
            Console.ReadLine();
        }
    }
}
