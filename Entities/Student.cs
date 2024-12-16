using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Students.Tools;

namespace Students.Entities
{
    public class Student : Person
    {
        public double Avg { get; set; }
        public bool IsActive { get; set; }
        public Student(string fullName, double age, double avg) : base(fullName, age)
        {
            Avg = avg;
        }

        public void Edit()
        {
            TColor.Yellow("<1> Enter fullname : ");
            string fullName = Console.ReadLine() ?? "";
            TColor.Yellow("<2> Enter age : ");
            double age = double.Parse(Console.ReadLine() ?? "");
            TColor.Yellow("<3> Enter average : ");
            double avg = double.Parse(Console.ReadLine() ?? "");

            FullName = fullName;
            Age = age;
            Avg = avg;
        }
    }
}