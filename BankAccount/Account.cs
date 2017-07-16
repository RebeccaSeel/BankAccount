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
        protected double checkingBal;
        protected double savingsBal;
        //public double amountDeposit;
        //public double amountWithdraw;

        //properties (type prop and tab twice for setup)
        public double CheckingBal { get; set; }
        public double SavingsBal { get; set; }
        //public double AmountDeposit { get; set; }
        //public double AmountWithdraw { get; set; }

        //constructors 
        public Account()
        {
            //this is the default constructor
        }

        public Account(double checkingBal, double savingsBal, double amountDeposit, double amountWithdraw)
        {
            this.checkingBal = checkingBal;
            this.savingsBal = savingsBal;
            //this.amountDeposit = amountDeposit;
            //this.amountWithdraw = amountWithdraw;

            checkingBal = 0.0d;
            savingsBal = 0.0d;
        }

        //create methods
        //public virtual   //virtual keyword = whoever inherits from this class can override this method
        //{

        //}

        //public virtual 
        //{

        //}
    }
}
