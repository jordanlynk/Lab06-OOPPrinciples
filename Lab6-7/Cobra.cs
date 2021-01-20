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

        public override void Bask()
        {
            Console.WriteLine("I like bask it up all");
        }

        public override void Eat()
        {
            Console.WriteLine("I like to eat it all");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sssssleep in the dark");
        }

        public override void Sound()
        {
            Console.WriteLine("ssssssssssssssss");
        }

        public string Camoflauge()
        {
            return "I blend in like a sssslick mofo";
        }

        public string Lurk()
        {
            return "Creeping, lurking in the ssssshadowsss";
        }
    }
}
