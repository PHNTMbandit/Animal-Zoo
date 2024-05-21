namespace Animal_Zoo
{
    internal class AnimalOfferListItem : FlowLayoutPanel
    {
        public AnimalOffer AnimalOffer { get; private set; }
        public Action<AnimalOfferListItem>? onBuy;

        public AnimalOfferListItem(Control parent, AnimalOffer offer)
        {
            AnimalOffer = offer;

            AutoSize = true;
            BorderStyle = BorderStyle.FixedSingle;
            FlowDirection = FlowDirection.TopDown;
            Name = $"Flw_{offer.Animal.Name}Offer";
            Padding = new Padding(5);
            Parent = parent;

            Label nameLabel = new()
            {
                Parent = this,
                Text = offer.Animal.Name.ToString(),
            };

            Label animalSizeLabel = new()
            {
                Parent = this,
                Text = offer.Animal.Size.ToString(),
            };

            Label moneyRateLabel = new()
            {
                Parent = this,
                Text = $"+{offer.Animal.Earnings}",
                ForeColor = Color.Green,
            };

            Label deathDaysLabel = new()
            {
                Parent = this,
                Text = $"{offer.Animal.DeathDays} Death Days",
                ForeColor = Color.Red,
            };

            Button dynamicButton = new()
            {
                AutoSize = true,
                Name = offer.Animal.Name.ToString(),
                Parent = this,
                Size = new Size(244, 30),
                Text = $"Buy for ${offer.Cost}",
            };

            dynamicButton.Click += (sender, EventArgs) => onBuy?.Invoke(this);

            parent.Controls?.Add(this);
            Controls?.Add(nameLabel);
            Controls?.Add(animalSizeLabel);
            Controls?.Add(moneyRateLabel);
            Controls?.Add(deathDaysLabel);
            Controls?.Add(dynamicButton);
        }
    }
}