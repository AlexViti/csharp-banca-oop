namespace BancaOOP
{
    internal class Loan
    {
        public int Id { get; private set; }
        public Client AccountHolder { get; set; }
        public double Amount { get; set; }
        public double InterestRate { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}