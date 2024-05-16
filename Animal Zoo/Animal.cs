namespace Animal_Zoo
{
    internal enum AnimalName
    {
        Dog,
        Cat
    }

    internal class Animal(AnimalName name)
    {
        public AnimalName Name { get; private set; } = name;
    }
}