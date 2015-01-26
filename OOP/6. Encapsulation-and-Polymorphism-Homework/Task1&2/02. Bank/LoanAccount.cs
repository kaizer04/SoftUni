namespace _02.Bank
{

    public class LoanAccount : Account, IMoneyDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
                if (periodInMonths <= 3)
                {
                    return 0;
                }
                else
                { 
                    return (periodInMonths - 3) * ((this.InterestRate / 100) * this.Balance);
                }
            }
            else // if this.Customer is a Company  
            {
                if (periodInMonths <= 2)
                {
                    return 0;
                }
                else
                { 
                    return (periodInMonths - 2) * ((this.InterestRate / 100) * this.Balance);
                }
            }
        }
        
    }
}
