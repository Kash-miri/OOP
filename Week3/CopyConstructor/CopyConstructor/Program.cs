using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class Program
    {
        class Student
        {
            public Student()
            {
                Console.WriteLine("Copy Constructor");
            }
            public Student(Student n)
            {
                name = n.name;
                fsc = n.fsc;
                ecat= n.ecat;
            }
            public string name;
            public int fsc;
            public int ecat;
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Aleena";
            Student student2 = new Student(student);
            Console.WriteLine(student.name);
            Console.WriteLine(student2.name);
            Console.ReadKey();
        }
    }
}
