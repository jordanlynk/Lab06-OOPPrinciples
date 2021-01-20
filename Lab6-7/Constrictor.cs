using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Constrictor : Snakes, ISwimmingly, ICreep
    {
        public override string Color { get; set; }
        public int Speed { get; set; }
        public bool IsCreeping { get; set; }

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
        public string Lurk()
        {
            return "I'm a constrictor, slowly uncoiling.";
        }

        public string Camoflauge()
        {
            return "I'm huge, but unseen";
        }
    }
}
