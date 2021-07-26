using System;
using System.Collections.Generic;

namespace Bees
{
    public class Beehive
    {
        public List<Bee> Bees { get; set; }
        public int MaxBees { get; set; }
        public string Name { get; set; }

        public Beehive(string name, int maxBees)
        {
            this.Name = name;
            this.MaxBees = maxBees;
            this.Bees = new List<Bee>();
        }
        public void AddBee(Bee bee)
        {
            if (Bees.Count < MaxBees)
            {
                this.Bees.Add(bee);
            }
        }
        public float CollectHoney(int days)
        {
            if (Bees.Count > 0)
            {
                float size = 0f;
                foreach (var bee in Bees)
                {
                    size += bee.Size;
                }
                return days * size * 0.2f;
            }
            else
            {
                Console.WriteLine("No honey produced because there are no bees in this hive");
                return 0f;
            }
        }
        public void Report()
        {
            Console.WriteLine("Beehive: \"{0}\" has {1} bees in it", this.Name, this.Bees.Count);
        }
    }
}