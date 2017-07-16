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
        //protected double checkingBalance = 21362.34d;
        //protected double savingsBalance = 2567.23d;
        //public double depositAmount;
        //public double withdrawAmount;
        //public string clientName = "Sally Smith";
        //public string clientAddress = "32789 Duluthe Street, Wayupyonder, Alaska";
        //public string clientPhone = "(990) 341-2367";
        //public string clientCheckingAccountNumber = "AX 234059 0002345";
        //public string clientSavingsAccountNumber = "AP 721134 00000381";
        public string clientName;
        public string clientAddress;
        public string clientPhone;
        //public string clientCheckingAccountNumber;
        //public string clientSavingsAccountNumber;

        //properties (type prop and tab twice for setup)
        //public double CheckingBalance { get; set; }
        //public double SavingsBalance { get; set; }
        //public double DepositAmount { get; set; }
        //public double WithdrawAmount { get; set; }
        public string ClientName { get; }
        public string ClientAddress { get; }
        public string ClientPhone { get; }
        //public string ClientCheckingAccountNumber { get; }
        //public string ClientSavingsAccountNumber { get; }

        //constructors 
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

        //public Client(double checkingBalance, double savingsBalance)
        //{
        //    this.checkingBalance = checkingBalance;
        //    this.savingsBalance = savingsBalance;
        //    //this.depositAmount = depositAmount;
        //    //this.withdrawAmount = withdrawAmount;
        //}

        //create method
        public virtual string ShowClientInfo()   //virtual keyword = whoever inherits from this class can override this method
        {
            //Console.WriteLine("Accountholder Name: " + clientName);
            //Console.WriteLine("Accountholder Address: " + clientAddress);
            //Console.WriteLine("Accountholder PhoneNumber: " + clientPhone);
            return ("Accountholder Name: " + clientName + "\nAccountholder Address: " + clientAddress + "\nAccountholder Phone Number: " + clientPhone);
        }

        //public virtual string ShowAccountInfo()
        //{
        //    return ("Checking Account: " + clientCheckingAccountNumber + "Checking Account Balance: " + checkingBalance + "\nSavings Account: " + clientSavingsAccountNumber + "Savings Account Balance: " + savingsBalance);
        //    //return ("Checking Account: " + clientCheckingAccountNumber + "Checking Account Balance: " + checkingBalance);
        //    //return ("Savings Account: " + clientSavingsAccountNumber + "Savings Account Balance: " + savingsBalance);
        //}
    }
}
