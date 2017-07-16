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
        public double checkingBal = 21362.34d;
        public double checkingDeposit;
        public double checkingWithdraw;
        //private double checkingDepositAmount;

        //properties (type prop and tab twice for setup)

        //public double CheckingAmount { get; }
        public double CheckingBal { get; set; }
        public double CheckingDeposit { get; set; }
        public double CheckingWithdraw { get; set; }
        //public double CheckingBal { get; set; }
        //constructors 
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
            //this.checkingAmount = checkingAmount;
            this.checkingBal = checkingBal;
            this.checkingDeposit = checkingDeposit;
            this.checkingWithdraw = checkingWithdraw;
        }

        //public CheckingAccount(double checkingDepositAmount)
        //{
        //    this.checkingDepositAmount = checkingDepositAmount;
        //}

        //create methods
        public override string GetCheckingBalance()
        {
            return "CheckingBal: " + checkingBal + "\n";
        }
        public override void DepositChecking()
        {
            checkingBal += checkingDeposit;
        }
        public override void WithdrawChecking()
        {
            checkingBal -= checkingWithdraw;
        }
    }
}
