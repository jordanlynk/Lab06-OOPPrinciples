using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public class RedPanda : Mammal
    {
        public override string Color { get; set; }
        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I am a violent creature and eat small lizards");
        }

        public override void Play()
        {
            Console.WriteLine("I love to play with my other red panda friends");
        }

        public override void Sleep()
        {
            Console.WriteLine("I am a lazy s-o-b and love napping");
        }

        public override void Sound()
        {
            Console.WriteLine("eeeeeeeeeeeeeeeek");
        }
    }
}
