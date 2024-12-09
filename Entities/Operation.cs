using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Students.Tools;

namespace Students.Entities
{
    public abstract class Operation
    {
        public static Student GetingStudentData()
        {
            TColor.Yellow("<1> Enter fullname : ");
            string fullName = Console.ReadLine() ?? "";
            TColor.Yellow("<2> Enter age : ");
            double age = double.Parse(Console.ReadLine() ?? "");
            TColor.Yellow("<3> Enter average : ");
            double avg = double.Parse(Console.ReadLine() ?? "");

            return new Student(fullName, age, avg);
        }
        public static Professor GetingProfessorData()
        {
            TColor.Yellow("<1> Enter fullname : ");
            string fullName = Console.ReadLine() ?? "";
            TColor.Yellow("<2> Enter age : ");
            double age = double.Parse(Console.ReadLine() ?? "");
            TColor.Yellow("<3> Enter Lesson : ");
            string lesson = Console.ReadLine() ?? "";

            return new Professor(fullName, age, lesson);
        }
    }
}