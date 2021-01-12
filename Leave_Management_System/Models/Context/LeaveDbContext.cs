using Leave_Management_System.Models.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.Context
{
    public class LeaveDbContext: DbContext
    {
        public LeaveDbContext(DbContextOptions<LeaveDbContext> options)
            : base(options)
        {

        }
        public DbSet<HOD> HOD { get; set; }
        public DbSet<Registrar> Registrar { get; set; }
        public DbSet<Dean> Dean { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<LeaveHistory> LeaveHistory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }
    }
}
