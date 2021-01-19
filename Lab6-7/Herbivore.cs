using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public abstract class Herbivore : Mammal
    {
        public string typeOfPlantsConsumed { get; set; }
        public string size { get; set; }

        public abstract void Graze();
    }
}
