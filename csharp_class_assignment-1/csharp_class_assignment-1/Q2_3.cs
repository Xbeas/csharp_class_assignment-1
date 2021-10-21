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

            Console.WriteLine("Enter five subjects marks");
            for(int i = 0; i < 5; i++)
            {
                A.marks[i] = int.Parse(Console.ReadLine());
                
            }
             A.displayresult(A.marks);
            A.displaydata();

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
        int total=0;

        public Students(int _rollno, string _name, string _branch, string _cclass, int _sem)
        {
            rollno = _rollno; name = _name; branch = _branch; cclass = _cclass; sem = _sem;
        }

        public void displayresult(int[] marks)
        {
            bool f2 = true;
            int avg;
            for(int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                    f2 = false;
                else
                    total = total + marks[i];
            }
            avg = total / 5;
            if(f2==false || avg<50)
                Console.WriteLine("You are failed");
            else
                Console.WriteLine("You are passed");

        }
        public void displaydata()
        {
            Console.WriteLine("Roll Number: " + rollno);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Class: " + cclass);
            Console.WriteLine("Semester: " +sem);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Total Marks: " + total);
            
        }

    }
}
