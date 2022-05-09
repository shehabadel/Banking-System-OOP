using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public static class Constants
    {
        public const String CIBPATTERN = @"^[a-zA-Z0-9]{3}-[a-zA-Z0-9]{3}-[a-zA-Z0-9]{3}-[a-zA-Z0-9]{2}$";
        public const String QNBPATTERN = @"^[a-zA-Z0-9]{4}-[a-zA-Z0-9]{4}-[a-zA-Z0-9]{4}$";
        public const String CIBTXTPATH = @"C:\Users\user\source\repos\Bank\Bank\Data\cib.txt";
        public const String QNBTXTPATH = @"C:\Users\user\source\repos\Bank\Bank\Data\qnb.txt";
    }
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class AuthorAttribute:System.Attribute
    {
        private string name;
        private string version;
        public AuthorAttribute(string name, string version)
        {
            this.name = name;
            this.version = version;
        }
    }
}
