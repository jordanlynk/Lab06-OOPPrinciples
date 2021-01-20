using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    /// <summary>
    /// Abstract derived from Animal
    /// </summary>
    public abstract class Mammal : Animal
    {
        public string TypeOfFur { get; set; } = "Smooth";
        

        public string Scratch()
        {
            string output = "Feels so good! Mammals love to be scratched";
            Console.WriteLine(output);
            return output;
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
