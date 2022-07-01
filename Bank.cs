using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaOOP
{
    internal class Bank
    {
        public  List<Client> clients = new List<Client>();
        public  List<Loan> loans = new List<Loan>();
        public Bank(string name)
        {
            this.Name = name;
        }

         public string Name { get; private set; }

    }
}
