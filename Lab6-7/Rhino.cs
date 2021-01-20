using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_7
{
    public class Rhino : Herbivore
    {
        public override string Color { get; set; }
        public override int Age { get; set; }
        //From abstract method in Animal
        public override void Eat()
        {
            Console.WriteLine("I love eating shrubs, leaves, who doesn't?");
        }
        //Overrided from Herbivore
        public override void Graze()
        {
            Console.WriteLine("I graze on shrubbery");
        }

        public override void Play()
        {
            Console.WriteLine("I love to play in the dirt");
        }
        //From abstract method in Animal
        public override void Sleep()
        {
            Console.WriteLine("I can only sleep when I know there aren't any fires");
        }
        //From abstract method in Animal
        public override void Sound()
        {
            Console.WriteLine("I sound like a giant bullhorn, maybe?");
        }
        public string Swim()
        {
            return "I like swimming, although people mistake my horn for a fin..";
        }
    }
}
