using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Object
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // Constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
