﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public class Otter : Carnivore
    {
        public string waterType { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I love snacking on fish");
        }
        public override void Play()
        {
            Console.WriteLine("I love playing with rocks");
        }

        public override void Sleep()
        {
            Console.WriteLine("I love to sleep holding hands with my bff");
        }

        public override void Sound()
        {
            Console.WriteLine("I make lil squeaky sounds");
        }
    }
}