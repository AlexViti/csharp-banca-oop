namespace BancaOOP
{
    internal class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FiscalCode { get; set; }

        public Client(string name, string surname, string fiscalCode)
        {
            Name = name;
            Surname = surname;
            FiscalCode = fiscalCode;
        }

    }
}