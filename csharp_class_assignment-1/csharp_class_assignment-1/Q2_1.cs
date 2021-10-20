using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_class_assignment_1
{
    class Q2_1
    {

        static void Main()
        {
            Payments p = new Payments();
            do
            { Console.WriteLine("\n=====================\n Choices: \n 1. Pay\n 2. Show balance \n Enter a choice Numbers: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("\n Enter monthly payment: ");

                        p.pay_installment(Convert.ToDouble(Console.ReadLine()));
                        p.show();

                    }
                    break;
                case 2:
                    {
                        p.show();
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;
            } 
            
            } while (true) ;
        }
    }

    class Payments
    {
        public double balance;

        public Payments() { balance = 1000; }

        public double pay_installment(double money)
        {
            double interset = (1.5 / 100) * balance;
            balance += interset - money;
            return balance;
        }

        public void show()
        {
            Console.WriteLine("\n Balance:"+ balance);
        }


    }
}
