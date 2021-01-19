namespace Lab6_7
{
    /// <summary>
    /// Abstract class derived from abstract mammal class
    /// </summary>
    public abstract class Herbivore : Mammal
    {
        public string typeOfPlantsConsumed { get; set; }
        public string size { get; set; }

        public abstract void Graze();
    }
}
