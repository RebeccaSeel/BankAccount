﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        protected double savingsAmount;
        public double savingsDeposit;
        public double savingsWithdraw;

        //properties (type prop and tab twice for setup)
        public double SavingsAmount { get; set; }
        public double SavingsDeposit { get; set; }
        public double SavingsWithdraw { get; set; }

        //constructors 
        public SavingsAccount()
        {
            //this is the default constructor
        }

        public SavingsAccount(double savingsAmount, double savingsDeposit, double savingsWithdraw)
        {
            this.savingsAmount = savingsAmount;
            this.savingsDeposit = savingsDeposit;
            this.savingsWithdraw = savingsWithdraw;

        }

        //create methods
        public void DepositSavings(double amount)
        {
            savingsAmount += savingsDeposit;
        }

        public void WithdrawSavings(double amount)
        {
            savingsAmount -= savingsWithdraw;
        }
    }
}