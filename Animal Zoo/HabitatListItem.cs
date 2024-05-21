namespace Animal_Zoo
{
    internal class HabitatListItem : FlowLayoutPanel
    {
        public Habitat Habitat { get; private set; }

        private readonly InGameClock _clock = new();

        public HabitatListItem(Control parent, Habitat habitat)
        {
            Habitat = habitat;

            BorderStyle = BorderStyle.FixedSingle;
            FlowDirection = FlowDirection.TopDown;
            Name = $"Flw_{habitat.HabitatSize}";
            Padding = new Padding(5);
            Parent = parent;
            Size = new Size(250, 125);

            Label label = new()
            {
                Parent = this,
                Text = $"{habitat.HabitatSize} Habitat Size",
            };

            parent.Controls?.Add(this);
            Controls.Add(label);
        }

        public void UpdateHabitatListItemUI()
        {
            if (Habitat.EncloseAnimal == null)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls.RemoveAt(i);
                }

                return;
            }

            Label nameLabel = new()
            {
                Parent = this,
                Text = Habitat.EnclosedAnimal?.Name.ToString(),
            };

            Label moneyRateLabel = new()
            {
                Parent = this,
                Text = $"+{Habitat.EnclosedAnimal?.Earnings}",
                ForeColor = Color.Green,
            };

            Controls.Add(nameLabel);
            Controls.Add(moneyRateLabel);

            if (Habitat.EnclosedAnimal != null)
            {
                Label deathDaysLabel = new()
                {
                    Parent = this,
                    Text = _clock.Clock.AddDays(Habitat.EnclosedAnimal.DeathDays).ToString("g"),
                    ForeColor = Color.Red,
                };

                Controls.Add(deathDaysLabel);
            }
        }
    }
}