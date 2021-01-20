using System;
using System.Collections.Generic;
using System.Text;


namespace Lab6_7
{
    /// <summary>
    /// Abstracted class derived from abstracted animal class
    /// </summary>
    public abstract class Reptile : Animal
    {
        public int numEggs { get; set; } = 10;
        public int numTeeth { get; set; }
        public string scalePattern { get; set; }
        public bool livesInWater { get; set; }

        public virtual void Bask()
        {
            Console.WriteLine("Just chilling in the sun..ya");
        }
    }
}
