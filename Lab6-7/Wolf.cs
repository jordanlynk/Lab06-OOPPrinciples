using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Wolf : Carnivore, ISwimmingly
    {
        public string TypeOf { get; set; }
        public int Speed { get; set; }
        public override bool Hibernates { get; set; }


        //From abstract method in Animal
        public override void Eat() => Console.WriteLine("Woah, is this deer gourmet?");
        //From abstract method in Animal
        public override void Sleep() => Console.WriteLine("I love to nap in the sun");
        //From abstract method in Animal
        public override void Sound() => Console.WriteLine("Howling at the moooooon");

        public string Swim()
        {
            return "Me and my wolf boys like to take a swim to show the ladies how its done";
        }
    }
}
