using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public class Alligator : Reptile
    {
        public override string Color { get; set; }
        public override int Age { get; set; }

        public override void Bask()
        {
            Console.WriteLine("basking on my tummy and all");
        }

        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish and birbs");
        }

        public override void Sleep()
        {
            Console.WriteLine("sleeping on land, man");
        }

        public override void Sound()
        {
            Console.WriteLine("angry, violent noises");
        }
    }
}
