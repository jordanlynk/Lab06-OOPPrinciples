using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Crocodile : Crocodilia, ISwimmingly, ICreep
    {
        public override string Color { get; set; }        
        public override int AverageEggsLaid { get; set; }
        public int Speed { get; set; }
        public bool IsCreeping { get; set; }

        public override void Bask()
        {
            Console.WriteLine("Shake and Bask baby");
        }

        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish and everything that comes in my water");
        }

        public override void Sleep()
        {
            Console.WriteLine("I can sleep floating or on land");
        }

        public override void Sound()
        {
            Console.WriteLine("angry noises");
        }
        public string Lurk()
        {
            return "I'm a croc, and I creep.";
        }

        public string Camoflauge()
        {
            return "Can't see me, but I see you";
        }
    }
}
