using System;
using Xunit;
using Lab6_7;

namespace AnimalTesting
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing to ensure values are inherited on the concrete class from the abstract base class: Animal
        /// </summary>
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Wolf()
        {
            Wolf wolf = new Wolf();
            wolf.Age = 14;


            Assert.Equal(14, wolf.Age);
            Assert.False(wolf.IsBreathing);
        }
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_RedPanda()
        {
            RedPanda booboo = new RedPanda();
            booboo.Age = 5;


            Assert.Equal(5, booboo.Age);
            Assert.False(booboo.IsBreathing);
        }
        /// <summary>
        /// We are testing to determine if default values are inherited from Mammal down to otter
        /// </summary>
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Otter()
        {
            Otter gladius = new Otter();


            Assert.Equal("Smooth", gladius.TypeOfFur);
            Assert.Equal("Feels so good! Mammals love to be scratched", gladius.Scratch());

        }
        /// <summary>
        /// Testing to determine if values are properly inherited to Rhino Class
        /// </summary>
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Rhino()
        {
            Rhino turkey = new Rhino();

            //Inherited From  Mammals
            Assert.Equal("Smooth", turkey.TypeOfFur);
            //Inherited From Mammals
            Assert.Equal("Feels so good! Mammals love to be scratched", turkey.Scratch());

        }
        /// <summary>
        /// Testing to determine if values are properly inherited to Alligator Class
        /// </summary>
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

    }
}
