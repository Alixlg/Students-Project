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
        public int Id { get; set; }
        public string? FullName { get; set; }
        public double Age { get; set; }
        public Person(string fullName, double age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}