namespace Animal_Zoo
{
    internal class AnimalOffers
    {
        public List<AnimalOffer> AnimalOfferList { get; private set; } = [];

        public Action<AnimalOffer>? onListChanged;

        public void AddOffer(AnimalOffer offer)
        {
            AnimalOfferList.Add(offer);

            onListChanged?.Invoke(offer);
        }

        public void RemoveOffer(AnimalOffer offer)
        {
            AnimalOfferList.Remove(offer);
        }
    }
}