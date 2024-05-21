namespace Animal_Zoo
{
    internal class AnimalFactory
    {
        private readonly Random _random = new();
        private readonly AnimalManager _manager = new();

        public AnimalOffer GetAnimalOffer()
        {
            Animal randomAnimal = _manager.Animals[_random.Next(0, _manager.Animals.Length)];

            return randomAnimal.Size switch
            {
                AnimalSize.Small => new AnimalOffer(randomAnimal, _random.Next(10, 50)),
                AnimalSize.Medium => new AnimalOffer(randomAnimal, _random.Next(51, 250)),
                AnimalSize.Large => new AnimalOffer(randomAnimal, _random.Next(251, 1000)),
                _ => new AnimalOffer(randomAnimal, _random.Next(0, 100)),
            };
        }
    }
}