namespace Animal_Zoo
{
    internal class AnimalManager
    {
        private static readonly Random _random = new();

        public Animal[] Animals { get; private set; } = [
        new Animal("Monkey", AnimalSize.Small, _random.Next(0, 10), _random.Next(1, 20)),
        new Animal("Penguin", AnimalSize.Small, _random.Next(0, 10), _random.Next(1, 20)),
        new Animal("Flamingo", AnimalSize.Small, _random.Next(0, 10), _random.Next(1, 20)),
        new Animal("Wolf", AnimalSize.Medium, _random.Next(10, 20), _random.Next(1, 20)),
        new Animal("Kangaroo", AnimalSize.Medium, _random.Next(10, 20), _random.Next(1, 20)),
        new Animal("Zebra", AnimalSize.Medium, _random.Next(10, 20), _random.Next(1, 20)),
        new Animal("Elephant", AnimalSize.Large, _random.Next(20, 30), _random.Next(1, 20)),
        new Animal("Giraffe", AnimalSize.Large, _random.Next(20, 30), _random.Next(1, 20)),
        new Animal("Lion", AnimalSize.Large, _random.Next(20, 30), _random.Next(1, 20))];
    }
}