using System;

namespace Bees
{
    class Program
    {
        static void Main(string[] args)
        {
            Bee b1 = new Bee("John", 3.2f);
            Bee b2 = new Bee("Paul", 2.7f);
            Bee b3 = new Bee("George", 1.1f);
            Bee b4 = new Bee("Ringo", 2.0f);

            Bee b5 = new Bee("Kurt", 2.3f);
            Bee b6 = new Bee("Dave", 7.4f);
            Bee b7 = new Bee("Krist", 1.5f);

            Beehive h1 = new Beehive("Memebase", 10);
            Beehive h2 = new Beehive("Best beehive in the world", 10);

            h1.AddBee(b1);
            h1.AddBee(b2);
            h1.AddBee(b3);
            h1.AddBee(b4);

            h2.AddBee(b5);
            h2.AddBee(b6);
            h2.AddBee(b7);

            h1.Report();
            h2.Report();

            Console.WriteLine("Collected {0} mL of honey from beehive: \"{1}\" in 3 days", h1.CollectHoney(3), h1.Name);
            Console.WriteLine("Collected {0} mL of honey from beehive: \"{1}\" in 3 days", h2.CollectHoney(3), h2.Name);
        }
    }
}
