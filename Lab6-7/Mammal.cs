using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public abstract class Mammal : Animal
    {
        public string typeOfFur { get; set; }
        public bool nocturnal { get; set; }

        public void Scratch()
        {
            Console.WriteLine("Feels so good! Mammals love to be scratched");
        }
        public void Roll()
        {
            Console.WriteLine("Rolling around, making some fun");
        }
        public virtual void Play()
        {
            Console.WriteLine("Playing in the sun, soaking up the fun..something like that");
        }
    }
}
