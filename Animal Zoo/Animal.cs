namespace Animal_Zoo
{
    internal enum AnimalSize
    {
        Small,
        Medium,
        Large
    }

    internal class Animal(string name, AnimalSize size, int earnings, int deathDays)
    {
        public string Name { get; private set; } = name;
        public AnimalSize Size { get; private set; } = size;
        public int Earnings { get; private set; } = earnings;
        public int DeathDays { get; private set; } = deathDays;

        public Action? onAnimalDeath;
    }
}