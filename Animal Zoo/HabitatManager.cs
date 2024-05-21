namespace Animal_Zoo
{
    internal class HabitatManager
    {
        public Habitat[] Habitats { get; private set; } = [
            new Habitat(AnimalSize.Small),
            new Habitat(AnimalSize.Medium),
            new Habitat(AnimalSize.Large),
            new Habitat(AnimalSize.Large)];

        public bool FindSuitableHabitat(AnimalSize animalSize, out Habitat habitat)
        {
            habitat = Habitats.First(i => i.CanAnimalBeEnclosed(animalSize));

            if (habitat.EnclosedAnimal == null)
            {
                return true;
            }

            MessageBox.Show("You don't have a suitable habitat available", "No Valid Habitat");

            return false;
        }
    }
}