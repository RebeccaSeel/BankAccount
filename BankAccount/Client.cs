using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //Client is base class
        public string clientName;
        public string clientAddress;
        public string clientPhone;
        public string checkingAccountNumber;
        public string savingsAccountNumber;

        //properties (type prop and tab twice for setup)
        public string ClientName { get; }
        public string ClientAddress { get; }
        public string ClientPhone { get; }
        public string CheckingAccountNumber { get; }
        public string SavingsAccountNumber { get; }

        //establish constructors 
        public Client()
        {
            //this is the default constructor
        }

        public Client(string clientName, string clientAddress, string clientPhone)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientPhone = clientPhone;
        }

        public Client(string checkingAccountNumber, string savingsAccountNumber)
        {
            this.checkingAccountNumber = checkingAccountNumber;
            this.savingsAccountNumber = savingsAccountNumber;
        }

        //create method
        public virtual string ShowClientInfo()   
        {
             return ("Accountholder Name: " + clientName + "\nAccountholder Address: " + clientAddress + "\nAccountholder Phone Number: " + clientPhone);
        }

        public virtual string ShowAccountInfo()
        {
            return ("Checking Account: " + checkingAccountNumber + "\nSavings Account: " + savingsAccountNumber);
        }
    }
}
