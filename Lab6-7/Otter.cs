using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Otter : Carnivore, ISwimmingly
    {
        public string WaterType { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public int Speed { get; set; }
        
        //From abstract method in Animal
        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish");
        }
        //From abstract method in Animal
        public override void Play()
        {
            Console.WriteLine("I love playing with rocks");
        }
        //From abstract method in Animal
        public override void Sleep()
        {
            Console.WriteLine("I love to sleep holding hands with my bff");
        }
        //From abstract method in Animal
        public override void Sound()
        {
            Console.WriteLine("I make lil squeaky sounds");
        }
        public string Swim()
        {
            return "I like swimming on my back while holding hands";
        }
    }
}
