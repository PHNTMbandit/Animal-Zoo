namespace Animal_Zoo
{
    internal class Bank
    {
        public int Balance { get; set; } = 1000;

        public void RemoveFromBalance(int amount)
        {
            Balance -= amount;
        }

        public void AddToBalance(int amount)
        {
            Balance += amount;
        }

        public bool CanAfford(int amount)
        {
            return (Balance - amount) >= 0;
        }
    }
}