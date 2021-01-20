using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Lab6_7
{
    public class Constrictor : Snakes, ISwimmingly, ICreep
    {
        public override string Color { get; set; }
        public int Speed { get; set; }
        public bool IsCreeping { get; set; }

        //From virtual method in Reptile
        public override void Bask()
        {
            Console.WriteLine("basking in the sun, having some fun");
        }
        //From abstract method in Animal
        public override void Eat()
        {
            Console.WriteLine("I like to eat everything, mostly?");
        }
        //From abstract method in Animal
        public override void Sleep()
        {
            Console.WriteLine("I'll sssssleep when I'm dead");
        }
        //From abstract method in Animal
        public override void Sound()
        {
            Console.WriteLine("ssssssssssssssssssssss");
        }
        //From Interface ICreep
        public string Lurk()
        {
            return "I'm a constrictor, slowly uncoiling.";
        }
        //From Interface ICreep
        public string Camoflauge()
        {
            return "I'm huge, but unseen";
        }
        //From Interface ISwimmingly
        public string Swim()
        {
            return "Taking a dip in the river, who knowsss";
        }
    }
}
