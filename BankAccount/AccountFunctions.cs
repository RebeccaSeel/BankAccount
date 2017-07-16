using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class AccountFunctions
    {
        public abstract void View();
        //public abstract void ChangeAddress();
        //public abstract void ChangePhone();
        public abstract void UpdateBalance();
        public abstract void Deposit();
        public abstract void Withdraw();

    }

}
