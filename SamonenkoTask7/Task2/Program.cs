using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Deer());
            animals.Add(new Hare());
            animals.Add(new Wolf());
            animals.Add(new Fox());
            animals.Add(new Carnivore());
            Console.WriteLine(CountDeer(animals));
        }

        static int CountCarnivore(List<Animal> animals)
        {
            int count = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals.ElementAt(i) is Carnivore)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountHerbivore(List<Animal> animals)
        {
            int count = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals.ElementAt(i) is Herbivore)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountDeer(List<Animal> animals)
        {
            int count = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals.ElementAt(i) is Deer)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountHare(List<Animal> animals)
        {
            int count = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals.ElementAt(i) is Hare)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountWolf(List<Animal> animals)
        {
            int count = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals.ElementAt(i) is Wolf)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountFox(List<Animal> animals)
        {
            int count = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals.ElementAt(i) is Fox)
                {
                    count++;
                }
            }
            return count;
        }
    }
}