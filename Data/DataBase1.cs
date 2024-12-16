using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Students.Entities;

namespace Students.Data
{
    public class DataBase1 : DbContext
    {
        public DbSet<Student>? Students { get; set; }
        public DbSet<Professor>? Professors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = database1.sqlite");
        }
    }
}