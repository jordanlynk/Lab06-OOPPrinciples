using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public abstract class Crocodilia : Reptile
    {
        public string Size { get; set; }
        public string Snout { get; set; }
        public string TeethVisible { get; set; }
        public abstract int AverageEggsLaid { get; set; }
        public bool BuildNest { get; set; }


        public void Attack()
        {
            Console.WriteLine("I attack and then I snack");
        }
    }
}
