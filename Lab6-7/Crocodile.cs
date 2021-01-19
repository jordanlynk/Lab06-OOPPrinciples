using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    class Crocodile : Reptile
    {
        public override string Color { get; set; }
        public override int Age { get; set; }

        public override void Bask()
        {
            Console.WriteLine("Shake and Bask baby");
        }

        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish and everything that comes in my water");
        }

        public override void Sleep()
        {
            Console.WriteLine("I can sleep floating or on land");
        }

        public override void Sound()
        {
            Console.WriteLine("angry noises");
        }
    }
}
