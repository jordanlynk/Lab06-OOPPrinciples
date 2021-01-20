using System;
using Xunit;
using Lab6_7;

namespace AnimalTesting
{
    public class UnitTest1
    {
        
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Wolf()
        {
            Wolf wolf = new Wolf();
          

            //Inherited from Animal
            Assert.Equal(5, wolf.Age);
            //Inherited from Animal
            Assert.False(wolf.IsBreathing);
        }
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_RedPanda()
        {
           
            RedPanda booboo = new RedPanda();
            //Inherited from Animal
            Assert.Equal(5, booboo.Age);
            //Inherited from Animal
            Assert.False(booboo.IsBreathing);
        }
        
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Otter()
        {
            Otter gladius = new Otter();

            //Inherited from Mammal
            Assert.Equal("Smooth", gladius.TypeOfFur);
            //Inherited from Mammal
            Assert.Equal("Feels so good! Mammals love to be scratched", gladius.Scratch());

        }
        
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Rhino()
        {
            Rhino turkey = new Rhino();

            //Inherited From  Mammals
            Assert.Equal("Smooth", turkey.TypeOfFur);
            //Inherited From Mammals
            Assert.Equal("Feels so good! Mammals love to be scratched", turkey.Scratch());

        }
        
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Alligator()
        {
            Alligator crocky = new Alligator();

            // Inherited From Reptiles
            Assert.Equal(10, crocky.numEggs);
            //Inherited from Animals
            Assert.Equal(5, crocky.Age);

        }
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Crocodile()
        {
            Crocodile ally = new Crocodile();


            //Inherited From Reptiles
            Assert.Equal(10, ally.numEggs);
            //Inherited From Animals
            Assert.Equal(5, ally.Age);

        }
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Cobra()
        {
            Cobra kaa= new Cobra();

            // Inherited from Reptiles
            Assert.Equal(10, kaa.numEggs);
            // Inherited from Animals
            Assert.Equal(5, kaa.Age);

        }
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Constrictor()
        {
            Constrictor grogu = new Constrictor();

            // Inherited from Reptiles
            Assert.Equal(10, grogu.numEggs);
            // Inherited from Animals
            Assert.Equal(5, grogu.Age);

        }
        /// <summary>
        /// Ensures that all the Classes appropriate classes implement the ICreep interface
        /// </summary>
        [Fact]
        public void Tests_All_Referenced_Classes_Utilize_Interface_ICreep()
        {
            Constrictor grogu = new Constrictor();
            Cobra kaa = new Cobra();
            Crocodile ally = new Crocodile();
            Alligator crocky = new Alligator();
            Assert.Equal("I'm a constrictor, slowly uncoiling.", grogu.Lurk());
            Assert.Equal("Creeping, lurking in the ssssshadowsss", kaa.Lurk());
            Assert.Equal("I'm a croc, and I creep.", ally.Lurk());
            Assert.Equal("Lurking...creeping in the shadows", crocky.Lurk());

        }
        /// <summary>
        /// Ensures that all the Classes appropriate classes implement the ISwimmingly interface
        /// </summary>
        [Fact]
        public void Tests_All_Referenced_Classes_Utilize_Interface_ISwimmingly()
        {
            //
            Alligator crocky = new Alligator();
            Cobra kaa = new Cobra();
            Constrictor grogu = new Constrictor();
            Crocodile ally = new Crocodile();
            Otter otto = new Otter();
            RedPanda bigRed = new RedPanda();
            Rhino rambi = new Rhino();
            Wolf balto = new Wolf();

            // This calls the Swim method and compares the expected output.
            Assert.Equal("I do myself a favor and go for a little swim.", crocky.Swim());
            Assert.Equal("I usually don't swwwwim unless it's a hot day", kaa.Swim());
            Assert.Equal("Taking a dip in the river, who knowsss", grogu.Swim());
            Assert.Equal("Aren't I always?", ally.Swim());
            Assert.Equal("I like swimming on my back while holding hands", otto.Swim());
            Assert.Equal("Ooh, just a small kids pool will do for me.", bigRed.Swim());
            Assert.Equal("I like swimming, although people mistake my horn for a fin..", rambi.Swim());
            Assert.Equal("Me and my wolf boys like to take a swim to show the ladies how its done", balto.Swim());

        }


    }
}
