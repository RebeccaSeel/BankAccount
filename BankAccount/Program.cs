using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Community Bank of Northern Alaska! \n");
            Console.WriteLine("Our menu of options follows: ");

            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit \n");

            Console.WriteLine("Enter the number of menu item you wish to view: \n");

            int menuSelection;
            do
            {
                menuSelection = int.Parse(Console.ReadLine());
                if (menuSelection == 1)
                {
                    Console.WriteLine("\nFollowing is your Client Information: \n");
                    //create instance of client
                    Client clientInfo = new Client("Sally Smith", "32789 Duluthe Street, Wayupyonder, Alaska", "(990) 341-2367");
                    clientInfo.ShowClientInfo();
                    Console.WriteLine(clientInfo.ShowClientInfo());
                    Console.WriteLine("");

                    Console.WriteLine("Following is your Account information: \n");
                    //create another instance of client
                    Client clientAccountInfo = new Client("234059 0002345", "721134 00000381");
                    clientAccountInfo.ShowAccountInfo();
                    Console.WriteLine(clientAccountInfo.ShowAccountInfo());

                    Console.WriteLine("\nWhat do you want to do next?\n");

                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit \n");
                }
                else if (menuSelection == 2)
                {
                    string balanceSelect;
                    Console.WriteLine("\nWhich Account Balance do you want to view? \n");
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    Console.WriteLine("\nEnter letter here: ");
                    balanceSelect = Console.ReadLine();
                    if (balanceSelect == "a")
                    {
                        CheckingAccount checkingBalance = new CheckingAccount();
                        checkingBalance.GetCheckingBalance();
                        Console.WriteLine("\nChecking Account Balance: $" + checkingBalance.ShowInitialCheckingBalance());
                        Console.WriteLine("");
                    }
                    if (balanceSelect == "b")
                    {
                        SavingsAccount savingsBalance = new SavingsAccount();
                        savingsBalance.GetSavingsBalance();
                        Console.WriteLine("\nSavings Account Balance: $" + savingsBalance.ShowInitialSavingsBalance());
                        Console.WriteLine("");
                    }

                    Console.WriteLine("What do you want to do next?\n");

                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit \n");
                }
                else if (menuSelection == 3)
                {
                    string depositSelect;
                    Console.WriteLine("\nTo which Account do you want to deposit? \n");
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    Console.WriteLine("\nPlease enter letter here: ");
                    depositSelect = Console.ReadLine();
                    if (depositSelect == "a")
                    {
                        Console.WriteLine("\nEnter your Checking Account deposit amount: ");
                        double checkingDeposit = double.Parse(Console.ReadLine());
                        CheckingAccount depositCheckingAccount = new CheckingAccount(checkingDeposit);
                        depositCheckingAccount.GetCheckingBalance();
                        Console.WriteLine("\nThank you for your deposit! Your new Checking Account Balance is: $" + depositCheckingAccount.DepositIntoChecking());
                        Console.WriteLine("");
                    }
                    if (depositSelect == "b")
                    {
                        Console.WriteLine("\nEnter your Savings Account deposit amount: ");
                        double savingsDeposit = double.Parse(Console.ReadLine());
                        SavingsAccount depositSavingsAccount = new SavingsAccount(savingsDeposit);
                        depositSavingsAccount.GetSavingsBalance();
                        Console.WriteLine("\nThank you for your deposit! Your new Savings Account Balance is: $" + depositSavingsAccount.DepositIntoSavings());
                        Console.WriteLine("");
                    }

                    Console.WriteLine("What do you want to do next?\n");

                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit \n");
                }
                else if (menuSelection == 4)
                {
                    string withdrawSelect;
                    Console.WriteLine("\nFrom which Account do you want to withdraw? \n");
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account\n");
                    Console.WriteLine("\nPlease enter letter here: ");
                    withdrawSelect = Console.ReadLine();
                    if (withdrawSelect == "a")
                    {
                        Console.WriteLine("\nEnter your Checking Account withdraw amount: ");
                        double checkingWithdraw = double.Parse(Console.ReadLine());
                        CheckingAccount withdrawCheckingAccount = new CheckingAccount(checkingWithdraw);
                        withdrawCheckingAccount.GetCheckingBalance();
                        Console.WriteLine("\nThank you for your withdrawal. Your new Checking Account Balance is: $" + withdrawCheckingAccount.WithdrawFromChecking());
                        Console.WriteLine("");
                    }
                    if (withdrawSelect == "b")
                    {
                        Console.WriteLine("\nEnter your Savings Account withdraw amount: ");
                        double savingsWithdraw = double.Parse(Console.ReadLine());
                        SavingsAccount withdrawSavingsAccount = new SavingsAccount(savingsWithdraw);
                        withdrawSavingsAccount.GetSavingsBalance();
                        Console.WriteLine("\nThank you for your withdrawal. Your new Savings Account Balance is: $" + withdrawSavingsAccount.WithdrawFromSavings());
                        Console.WriteLine("");
                    }

                    Console.WriteLine("What do you want to do next?\n");

                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit \n");
                }
                else
                {
                    return;
                }

            } while (true);
        }
    }
}
