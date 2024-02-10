using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self1.NewFolder1
{
    internal class Student
    {
        public Student(string name, int rollno, int ecat)
        {
            this.name= name;
            this.rollno= rollno;
            this.ecat= ecat;
        }

        public string name;
        public int rollno;
        public int ecat;
    }
}
