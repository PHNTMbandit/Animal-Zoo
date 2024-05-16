namespace Animal_Zoo
{
    internal class AnimalOffer(Animal animal, int cost)
    {
        public Animal Animal { get; private set; } = animal;
        public int Cost { get; private set; } = cost;
    }
}