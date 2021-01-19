using System;

namespace Lab6_7
{
    public class Constrictor : Reptile
    {
        public override string Color { get; set; }
        public override int Age { get; set; }

        public override void Bask()
        {
            Console.WriteLine("basking in the sun, having some fun");
        }

        public override void Eat()
        {
            Console.WriteLine("I like to eat everything, mostly?");
        }

        public override void Sleep()
        {
            Console.WriteLine("I'll sssssleep when I'm dead");
        }

        public override void Sound()
        {
            Console.WriteLine("ssssssssssssssssssssss");
        }
    }
}
