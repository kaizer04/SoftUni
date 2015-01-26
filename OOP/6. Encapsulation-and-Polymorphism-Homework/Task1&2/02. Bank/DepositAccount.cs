namespace _02.Bank
{
    public class DepositAccount : Account, IMoneyDepositable, IMoneyDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }
        }

        // използвам метода за лихвата и тук, за да изчисля лихвата и добавя в сметката преди да извърша операцията
        public void DepositMoney(decimal ammount, decimal lastOperationInMonths) 
        {
            this.Balance += CalculateInterestAmount(lastOperationInMonths);
            this.Balance += ammount;
        }

        public void DrawMoney(decimal ammount, decimal lastOperationInMonths)
        {
            this.Balance += CalculateInterestAmount(lastOperationInMonths);
            this.Balance -= ammount;
        }
    }
}
