using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_class_assignment_1
{


    class Student
    {
        int rollno;
        String sname;
        double eng;
        double mat;
        double sci;
        double sum;
        double p;

        public void input()
        {
            Console.WriteLine("Enter your roll no");
            this.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name");
            this.sname = (Console.ReadLine());
            Console.WriteLine("Marks in science");
            this.sci = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Marks in english");
            this.eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Marks in maths");
            this.mat = Convert.ToDouble(Console.ReadLine());

        }
        public void total()
        {
            sum = eng + mat + sci;
            Console.WriteLine("Total Marks: " + sum);
        }
        public void percentage()
        {
            p = (sum * 100) / 300;

            Console.WriteLine("Total Percentage: " + p);
        }
    }

class Q2_7
    {
        static void Main()
        {
            Student a = new Student();
            a.input();
            a.total();
            a.percentage();
        }
    }
}