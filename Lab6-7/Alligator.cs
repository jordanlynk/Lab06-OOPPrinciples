using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Alligator : Crocodilia, ISwimmingly, ICreep
    {
        public override string Color { get; set; }
        //From abstract method in Crocodillia
        public override int AverageEggsLaid { get; set; }
        public int Speed { get; set; }
        public bool IsCreeping { get; set; }

        //From virtual method in Reptile
        public override void Bask()
        {
            Console.WriteLine("basking on my tummy and all");
        }

        ///From abstract method in Animal
        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish and birbs");
        }
        //From abstract method in Animal
        public override void Sleep()
        {
            Console.WriteLine("sleeping on land, man");
        }
        //From abstract method in Animal
        public override void Sound()
        {
            Console.WriteLine("angry, violent noises");
        }
        //From Interface ICreep
        public string Camoflauge()
        {
            return "I can hide in the water just as good as a stick";
        }
        //From Interface ICreep
        public string Lurk()
        {
            return "Lurking...creeping in the shadows";
        }
        //From Interface ISwimmingly
        public string Swim()
        {
            return "I do myself a favor and go for a little swim.";
        }
    }
}
