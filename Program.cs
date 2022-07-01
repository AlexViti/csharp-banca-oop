using BancaOOP;

Client client = new Client("123", "1234", "12345");
Loan loan = new Loan(client, 150000, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddMonths(5)));
loan.Display();
Console.WriteLine(loan.DurationLeft());