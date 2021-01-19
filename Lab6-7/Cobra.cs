using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public class Cobra : Reptile
    {
        public override string Color { get; set; }
        public override int Age { get; set; }

        public override void Bask()
        {
            Console.WriteLine("I like bask it up all");
        }

        public override void Eat()
        {
            Console.WriteLine("I like to eat it all");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sssssleep in the dark");
        }

        public override void Sound()
        {
            Console.WriteLine("ssssssssssssssss");
        }
    }
}
