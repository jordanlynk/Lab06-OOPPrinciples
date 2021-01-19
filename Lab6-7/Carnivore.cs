using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public abstract class Carnivore : Mammal
    {
        public bool Hibernates { get; set; }

        public void Hunt()
        {
            Console.WriteLine("Hmm.. what's for dinner?");
        }
    }
}
