using System.Globalization;

namespace Animal_Zoo
{
    internal class InGameClock
    {
        public DateTime Clock { get; private set; } = DateTime.ParseExact("2000-01-01 00:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

        public void UpdateClock()
        {
            Clock = Clock.AddHours(1);
        }

        public string GetClockDateString()
        {
            return Clock.ToString("d MMM yyyy");
        }

        public string GetClockTimeString()
        {
            return Clock.ToString("t");
        }
    }
}