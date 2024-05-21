namespace Animal_Zoo
{
    internal class AnimalOfferManager
    {
        public int MaxOffers { get; private set; } = 4;
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