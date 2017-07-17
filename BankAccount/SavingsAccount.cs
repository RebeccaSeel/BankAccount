using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        //SavingsAccount is a derived classs of Account with the following fields
        public double minSavingsBal = 50.00d;
    
        //set properties
        public double MinSavingsBal { get;}
 
        //establish constructors 
        public SavingsAccount()
        {
            //this is the default constructor
        }

        public SavingsAccount(double savingsDeposit)
        {
            this.savingsDeposit = savingsDeposit;
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

        //create methods for this class
        public override double GetSavingsBalance()
        {
            return savingsBal;
        }

        public override double DepositIntoSavings()
        {
            return savingsBal + savingsDeposit;
        }

        public override double WithdrawFromSavings()
        {
            return savingsBal - savingsWithdraw;
        }
    }
}
