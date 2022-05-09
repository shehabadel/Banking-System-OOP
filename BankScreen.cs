using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public abstract class BankScreen
    {
        protected BankAccount bankAccount;
        public BankScreen() { }
        public BankScreen(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }
        public abstract void ShowLoginPage();
    }

    public class CIBScreen: BankScreen
    {
        public CIBScreen() { }
        public CIBScreen(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }
        public override void ShowLoginPage()
        {
            try
            {
                Console.WriteLine("Welcome!\nYour current balance is " + bankAccount.BankBalance+"$");
                Console.WriteLine("Hello, "+bankAccount.BankAccountName+"!");
            }catch(Exception e)
            {
                Console.WriteLine("No balance can be found!");
            }
            bool choiceFlag = false;
            while (!choiceFlag)
            {
                Console.WriteLine("CIB - Choose from these options\n 1-> Debit\n 2-> Enter Loan Number\n 3-> Withdrawal\n 4-> Transfer to another account\n 5-> Exit\n");
                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You chose Debit");
                        break;
                    case 2:
                        Console.WriteLine("You chose to enter Loan Number");
                        break;
                    case 3:
                        Console.WriteLine("You chose to withdraw");
                        break;
                    case 4:
                        Console.WriteLine("You chose to transfer to another account");
                        break;
                    case 5:
                        Console.WriteLine("Exiting now");
                        choiceFlag = true;
                        break;
                    default:
                        Console.WriteLine("You did not choose a valid option please try again");
                        break;
                }
            }
        }
    }
    public class QNBScreen: BankScreen
    {
        public QNBScreen() { }
        public QNBScreen(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }
        public override void ShowLoginPage()
        {
            try
            {
                Console.WriteLine("Welcome!\nYour current balance is " + bankAccount.BankBalance + "$");
                Console.WriteLine("Hello, " + bankAccount.BankAccountName + "!");
            }
            catch (Exception e)
            {
                Console.WriteLine("No balance can be found!");
            }
            bool choiceFlag = false;
            while (!choiceFlag)
            {
                Console.WriteLine(@"QNB - Choose from these options
                1-> Debit
                2-> Enter Loan Number
                3-> Withdrawal
                4-> Transfer to another account
                5-> Exit");
                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You chose Debit");
                        break;
                    case 2:
                        Console.WriteLine("You chose to enter Loan Number");
                        break;
                    case 3:
                        Console.WriteLine("You chose to withdraw");
                        break;
                    case 4:
                        Console.WriteLine("You chose to transfer to another account");
                        break;
                    case 5:
                        Console.WriteLine("Exiting now");
                        choiceFlag = true;
                        break;
                    default:
                        Console.WriteLine("You did not choose a valid option please try again");
                        break;
                }
            }
        }
    }
}
