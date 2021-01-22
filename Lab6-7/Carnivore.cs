using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    /// <summary>
    /// Abstracted class derived from the abstracted animal class
    /// </summary>
    public abstract class Carnivore : Mammal
    {
        public abstract bool Hibernates { get; set; }
        /// <summary>
        /// Play overrides virtual play from class, Mammals
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("dancing with my prey");
        }
        public void Hunt()
        {
            Console.WriteLine("Hmm.. what's for dinner?");
        }
    }
}
