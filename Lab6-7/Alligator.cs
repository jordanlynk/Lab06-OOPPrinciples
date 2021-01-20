using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Alligator : Crocodilia, ISwimmingly, ICreep
    {
        public override string Color { get; set; }
        public override int AverageEggsLaid { get; set; }
        public int Speed { get; set; }
        public bool IsCreeping { get; set; }

        public override void Bask()
        {
            Console.WriteLine("basking on my tummy and all");
        }

        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish and birbs");
        }

        public override void Sleep()
        {
            Console.WriteLine("sleeping on land, man");
        }

        public override void Sound()
        {
            Console.WriteLine("angry, violent noises");
        }

        public string Camoflauge()
        {
            return "I can hide in the water just as good as a stick";
        }

        public string Lurk()
        {
            return "Lurking...creeping in the shadows";
        }
    }
}
