using System.Collections;
using System.Collections.Generic;

namespace Ch12Ex04
{
    public class Farm<T> : IEnumerable<T> where T : Animal
    {
        private List<T> animals = new List<T>();

        public List<T> Animals => animals;

        public IEnumerator<T> GetEnumerator() => animals.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => animals.GetEnumerator();

        public void MakeNoises()
        {
            foreach (var animal in animals)
            {
                animal.MakeNoise();
            }
        }

        public void FeedTheAnimals()
        {
            foreach (var animal in animals)
            {
                animal.Feed();
            }
        }

        public Farm<Cow> GetCows()
        {
            var cowFarm = new Farm<Cow>();
            foreach (var animal in animals)
            {
                if (animal is Cow)
                {
                    cowFarm.Animals.Add(animal as Cow);
                }
            }
            return cowFarm;
        }
    }
}
