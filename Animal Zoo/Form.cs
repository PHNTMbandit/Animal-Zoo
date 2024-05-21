namespace Animal_Zoo
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly AnimalFactory _factory = new();
        private readonly AnimalOfferManager _offers = new();
        private readonly Bank _playerBank = new();
        private readonly HabitatManager _habitatManager = new();
        private readonly InGameClock _inGameClock = new();
        private List<HabitatListItem> _habitatListItems = [];

        #region Initilisation Functions

        public Form()
        {
            InitializeComponent();

            _offers.onListChanged = AddOfferToList;
            _playerBank.onBalanceChange = UpdateBankAmountLabel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Flw_TemplateAnimalOffer.Visible = false;
            UpdateBankAmountLabel();

            for (int i = 0; i < _habitatManager.Habitats.Length; i++)
            {
                AddHabitToList(_habitatManager.Habitats[i]);
            }
        }

        #endregion Initilisation Functions

        private void Clock_Timer_Tick(object sender, EventArgs e)
        {
            _inGameClock.UpdateClock();
            Lbl_time.Text = $"{_inGameClock.GetClockDateString()}\n{_inGameClock.GetClockTimeString()}";

            foreach (HabitatListItem habitatListItem in _habitatListItems)
            {
                Animal? enclosedAnimal = habitatListItem.Habitat.EnclosedAnimal;

                if (enclosedAnimal == null)
                {
                    return;
                }

                _playerBank.AddToBalance(enclosedAnimal.Earnings);
                var currentDeathDate = _inGameClock.Clock.AddDays(enclosedAnimal.DeathDays);

                if (_inGameClock.Clock >= currentDeathDate)
                {
                    enclosedAnimal.onAnimalDeath?.Invoke();
                }
            }
        }

        private void UpdateBankAmountLabel()
        {
            Lbl_bank_amount.Text = $"${_playerBank.Balance}";
        }

        #region Animal Offer Functions

        private void Spawn_Offer_Timer_Tick(object sender, EventArgs e)
        {
            if (_offers.AnimalOfferList.Count < _offers.MaxOffers)
            {
                _offers.AddOffer(_factory.GetAnimalOffer());
            }
        }

        private void AddOfferToList(AnimalOffer offer)
        {
            AnimalOfferListItem listItem = new(Flw_AnimalOffers, offer);
            listItem.onBuy += BuyAnimal_Click;

            Lbl_MaxOffers.Text = $"{_offers.AnimalOfferList.Count}/{_offers.MaxOffers}";
        }

        private void DeleteOfferFromList(AnimalOfferListItem listItem)
        {
            listItem.Dispose();

            Lbl_MaxOffers.Text = $"{_offers.AnimalOfferList.Count}/4";
        }

        private void BuyAnimal_Click(AnimalOfferListItem listItem)
        {
            if (_habitatManager.FindSuitableHabitat(listItem.AnimalOffer.Animal.Size, out Habitat habitat))
            {
                if (_playerBank.CanAfford(listItem.AnimalOffer.Cost))
                {
                    DeleteOfferFromList(listItem);
                    _offers.RemoveOffer(listItem.AnimalOffer);
                    _playerBank.RemoveFromBalance(listItem.AnimalOffer.Cost);
                    habitat.EncloseAnimal(listItem.AnimalOffer.Animal);
                }
                else
                {
                    MessageBox.Show("You cannot afford to buy this!", "Insufficient Funds");
                }
            }
        }

        #endregion Animal Offer Functions

        #region Habitat Functions

        private void AddHabitToList(Habitat habitat)
        {
            HabitatListItem listItem = new(Flw_HabitatList, habitat);
            listItem.Habitat.onHabitatChange += UpdateHabitatFromList;
            _habitatListItems.Add(listItem);

            Lbl_HabitatLimit.Text = $"{_habitatManager.Habitats.Length}/4";
        }

        private void UpdateHabitatFromList(Habitat habitat)
        {
            _habitatListItems.Find(i => i.Habitat == habitat)?.UpdateHabitatListItemUI();
        }

        #endregion Habitat Functions
    }
}