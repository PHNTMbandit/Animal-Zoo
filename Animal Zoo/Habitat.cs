namespace Animal_Zoo
{
    public enum HabitatSize
    {
        Small,
        Medium,
        Large
    }

    internal class Habitat(AnimalSize size)
    {
        public Animal? EnclosedAnimal { get; private set; }
        public AnimalSize HabitatSize { get; private set; } = size;

        public Action<Habitat>? onHabitatChange;

        public void EncloseAnimal(Animal animal)
        {
            EnclosedAnimal = animal;
            EnclosedAnimal.onAnimalDeath += ReleaseAnimal;

            onHabitatChange?.Invoke(this);
        }

        public void ReleaseAnimal()
        {
            if (EnclosedAnimal != null)
            {
                EnclosedAnimal.onAnimalDeath -= ReleaseAnimal;
                EnclosedAnimal = null;

                onHabitatChange?.Invoke(this);
            }
        }

        public bool CanAnimalBeEnclosed(AnimalSize size)
        {
            return size >= HabitatSize;
        }
    }
}