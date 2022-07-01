namespace BancaOOP
{
    internal class Loan
    {
        public Loan(Client accountHolder, decimal amount, DateOnly startDate, DateOnly endDate)
        {
            AccountHolder = accountHolder;
            Amount = amount;
            StartDate = startDate;
            EndDate = endDate;
        }
        
        public int Id { get; private set; }
        public Client AccountHolder { get; private set; }
        public decimal Amount { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public decimal GetInstallment()
            => Amount / GetDuration();

        public int GetDuration()
            => -12 * (DateOnly.FromDateTime(DateTime.Now).Year - EndDate.Year) + DateOnly.FromDateTime(DateTime.Now).Month - EndDate.Month;

        public int DurationLeft()
            => -12 * (DateOnly.FromDateTime(DateTime.Now).Year - EndDate.Year) + DateOnly.FromDateTime(DateTime.Now).Month - EndDate.Month;

        public void Display()
        {
            Console.WriteLine($"Loan {Id}");
            Console.WriteLine($"Account holder: {AccountHolder.Name} {AccountHolder.Surname}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Start date: {StartDate}");
            Console.WriteLine($"End date: {EndDate}");
            Console.WriteLine($"Installment: {GetInstallment()}");
        }
    }
}