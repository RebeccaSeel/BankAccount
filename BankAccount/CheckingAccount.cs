using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        //CheckingAccount is a derived class of Account with the following fields
        //public int checkingAccountNumber = 1989022019;
        //public double checkingBal = 21362.34d;
        //public double checkingDeposit;
        //public double checkingWithdraw;

        //set properties
        //public double CheckingBal { get; set; }
        //public double CheckingDeposit { get; set; }
        //public double CheckingWithdraw { get; set; }
       
        //establish constructors 
        public CheckingAccount()
        {
            //this is the default constructor
        }
        
        public CheckingAccount(double checkingDeposit)
        {
            this.checkingDeposit = checkingDeposit;
        }

        public CheckingAccount (double checkingBal, double checkingWithdraw)
        {
            this.checkingBal = checkingBal;
            this.checkingWithdraw = checkingWithdraw;
        }

        public CheckingAccount(double checkingBal, double checkingDeposit, double checkingWithdraw)
        {
            this.checkingBal = checkingBal;
            this.checkingDeposit = checkingDeposit;
            this.checkingWithdraw = checkingWithdraw;
        }


        //create methods for this class
        public override double GetCheckingBalance()
        {
            return checkingBal;
        }

        public override double DepositIntoChecking()
        {
            return checkingBal += checkingDeposit;
        }

        public override double WithdrawFromChecking()
        {
            return checkingBal -= checkingWithdraw;
        }
    }
}
