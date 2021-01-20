﻿using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Wolf : Carnivore, ISwimmingly
    {
        public string TypeOf { get; set; }
        public int Speed { get; set; }

        public override void Eat() => Console.WriteLine("Woah, is this deer gourmet?");
        public override void Sleep() => Console.WriteLine("I love to nap in the sun");
        public override void Sound() => Console.WriteLine("Howling at the moooooon");
    }
}
