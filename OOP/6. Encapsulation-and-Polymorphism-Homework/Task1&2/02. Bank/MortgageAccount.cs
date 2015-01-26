namespace _02.Bank
{
    public class MortgageAccount : Account, IMoneyDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            
        }

        // използвам метода за лихвата и тук, за да изчисля лихвата и добавя/изважда в сметката преди да извърша операцията
        public void DepositMoney(decimal ammount, decimal lastOperationInMonths)
        {
            this.Balance += CalculateInterestAmount(lastOperationInMonths);
            this.Balance += ammount;
        }

        public override decimal CalculateInterestAmount(decimal periodInMonths)
        {
            if (periodInMonths < 0)
            {
                throw new System.ArgumentException("Period in months can not be a negative number!");
            }

            if (this.Customer is Individual)
            {
                if (periodInMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return (periodInMonths - 6) * ((this.InterestRate / 100) * this.Balance);
                }
            }
            else // if Customer is a Company
            { 
                if (periodInMonths <= 12)
                {
                    return periodInMonths * ((this.InterestRate / 2 / 100) * this.Balance);
                }
                else
                {
                    return 12 * ((this.InterestRate / 2 / 100) * this.Balance) + (periodInMonths - 12) * ((this.InterestRate / 100) * this.Balance);
                }
            }
        }
       
    }
}
