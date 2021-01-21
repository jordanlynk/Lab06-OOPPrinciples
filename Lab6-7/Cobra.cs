using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Cobra : Snakes, ISwimmingly, ICreep
    {
        public override string Color { get; set; }
        public int Speed { get; set; }
        public bool IsCreeping { get; set; }

        //From virtual method in Reptile
        public override void Bask()
        {
            Console.WriteLine("I like bask it up all");
        }
        //From abstract method in Animal
        public override void Eat()
        {
            Console.WriteLine("I like to eat it all");
        }
        //From abstract method in Animal
        public override void Sleep()
        {
            Console.WriteLine("I sssssleep in the dark");
        }
        //From abstract method in Animal
        public override void Sound()
        {
            Console.WriteLine("ssssssssssssssss");
        }
        //From Interface ICreep
        public string Camoflauge()
        {
            return "I blend in like a sssslick mofo";
        }
        //From Interface ICreep
        public string Lurk()
        {
            return "Creeping, lurking in the ssssshadowsss";
        }
        //From Interface ISwimmingly
        public string Swim()
        {
            return "I usually don't swwwwim unless it's a hot day";
        }
     }
}
