using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_class_assignment_1
{
    class Q2_3
    {
        static void Main()
        {
            Students A = new Students
            (
               1, "TEST NAME","CS", "TOC",3
            );

            do
            {
                Console.WriteLine("\n=====================\n Choices: \n 1. Debit from account\n 2. Credit from account Show balance \n Enter a choice Numbers: ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("\n Enter debit amt: ");

                            A.amt = Convert.ToDouble(Console.ReadLine());
                            A.debit(A.amt);
                            A.accept(A.acc_nu, A.cust_name, A.acc_type, "Debit", A.amt);

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

            } while (true);
        }
    }

    class Students
    {
        public int[] marks = new int[5];
        public int rollno;
        public string name;
        public string branch;
        public string cclass;
        public int sem;

        public Students(int _rollno, string _name, string _branch, string _cclass, int _sem)
        {
            rollno = _rollno; name = _name; branch = _branch; cclass = _cclass; sem = _sem;
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
