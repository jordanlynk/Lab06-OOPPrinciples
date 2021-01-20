using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ISwimmingly
    {
        public int Speed { get; set; }

        public string Splash()
        {
            return "splish splash.. I think you know";
        }
        public string Swim()
        {
            return "Micheal Phelps aint got nothing on me";
        }
    }
}
