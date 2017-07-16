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

            Console.WriteLine("Please enter the number of menu item you wish to view: ");

            int menuSelection;
            do
            {
                menuSelection = int.Parse(Console.ReadLine());
                if (menuSelection == 1)
                {
                    Console.WriteLine("Following is your Client Information: \n");
                    //create instance of client
                    Client clientInfo = new Client("Sally Smith", "32789 Duluthe Street, Wayupyonder, Alaska", "(990) 341-2367");
                    //Client clientInfo = new Client(clientName, clientAddress, clientPhone);
                    clientInfo.ShowClientInfo();
                    Console.WriteLine("Client " + clientInfo.ShowClientInfo());
                    //Console.WriteLine("Client " + ShowClientInfo());

                    //Console.WriteLine("Following is your basic Account information: \n");
                    //create another instance of client
                    //Client clientAccountInfo = new Client("Checkin 234059 0002345", "Saving Account: AP 721134 00000381");
                    //clientAccountInfo.ShowAccountInfo();
                    //Console.WriteLine("Client " + clientAccountInfo.ShowAccountInfo());

                    Console.WriteLine("What do you wish to do next?\n");

                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit \n");
                }
                else if (menuSelection == 2)
                {
                    Console.WriteLine("Which Account Balance do you want to view? \n");
                    Console.WriteLine("a. Checking Account Balance");
                    Console.WriteLine("b. Savings Account Balance");
                    Console.WriteLine("Please enter letter here: ");

                }
                else if (menuSelection == 3)
                {
                    Console.WriteLine("To which Account do you want to deposit? \n");
                    Console.WriteLine("a. To Checking Account");
                    Console.WriteLine("b. To Savings Account");
                    Console.WriteLine("Please enter letter here: ");
                }
                else if (menuSelection == 4)
                {
                    Console.WriteLine("From which Account do you want to withdraw? \n");
                    Console.WriteLine("a. From Checking Account");
                    Console.WriteLine("b. From Savings Account\n");
                    Console.WriteLine("Please enter letter here: ");
                }
                else
                {
                    return;
                }

            } while (true);
        }
    }
}
