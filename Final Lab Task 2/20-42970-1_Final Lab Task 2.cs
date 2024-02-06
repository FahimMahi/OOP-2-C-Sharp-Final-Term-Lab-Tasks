using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask2
{
    interface BasicBankingInterface
    {
        bool deposit(int amount);
        bool withdraw(int amount);
    }
    internal class BankingAccount : BasicBankingInterface
    {
        private string accName;
        private string acctype;
        private int accBalance;
        public BankingAccount(string aName, string atype, int aBalance)
        {
            this.AccName = aName;
            this.Acctype = atype;
            this.AccBalance = aBalance;
        }
        public string AccName
        {
            get { return accName; }
            set
            {
                accName = value;
            }
        }
        public string Acctype {
            get { return acctype; }
            set { acctype = value; }
        }
        public int AccBalance
        {
            get
            {
                return accBalance;
            }
            set
            {
                accBalance = value;
            }
        }

        public bool deposit(int amount)
        {
            AccBalance = AccBalance + amount;
            return true;
        }

        public bool withdraw(int amount)
        {
            if (Acctype == "Current")
            {
                return AccBalance >= amount;
            }
            if (Acctype == "Saving")
            {
                return AccBalance * .8 >= amount;
            }
            if (Acctype == "Overhead")
            {
                return AccBalance < amount;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankingAccount bankingAccount = new BankingAccount("Mahi", "Current", 3000);
            Console.WriteLine("1st:\nAccounts Owner Name: " + bankingAccount.AccName);
            Console.WriteLine("Accounts Type: " + bankingAccount.Acctype);
            Console.WriteLine("Accounts Balance: " + bankingAccount.AccBalance);

            BankingAccount bankingAccount1 = new BankingAccount("Fahim", "Saving", 5000);
            Console.WriteLine("2nd:\nAccounts Owner Name: " + bankingAccount1.AccName);
            Console.WriteLine("Accounts Type: " + bankingAccount1.Acctype);
            Console.WriteLine("Accounts Balance: " + bankingAccount1.AccBalance);

            BankingAccount bankingAccount2 = new BankingAccount("Mun", "Overhead", 8000);
            Console.WriteLine("3rd:\nAccounts Owner Name: " + bankingAccount2.AccName);
            Console.WriteLine("Accounts Type: " + bankingAccount2.Acctype);
            Console.WriteLine("Accounts Balance: " + bankingAccount2.AccBalance);
            Console.WriteLine();

            if (bankingAccount.deposit(2000))
            {
                Console.WriteLine("1st: Deposited");
            }
            if (bankingAccount.withdraw(5000))
            {
                Console.WriteLine("Withdrawn");
            }
            if(bankingAccount1.withdraw(1500))
            {
                Console.WriteLine("2nd: Can't withdraw because you are in Saving Mode. You can withdraw Max 80%");
            }
            if (bankingAccount2.withdraw(9000))
            {
                Console.WriteLine("3rd: Withdrawn");
            }
        }
    }
}
