using System;

namespace rakesh_team_assesment2
{
    class Bank
    {
        private string bank_name;
        public void setBank_name(string b_name)
        {
            bank_name = b_name;
        }
        public string getBank_name()
        {
            return bank_name;
        }
    }
    class Bank_Account
    {

        private string name;
        private double balance;
        private string accounttype;
        private string mobilenumber;
        private string branch;

        public Bank_Account(string name, double balance, string accounttype, string mobilenumber, string branch)
        {

            this.name = name;
            this.balance = balance;
            this.accounttype = accounttype;
            this.mobilenumber = mobilenumber;
            this.branch = branch;
        }

        public void GetInfo()
        {
            Random rand = new Random();
            Console.WriteLine("WELCOME TO ICICI BANK");
            Console.WriteLine("Account Holder: " + name);
            Console.WriteLine("Current Balance: " + balance);
            Console.WriteLine("Account Type: " + accounttype);
            Console.WriteLine("Account Number: " + rand.Next());
            Console.WriteLine("mobile number: " + mobilenumber);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("__:");
            Console.WriteLine();
        }
        public void Credit_Money()
        {
            Console.WriteLine("enter amount you want to add:");
            double money = float.Parse(Console.ReadLine());
            balance = balance + money;
            Console.WriteLine("Rs. " + money + " is credited to your bank Account\n");
            Console.WriteLine("check balance?\n1 for yes.\n0 for no.\n");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
                Console.WriteLine("Current Balance: " + this.balance + "\n");
            Console.WriteLine("_");
            Console.WriteLine();
        }
        public void Debit_Money()
        {
            Console.WriteLine("enter the amount you want to withdraw:");
            double money = float.Parse(Console.ReadLine());
            balance = balance - money;
            Console.WriteLine("Rs. " + money + " is debited from your bank Account\n");
            Console.WriteLine("check balance?\n1 for yes.\n0 for no.\n");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
                Console.WriteLine("Current Balance: " + this.balance + "\n");
            Console.WriteLine("__");
            Console.WriteLine();
        }
        public void display()
        {
        }
    }
    abstract class Account_Type
    {
        public abstract void acopening_fee();
        public abstract void services();
    }
    class savings_account : Account_Type
    {
        public override void services()
        {
            Console.WriteLine("this is seving account details");
            Console.WriteLine("debit card");
            Console.WriteLine("persnal account");
            Console.WriteLine();
        }
        public override void acopening_fee()
        {
            Console.WriteLine("no acpening fee");
        }
    }
    class current_account : Account_Type
    {
        public override void services()
        {
            Console.WriteLine("for bussines things");
            Console.WriteLine("credit card");
            Console.WriteLine("global use");
            Console.WriteLine("large amount manages");
            Console.WriteLine();
        }
        public override void acopening_fee()
        {
            Console.WriteLine("the fee to open account is 500");
        }

    }
    class Client
    {
        static void Main(string[] args)
        {

            Bank b = new Bank();
            Console.WriteLine("enter the bank name:");
            string s = Console.ReadLine();
            b.setBank_name(s);
            Console.WriteLine("WELCOME TO " + b.getBank_name() + "");
            Console.WriteLine("Enter Accountholder name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter amount: ");
            double amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter mobile No: ");
            string mobileno = Console.ReadLine();
            Console.WriteLine("Enter Account type: ");
            string accounttype = Console.ReadLine();
            Console.WriteLine("enter branch:");
            string branch = Console.ReadLine();

            Bank_Account a = new Bank_Account(name, amount, accounttype, mobileno, branch);
            Console.WriteLine("Your Account has been created sucessfully\n");
            savings_account sv = new savings_account();
            current_account cv = new current_account();

            int n;
            do
            {
                Console.WriteLine("Enter 0 to view current status.\nEnter 1 to deposit money.\nEnter 2 to withdraw money.\n3.services of savings account.\n4.services of current account.\n5 to close");

                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        a.GetInfo();
                        break;
                    case 1:
                        a.Credit_Money();
                        break;
                    case 2:
                        a.Debit_Money();
                        break;
                    case 3:
                        sv.services();
                        break;
                    case 4:
                        cv.services();
                        break;
                    case 5:
                        Console.WriteLine("*Thanks for choosing " + b.getBank_name() + "*");
                        break;
                }
            } while (n != 5);
        }
    }
}
