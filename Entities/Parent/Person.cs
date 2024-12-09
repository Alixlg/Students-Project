using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Students.Tools;

namespace Students.Entities
{
    public abstract class Person
    {
        public static int _professorIdCounter { get; set; } = 1001;
        public static int _studentIdCounter { get; set; } = 1001;
        public int Id { get; set; }
        public string? FullName { get; set; }
        private double _age;
        public double Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 120)
                {
                    _age = value;
                    TColor.Green("<Successfully added !> \n");
                }
                else
                {
                    TColor.Red("Error : Invalid data!");
                }
            }
        }
        public Person(string fullName, double age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}