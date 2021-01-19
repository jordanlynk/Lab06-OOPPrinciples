using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public class Rhino : Herbivore
    {
        public override string Color { get; set; }
        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I love eating shrubs, leaves, who doesn't?");
        }

        public override void Graze()
        {
            Console.WriteLine("I graze on shrubbery");
        }

        public override void Play()
        {
            Console.WriteLine("I love to play in the dirt");
        }

        public override void Sleep()
        {
            Console.WriteLine("I can only sleep when I know there aren't any fires");
        }

        public override void Sound()
        {
            Console.WriteLine("I sound like a giant bullhorn, maybe?");
        }
    }
}
