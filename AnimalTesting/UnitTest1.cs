using Lab6_7;

namespace AnimalTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_Wolf()
        {
            Wolf wolf = new Wolf();
            wolf.Age = 14;


            Assert.Equal(14, wolf.Age);
            Assert.False(wolf.isBreathing);
        }
        [Fact]
        public void Tests_If_Animal_Properties_Are_Inherited_To_RedPanda()
        {
            RedPanda booboo = new RedPanda();
            booboo.Age = 5;


            Assert.Equal(5, booboo.Age);
            Assert.False(booboo.isBreathing);
        }
    }
}
