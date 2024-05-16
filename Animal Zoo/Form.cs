namespace Animal_Zoo
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly AnimalFactory _factory = new();
        private readonly AnimalOffers _offers = new();
        private readonly Bank _playerBank = new();
        private readonly InGameClock _inGameClock = new();

        public Form()
        {
            InitializeComponent();

            _offers.onListChanged = UpdateOfferList;
            _playerBank.onBalanceChange = UpdateBankAmountLabel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Flw_TemplateAnimalOffer.Visible = false;
            UpdateBankAmountLabel();
            _offers.AddOffer(_factory.GetAnimalOffer(AnimalName.Dog));
            _offers.AddOffer(_factory.GetAnimalOffer(AnimalName.Cat));
        }

        private void Clock_Timer_Tick(object sender, EventArgs e)
        {
            _inGameClock.UpdateClock();
            Lbl_time.Text = $"{_inGameClock.GetClockDateString()}\n{_inGameClock.GetClockTimeString()}";
        }

        private void UpdateBankAmountLabel()
        {
            Lbl_bank_amount.Text = $"${_playerBank.Balance}";
        }

        private void UpdateOfferList(AnimalOffer offer)
        {
            FlowLayoutPanel panel = new()
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                FlowDirection = FlowDirection.TopDown,
                Name = $"Flw_{offer.Animal.Name}Offer",
                Padding = new Padding(5),
                Parent = Flw_AnimalOffers,
            };

            Label label = new()
            {
                Parent = panel,
                Text = offer.Animal.Name.ToString(),
            };

            Button dynamicButton = new()
            {
                AutoSize = true,
                Name = offer.Animal.Name.ToString(),
                Parent = panel,
                Size = new Size(244, 30),
                Text = $"Buy for ${offer.Cost}",
            };

            dynamicButton.Click += (sender, EventArgs) => { BuyAnimal_Click(sender, EventArgs, offer, panel); };

            Flw_AnimalOffers.Controls?.Add(panel);
            panel.Controls?.Add(label);
            panel.Controls?.Add(dynamicButton);

            Lbl_MaxOffers.Text = $"{_offers.AnimalOfferList.Count}/4";
        }

        private void BuyAnimal_Click(object? sender, EventArgs e, AnimalOffer offer, FlowLayoutPanel panel)
        {
            if (_playerBank.CanAfford(offer.Cost))
            {
                _offers.RemoveOffer(offer);
                _playerBank.RemoveFromBalance(offer.Cost);
                panel.Dispose();
                Lbl_MaxOffers.Text = $"{_offers.AnimalOfferList.Count}/4";
            }
            else
            {
                MessageBox.Show("You cannot afford to buy this!", "Insufficient Funds");
            }
        }
    }
}