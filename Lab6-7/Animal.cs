using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    /// <summary>
    /// Base Abstract Class
    /// </summary>
    public abstract class Animal
    {
        public bool IsBreathing { get; set; }
        public virtual string Color { get; set; }
        public virtual int Age { get; set; } = 5;
        public int NumberOfLegs { get; set; }
        public bool Nocturnal { get; set; }

        // Setting up our methods here 
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Sound();


        public Animal()
        {
            IsBreathing = false;
        }

    }
}
