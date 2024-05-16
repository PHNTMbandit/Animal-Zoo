namespace Animal_Zoo
{
    internal class AnimalFactory
    {
        private readonly Random _random = new();

        public AnimalOffer GetAnimalOffer(AnimalName animal)
        {
            return new AnimalOffer(new Animal(animal), _random.Next(0, 100));
        }
    }
}