namespace Animal_Zoo
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly InGameClock _inGameClock = new();

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Clock_Timer_Tick(object sender, EventArgs e)
        {
            _inGameClock.UpdateClock();
            Lbl_time.Text = $"{_inGameClock.GetClockDateString()}\n{_inGameClock.GetClockTimeString()}";
        }
    }
}