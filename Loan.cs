namespace BancaOOP
{
    internal class Loan
    {
        public Loan(Client accountHolder, decimal amount, int numberOfInstallment, DateOnly startDate, DateOnly endDate)
        {
            AccountHolder = accountHolder;
            Amount = amount;
            NumberOfInstallments = numberOfInstallment;
            StartDate = startDate;
            EndDate = endDate;
        }
        
        public int Id { get; private set; }
        public Client AccountHolder { get; private set; }
        public decimal Amount { get; set; }
        public int NumberOfInstallments { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }


        public double GetInstallment()
            => Amount / NumberOfInstallments;
    }
}