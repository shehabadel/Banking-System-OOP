using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Bank
{
    class CIB : BankAccount
    {
        private String cibLoanNumber;

        public CIB() { }
        public CIB(String bankCardNo)
        {
            this.bankCardNo = bankCardNo;
        }
        public CIB(float bankBalance, String bankCardNo) {

            this.bankBalance = bankBalance;
            this.bankCardNo = bankCardNo;
           
        }
        
        public override void printBank()
        {
            Console.WriteLine("This is the CIB Bank, Welcome!");
        }
    }
    class QNB: BankAccount
    {
        private String qnbUtilityNumber;

        public QNB() { }
        public QNB(String bankCardNo)
        {
            this.bankCardNo = bankCardNo;
        }
        public QNB(float bankBalance, String bankCardNo)
        {
            this.bankBalance = bankBalance;
            this.bankCardNo = bankCardNo;

        }

        public override void printBank()
        {
            Console.WriteLine("This is the QNB Bank, Welcome!");
        }
    }
}
