namespace _02.Bank
{
    using System;

    public abstract class Account
    {
        private Customer customer;
        //private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Customer can not be null");
                }
                this.customer = value;
            }
        }
        
        public decimal Balance { get; protected set; }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative.");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(decimal periodInMonths)
        {
            if (periodInMonths < 0)
            {
                throw new System.ArgumentException("Period in months can not be a negative number!");
            }
            return periodInMonths * ((this.InterestRate / 100) * this.Balance);
        }
        
    }
}
