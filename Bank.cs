using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaOOP
{
    internal class Bank
    {
        public Bank(string name)
        {
            this.Name = name;
        }

        private List<Client> clients = new List<Client>();
        private List<Loan> loans = new List<Loan>();
        public string Name { get; private set; }
        
        public void AddClient(Client client)
            => clients.Add(client);

        public void AddClient(string name, string surname, string fiscalCode)
            => clients.Add(new Client(name, surname, fiscalCode));

        public Client? FindClient(string fiscalCode)
            => clients.FirstOrDefault(c => c.FiscalCode == fiscalCode);

        public List<Client>? FindClients(string surname)
            => clients.Where(c => c.Surname == surname).ToList();

        public List<Client>? FindClients(string surname, string name)
            => clients.Where(c => c.Surname == surname && c.Name == name).ToList();

        public void EditClient(Client toEdit)
        {
            Console.WriteLine("Edit client");
            Console.Write("Name: ");
            string? input = Console.ReadLine();
            
            if (!String.IsNullOrEmpty(input))
                toEdit.Name = input;
            
            Console.Write("Surname: ");
            input = Console.ReadLine();
            
            if (!String.IsNullOrEmpty(input))
                toEdit.Surname = input;
            
            Console.Write("Fiscal code: ");
            input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
                toEdit.FiscalCode = input;

        }

        public void AddLoan()
        {
            Console.WriteLine("Add loan");
            Console.Write("Fiscal code: ");
            string fiscalCode = Console.ReadLine();
            Client? client = FindClient(fiscalCode);
            if (client == null)
            {
                Console.WriteLine("Client not found");
                return;
            }
            Console.Write("\nAmount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("\nDuration in months: ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("\nNumber of installment: ");
            int installment = int.Parse(Console.ReadLine());
            loans.Add(new Loan(client, amount, installment, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddMonths(duration))));
        }
        
        
    }
    
}
