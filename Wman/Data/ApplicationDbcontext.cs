using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wman.Models;

namespace Wman.Data
{              
    public class ApplicationDbcontext :DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }


        public DbSet<TableOfWman> Tables { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
