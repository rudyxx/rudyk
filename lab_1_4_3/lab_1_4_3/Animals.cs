using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_3
{
    //6) implement interface IEnumerable
    public class Animals : IEnumerable
    {
        // 7) declare private array of Animal
        public Animal[] animal; 

        // 8) declare parameter constructor to initialize array   
        public Animals(Animal[] animAr)
        {
            animal = new Animal[animAr.Length];
            for (int i = 0; i < animAr.Length; i++)
            {
                animal[i] = animAr[i];
            }
        }

        // 9) implement method GetEnumerator(), which returns IEnumerator
        // use foreach on array of Animal
        // and yield return for every animal
        public IEnumerator GetEnumerator()
        {
            foreach (Animal item in animal)
            {
                yield return item;
            }
        }

    }
}
