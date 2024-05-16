namespace Animal_Zoo
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly Bank _playerBank = new();
        private readonly InGameClock _inGameClock = new();

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBankAmountLabel();
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
    }
}