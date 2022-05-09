using System;

namespace Bank
{
    [Author("ShehabAdel", "1.0")]
    class Program
    {
        
        static void Main(string[] args)
        {

            BankAccount bankAccount=default;
            String cardNumber = "";
            bool loginFlag = false;
            int loginCounter = 0;
            while (!loginFlag)
            {
                Console.WriteLine("Please enter a valid card number: ");
                cardNumber = Console.ReadLine();
                loginFlag = BankAccountUtilities.Verification(cardNumber, ref bankAccount);
                if(++loginCounter==3)
                {
                    Console.WriteLine("You have reached 3 times!! Please try again later!");
                    return;
                }
            }
            Type bankType = bankAccount.GetType();

            if(bankType.Equals(typeof(CIB)))
            {
                CIBScreen bankScreen = new CIBScreen(bankAccount);
                bankScreen.ShowLoginPage();
            }
            else if(bankType.Equals(typeof(QNB)))
            {
                QNBScreen bankScreen = new QNBScreen(bankAccount);
                bankScreen.ShowLoginPage();
            }
            else
            {
                Console.WriteLine("Cannot reach here since there are no other bank accounts defined.");
            }
        }
    }
}
