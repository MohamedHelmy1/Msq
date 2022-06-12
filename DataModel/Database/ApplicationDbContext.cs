using DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            

        }
        public DbSet<User> user { get; set; }
        public DbSet<User_Standerd> User_Standerd { get; set; }
        public DbSet<Standard> Standard { get; set; }
        public DbSet<subCatogery> subCatogery { get; set; }
        public DbSet<Catogery> Catogery { get; set; }
        public DbSet<StanderQueqsion> StanderQueqsion { get; set; }
        

    }
}
