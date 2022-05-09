using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public abstract class BankAccount
    {
        protected String? bankAccountName;
        protected float? bankBalance;
        protected String? bankCardNo;
        public BankAccount() { }
        public BankAccount(float bankBalance, String bankCardNo)
        {
            this.bankBalance = bankBalance;
            this.bankCardNo = bankCardNo;
        }
        public BankAccount(float bankBalance, String bankCardNo, String bankAccountName)
        {
            this.bankBalance = bankBalance;
            this.bankCardNo = bankCardNo;
            this.bankAccountName = bankAccountName;
        }
        public String BankAccountName
        {
            get { return bankAccountName; }
            set { bankAccountName = value; }
        }
        public float BankBalance
        {
            get { return (float)bankBalance; }
            set { bankBalance = value; }
        }
        public String BankCardNo
        {
            get { return bankCardNo; }
            set { bankCardNo = value; }
        }
        public abstract void printBank();
    }
}
