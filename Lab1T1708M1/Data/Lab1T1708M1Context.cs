using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab1T1708M1.Models
{
    public class Lab1T1708M1Context : DbContext
    {
        public Lab1T1708M1Context (DbContextOptions<Lab1T1708M1Context> options)
            : base(options)
        {
        }

        public DbSet<Lab1T1708M1.Models.Student> Student { get; set; }
    }
}
