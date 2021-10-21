using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_class_assignment_1
{


    class Bank
    {
        int bal;
        public int amt;
        String dname;
        int acc_no;
        String acc_type;

        public Bank(int acc_no, String dname, String acc_type, int bal)
        {
            this.acc_no = acc_no;
            this.dname = dname;
            this.acc_type = acc_type;
            this.bal = bal;
        }
        public void withdraw(int w)
        {
            if (bal > w)
                bal -= w;
            else
                Console.WriteLine("Your account is out of balance");
        }

        public void deposit(int d)
        {
            bal += d;
        }

        public void display()
        {
            Console.WriteLine("Depositor name: " + dname);
            Console.WriteLine("Balance: " + bal);

        }
    }
    class Q2_6
    { 
        static void Main()
        {
            Bank a = new Bank(00001, "TEST", "SalaryAccount", 10000);
            Console.WriteLine("Enter Transaction type?(d/w)");
            String choice = Console.ReadLine();
            if (choice.Equals("d"))
            {
                Console.WriteLine("Enter amount to deposit");
                a.amt = int.Parse(Console.ReadLine());
                a.deposit(a.amt);
            }
            if (choice.Equals("w"))
            {
                Console.WriteLine("Enter amount to Withdraw");
                a.amt = int.Parse(Console.ReadLine());
                a.withdraw(a.amt);
            }
            a.display();

        }
    }
}