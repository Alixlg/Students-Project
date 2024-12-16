using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Students.Tools;

namespace Students.Entities
{
    public class Professor : Person
    {
        public string? Lesson { get; set; }
        public Professor(string fullName, double age, string lesson) : base(fullName, age)
        {
            Lesson = lesson;
        }

        public void Edit()
        {
            TColor.Yellow("<1> Enter fullname : ");
            string fullName = Console.ReadLine() ?? "";
            TColor.Yellow("<2> Enter age : ");
            double age = double.Parse(Console.ReadLine() ?? "");
            TColor.Yellow("<3> Enter lesson : ");
            string lesson = Console.ReadLine() ?? "";

            FullName = fullName;
            Age = age;
            Lesson = lesson;
        }
    }
}