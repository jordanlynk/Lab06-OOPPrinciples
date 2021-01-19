using System;

namespace Lab6_7
{
    public abstract class Crocodillia : Reptile
    {
        public string Size { get; set; }
        public string Snout { get; set; }
        public string TeethVisible { get; set; }
        public abstract int averageEggsLaid { get; set; }
        public bool buildNestOverGround { get; set; }

        public void Attack()
        {
            Console.WriteLine("Got you in my teeth now!");
        }

    }
}
