using self1.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using self1.NewFolder1;

namespace self1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> list = new List<int>()
            {
                1,5,8,6,7,3,4,2,9
            };
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i+"  ");
            }
            Console.ReadKey();*/

            /*Student s1 = new Student("Aleena",15,120);
            Student s2 = new Student("Inam", 20, 140);
            Student s3 = new Student("Ayesha", 25, 100);
            List<Student> list = new List<Student>() { s1, s2, s3 };
            List<Student> sortedList = list.OrderBy(o => o.ecat).ToList();
            Console.WriteLine("Name \t RollNumber \t EcatMarks");
            foreach(Student s in sortedList)
            {
                Console.WriteLine(s.name + "\t" + s.rollno + "\t" + s.ecat);
            }
            Console.ReadKey();*/

            /*Student s1 = new Student("Aleena", 15, 120);
            Student s2 = new Student("Inam", 20, 140);
            Student s3 = new Student("Ayesha", 25, 100);
            List<Student> list = new List<Student>()
            { s1,s2,s3};
            List<Student> sortedList = list.OrderByDescending(O => O.ecat).ToList();
            Console.WriteLine("Name \t RollNumber \t EcatMarks");
            foreach (Student s in sortedList)
            {
                Console.WriteLine(s.name + "\t" + s.rollno + "\t" + s.ecat);
            }
            Console.ReadKey(); */

            /* List<string> list = new List<string>()
             {
                 "Aleena", "Inam", "Amina", "Aleem"
             };
             list.Sort();
             foreach(string s in list)
             {
                 Console.WriteLine(s);
             }
             Console.ReadKey();*/

            List<float> list = new List<float>()
            {
                1.5f,2.2f,3.6f,9.9f
            };
            list.Sort();
            foreach (float f in list)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}
