namespace Animal_Zoo
{
    internal class Bank
    {
        public int Balance { get; private set; } = 500;

        public Action? onBalanceChange;

        public void RemoveFromBalance(int amount)
        {
            Balance -= amount;

            onBalanceChange?.Invoke();
        }

        public void AddToBalance(int amount)
        {
            Balance += amount;

            onBalanceChange?.Invoke();
        }

        public bool CanAfford(int amount)
        {
            return (Balance - amount) >= 0;
        }
    }
}