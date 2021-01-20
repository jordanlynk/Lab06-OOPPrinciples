using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Crocodile : Crocodilia, ISwimmingly, ICreep
    {
        public override string Color { get; set; }
        //From abstract method in Crocodillia
        public override int AverageEggsLaid { get; set; }
        public int Speed { get; set; }
        public bool IsCreeping { get; set; }

        //From virtual method in Reptile
        public override void Bask()
        {
            Console.WriteLine("Shake and Bask baby");
        }

        //From abstract method in Animal
        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish and everything that comes in my water");
        }
        //From abstract method in Animal
        public override void Sleep()
        {
            Console.WriteLine("I can sleep floating or on land");
        }
        //From abstract method in Animal
        public override void Sound()
        {
            Console.WriteLine("angry noises");
        }
        //From Interface ICreep
        public string Lurk()
        {
            return "I'm a croc, and I creep.";
        }
        //From Interface ICreep
        public string Camoflauge()
        {
            return "Can't see me, but I see you";
        }
        //From Interface ISwimming
        public string Swim()
        {
            return "Aren't I always?";
        }
    }
}
