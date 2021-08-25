using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class StudentDbContext : DbContext
    {
        public DbSet<StudentEntity> StudentEntity { get; set; }
        public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        {

        }
    }
}
