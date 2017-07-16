using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        //protected double checkingAmount;
        //protected double checkingBal;
        public double checkingDeposit;
        public double checkingWithdraw;

        //properties (type prop and tab twice for setup)

        //public double CheckingAmount { get; }
        public double CheckingDeposit { get; set; }
        public double CheckingWithdraw { get; set; }
        //public double CheckingBal { get; set; }
        //constructors 
        public CheckingAccount()
        {
            //this is the default constructor
        }

        public CheckingAccount(double checkingAmount, double checkingDeposit, double checkingWithdraw)
        {
            //this.checkingAmount = checkingAmount;
            //this.checkingBal = checkingBal;
            this.checkingDeposit = checkingDeposit;
            this.checkingWithdraw = checkingWithdraw;

        }

        //create methods
        public void DepositChecking (double amount)
        {
            checkingBal += checkingDeposit;
        }

        public void WithdrawChecking(double amount)
        {
            checkingBal -= checkingWithdraw;
        }
    }
}
