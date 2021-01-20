using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class RedPanda : Mammal, ISwimmingly
    {
        public override string Color { get; set; }        
        public int Speed { get; set; }
        //From abstract method in Animal
        public override void Eat()
        {
            Console.WriteLine("I am a violent creature and eat small lizards");
        }
     
        public override void Play()
        {
            Console.WriteLine("I love to play with my other red panda friends");
        }
        //From abstract method in Animal
        public override void Sleep()
        {
            Console.WriteLine("I am a lazy s-o-b and love napping");
        }
        //From abstract method in Animal
        public override void Sound()
        {
            Console.WriteLine("eeeeeeeeeeeeeeeek");
        }
        public string Swim()
        {
            return "Ooh, just a small kids pool will do for me.";
        }
    }
}
