﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            var farm = new Farm<Animal>();
            farm.Animals.Add(new Cow("Rual"));
            farm.Animals.Add(new Chicken("Donna"));
            farm.Animals.Add(new Chicken("Mary"));
            farm.Animals.Add(new SuperCow("Ben"));
            farm.MakeNoises();
            Farm<Cow> dairyFarm = farm.GetCows();
            dairyFarm.FeedTheAnimals();
            foreach (var cow in dairyFarm)
            {
                (cow as SuperCow)?.Fly();
            }
            Console.ReadKey();
        }
    }
}
