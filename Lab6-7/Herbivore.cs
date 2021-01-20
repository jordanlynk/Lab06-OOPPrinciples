using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    /// <summary>
    /// Abstract class derived from abstract mammal class
    /// </summary>
    public abstract class Herbivore : Mammal
    {
        public string TypeOfPlantsConsumed { get; set; }
        public string Size { get; set; }

        public abstract void Graze();
    }
}
