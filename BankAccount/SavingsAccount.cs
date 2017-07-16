using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        //protected double savingsAmount;
        //protected double savingsBal;
        public double savingsBal = 2567.23d;
        public double minSavingsBal = 50.0d;
        public double savingsDeposit;
        public double savingsWithdraw;

        //properties (type prop and tab twice for setup)
        //public double SavingsAmount { get; set; }
        //public double SavingsBal { get; set; }
        public double MinSavingsBal { get; }
        public double SavingsBal { get; set; }
        public double SavingsDeposit { get; set; }
        public double SavingsWithdraw { get; set; }

        //constructors 
        public SavingsAccount()
        {
            //this is the default constructor
        }
        public SavingsAccount(double savingsBal, double savingsDeposit)
        {
            this.savingsBal = savingsBal;
            this.savingsDeposit = savingsDeposit;
        }

        public SavingsAccount(double minSavingsBal, double savingsBal, double savingsWithdraw)
        {
            this.minSavingsBal = minSavingsBal;
            this.savingsBal = savingsBal;
            this.savingsWithdraw = savingsWithdraw;
        }


        public SavingsAccount(double minSavingsBal, double savingsBal, double savingsDeposit, double savingsWithdraw)
        {
            this.minSavingsBal = minSavingsBal;
            this.savingsBal = savingsBal;
            this.savingsDeposit = savingsDeposit;
            this.savingsWithdraw = savingsWithdraw;
        }

        //create methods
        public override string GetSavingsBalance()
        {
            return "SavingsBal: " + savingsBal + "\n";
        }
        public override void DepositSavings()
        {
            savingsBal += savingsDeposit;
        }
        public override void WithdrawSavings()
        {
            savingsBal -= savingsWithdraw;
        }
    }
}
