using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public abstract class Snakes : Reptile
    {
        public string Length { get; set; }
        public bool Poisonous { get; set; }


        public void Bite()
        {
            Console.WriteLine("Giving it all my might, for this bite");
        }
        public void CoilUp()
        {
            Console.WriteLine("Don't look at me.. you're make me coil up");
        }
    }
}
