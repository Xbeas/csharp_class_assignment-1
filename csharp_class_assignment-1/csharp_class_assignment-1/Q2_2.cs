using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_class_assignment_1
{
    class Q2_2
    {
        static void Main()
        {
            Accounts A = new Accounts{
                acc_nu = 1,
                acc_type = "Salary",
                balance = 10000,
                cust_name = "TEST NAME"
            };

            do
            { Console.WriteLine("\n=====================\n Choices: \n 1. Debit from account\n 2. Credit from account Show balance \n Enter a choice Numbers: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("\n Enter debit amt: ");

                        A.amt = Convert.ToDouble(Console.ReadLine());
                            A.debit(A.amt);
                            A.accept(A.acc_nu, A.cust_name, A.acc_type,"Debit", A.amt);

                    }
                    break;
                    case 2:
                        {
                            Console.WriteLine("\n Enter credit amt: ");

                            A.amt = Convert.ToDouble(Console.ReadLine());
                            A.credit(A.amt);
                            A.accept(A.acc_nu, A.cust_name, A.acc_type, "Credit", A.amt);
                        }
                        break;
                    case 3:
                    {
                        A.show();
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;
            } 
            
            } while (true) ;
        }
    }

    class Accounts
    {
        public double balance;
        public int acc_nu;
        public string cust_name;
        public string acc_type;
        public string tranc_type;
        public double amt;

        public void accept(int accn, string cust, string acc_t, string tranc_t, double amtt)
        {
            acc_nu = accn; cust_name = cust; acc_type = acc_t; tranc_type = tranc_t; amt = amtt;
        }

        public void credit(double money)
        {
            balance += money;
        }
        public void debit(double money)
        {
            balance -= money;
        }

        public void show()
        {
            Console.WriteLine("\n Account Number:" + acc_nu);
            Console.WriteLine("\n Customer Name:" + cust_name);
            Console.WriteLine("\n Account type:" + acc_type);
            Console.WriteLine("\n Transaction type:" + tranc_type);
            Console.WriteLine("\n Amount:" + amt);
            Console.WriteLine("\n Balance:" + balance);
        }


    }
}
