using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //Account is a base class with the following fields
        public int checkingAccountNumber = 1989022019;
        public double checkingBal = 21362.34d;
        public double checkingDeposit;
        public double checkingWithdraw;

        public int savingsAccountNumber = 00128321;
        //public double minSavingsBal = 50.00d;
        public double savingsBal = 2567.23d;
        public double savingsDeposit;
        public double savingsWithdraw;


        //set properties 
        public double CheckingBal { get; }
        public double CheckingDeposit { get; set; }
        public double CheckingWithdraw { get; set; }
        
        //public double MinSavingsBal { get; }
        public double SavingsBal { get; }
        public double SavingsDeposit { get; set; }
        public double SavingsWithdraw { get; set; }
 

        //establish constructors 
        public Account()
        {
            //this is the default constructor
        }

        public Account(double checkingDeposit, double checkingWithdraw)
        {
            //this.checkingBal = checkingBal;
            this.checkingDeposit = checkingDeposit;
            this.checkingWithdraw = checkingWithdraw;            
        }

        public Account(double savingsBal, double savingsDeposit, double savingsWithdraw)
        {
            //this.minSavingsBal = minSavingsBal;
            this.savingsBal = savingsBal;
            this.savingsDeposit = savingsDeposit;
            this.savingsWithdraw = savingsWithdraw;

            //minSavingsBal = 50.00d; //must have a minimum balance of $50.00
        }

        //create methods
        public virtual double ShowInitialCheckingBalance()
        {
            return 21362.34d;
        }

        public virtual double GetCheckingBalance()
        {
            return checkingBal;
        }

        public virtual double DepositIntoChecking()
        {
            return checkingBal += checkingDeposit;
        }

        public virtual double WithdrawFromChecking()
        {
            return checkingBal -= checkingWithdraw;
        }

        public virtual double ShowInitialSavingsBalance()
        {
            return 2567.23d;
        }

        public virtual double GetSavingsBalance()
        {
            return savingsBal;
        }

        public virtual double DepositIntoSavings()
        {
            return savingsBal += savingsDeposit;
        }

        public virtual double WithdrawFromSavings()
        {
            return savingsBal -= savingsWithdraw;
        }
    }
}
