using DataAcessLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=InfoAssigmentDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Teacher>Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
