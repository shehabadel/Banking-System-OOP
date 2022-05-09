using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace Bank
{
    public static class BankAccountUtilities
    {
        //TODO add another parameter to CheckDataInDataFile
        //that gets the path link to cib or qnb text file
        //based on the banktype
        private static String CheckDataInDataFile(String cardNo, String dataPath)
        {
            String cardData = "";
            String[] lines= { };
            try
            {

                lines = System.IO.File.ReadAllLines(dataPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
                foreach(String line in lines)
                {
                    if(line.Contains(cardNo))
                    {
                        cardData = line;
                        return cardData;
                        
                    }
                    else
                    {
                        continue;
                    }
                }
                
            return "NF";
        }
        private static bool CheckCardNumberPattern(String cardNo, ref BankAccount bank)
        {
            
            if (cardNo.StartsWith("0"))
            {
                Console.WriteLine("A card number cannot start with zero!");
                return false;
            }
            if (Regex.Match(cardNo, Constants.CIBPATTERN).Success)
            {
                Console.WriteLine("This is a CIB Account - Welcome");
                Console.WriteLine("CIB\t" + cardNo);
                bank = new CIB(cardNo);
                return true;
            }
            else if (Regex.Match(cardNo, Constants.QNBPATTERN).Success)
            {
                Console.WriteLine("This is a QNB Account - Welcome");
                Console.WriteLine("QNB\t" + cardNo);
                bank = new QNB(cardNo);
                return true;
            }
            else
            {
                Console.WriteLine("This is not a recognized Bank!");
                return false;
            }
        }
        private static void AssignData(String bankData, ref BankAccount bankAccount)
        {
            //Card Number start,end indexes and length
            int startIndexN = bankData.IndexOf("_") + 1;
            int endIndexN = bankData.IndexOf("!");
            int lengthN = endIndexN - startIndexN;

            //Balance start,end indexes and length
            int startIndexB = bankData.IndexOf("%") + 1;
            int endIndexB = bankData.IndexOf("$");
            int lengthB = endIndexB - startIndexB;

            
            String floatData = bankData.Substring(startIndexB, lengthB);
            float dataBalance = float.Parse(floatData);
            String dataName = bankData.Substring(startIndexN, lengthN);
            bankAccount.BankBalance = dataBalance;
            bankAccount.BankAccountName = dataName;
        }
    public static bool Verification(String cardNo, ref BankAccount bankAccount)
        {
            //TODO add another parameter to CheckDataInDataFile
            //that gets the path link to cib or qnb text file
            //based on the banktype
            bool patternCheck = CheckCardNumberPattern(cardNo, ref bankAccount);
            Type bankType = bankAccount.GetType();
            String dataPath = bankType.Equals(typeof(QNB)) ? Constants.QNBTXTPATH : Constants.CIBTXTPATH;

            String bankData = CheckDataInDataFile(cardNo, dataPath);
            bool dataCheck = bankData == "NF" ? false : true;
            if(patternCheck && dataCheck)
            {
                AssignData(bankData, ref bankAccount);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
