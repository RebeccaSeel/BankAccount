using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //Client is base class
        public double checkingBal = 21362.34d;
        public double savingsBal = 2567.23d;
        public double minSavingsBal = 50.0d;
        public double checkingDeposit;
        public double checkingWithdraw;
        public double savingsDeposit;
        public double savingsWithdraw;

        //protected double checkingBal;
        //protected double savingsBal;
        //public double amountDeposit;
        //public double amountWithdraw;

        //properties (type prop and tab twice for setup)
        public double CheckingBal { get; }
        public double MinSavingsBal { get; }
        public double SavingsBal { get; }
        public double CheckingDeposit { get; set; }
        public double CheckingWithdraw { get; set; }
        public double SavingsDeposit { get; set; }
        public double SavingsWithdraw { get; set; }
        //public double AmountDeposit { get; set; }
        //public double AmountWithdraw { get; set; }

        //constructors 
        public Account()
        {
            //this is the default constructor
        }

        public Account(double checkingBal, double checkingDeposit, double checkingWithdraw)
        {
            this.checkingBal = checkingBal;
            this.checkingDeposit = checkingDeposit;
            this.checkingWithdraw = checkingWithdraw;            
            //this.amountDeposit = amountDeposit;
            //this.amountWithdraw = amountWithdraw;

            checkingBal = 0.0d;
        }

        public Account(double minSavingsBal, double savingsBal, double savingsDeposit, double savingsWithdraw)
        {
            this.minSavingsBal = minSavingsBal;
            this.savingsBal = savingsBal;
            this.savingsDeposit = savingsDeposit;
            this.savingsWithdraw = savingsWithdraw;
            //this.amountDeposit = amountDeposit;
            //this.amountWithdraw = amountWithdraw;

            savingsBal = 50.0d; //must have a minimum balance of $50.00
        }

        //create methods
        public void ChangeBalance()
        {
            return;
        }
        public virtual string GetCheckingBalance()
        {
            return "CheckingBal: " + checkingBal + "\n";
        }
        public virtual void DepositChecking()
        {
            checkingBal += checkingDeposit;
        }
        public virtual void WithdrawChecking()
        {
            checkingBal -= checkingWithdraw;
        }
        public virtual string GetSavingsBalance()
        {
            return "SavingsBal: " + savingsBal + "\n";
        }
        public virtual void DepositSavings()
        {
            savingsBal += savingsDeposit;
        }
        public virtual void WithdrawSavings()
        {
            savingsBal -= savingsWithdraw;
        }
    }
}
