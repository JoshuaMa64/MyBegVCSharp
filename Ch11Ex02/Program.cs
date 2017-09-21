using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch11Ex01;

namespace Ch11Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalcollection = new Animals();
            animalcollection.Add(new Cow("Donna"));
            animalcollection.Add(new Chicken("Kevin"));
            foreach (Animal myAnimal in animalcollection)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();
        }
    }
}
