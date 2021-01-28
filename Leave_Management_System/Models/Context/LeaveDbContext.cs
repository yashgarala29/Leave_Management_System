using Leave_Management_System.Models.Class;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leave_Management_System.Models.ViewModel;

namespace Leave_Management_System.Models.Context
{
    public class LeaveDbContext: IdentityDbContext
    {
        public LeaveDbContext(DbContextOptions<LeaveDbContext> options)
            : base(options)
        {

        }
        public DbSet<AllUser> AllUser { get; set; }
        //public DbSet<HOD> HOD { get; set; }
        //public DbSet<Registrar> Registrar { get; set; }
        //public DbSet<Dean> Dean { get; set; }
        //public DbSet<Faculty> Faculty { get; set; }
        //public DbSet<LeaveHistory> LeaveHistory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }
        //public DbSet<HOD> HOD { get; set; }
        //public DbSet<Registrar> Registrar { get; set; }
        //public DbSet<Dean> Dean { get; set; }
        //public DbSet<Faculty> Faculty { get; set; }
        //public DbSet<LeaveHistory> LeaveHistory { get; set; }
        public DbSet<Leave_Management_System.Models.Class.LeaveHistory> LeaveHistory { get; set; }
        //public DbSet<HOD> HOD { get; set; }
        //public DbSet<Registrar> Registrar { get; set; }
        //public DbSet<Dean> Dean { get; set; }
        //public DbSet<Faculty> Faculty { get; set; }
        //public DbSet<LeaveHistory> LeaveHistory { get; set; }
        public DbSet<Leave_Management_System.Models.ViewModel.LeaveRequest> LeaveRequest { get; set; }
        //public DbSet<HOD> HOD { get; set; }
        //public DbSet<Registrar> Registrar { get; set; }
        //public DbSet<Dean> Dean { get; set; }
        //public DbSet<Faculty> Faculty { get; set; }
        //public DbSet<LeaveHistory> LeaveHistory { get; set; }
        public DbSet<Leave_Management_System.Models.ViewModel.OwnProfile> OwnProfile { get; set; }
        //public DbSet<HOD> HOD { get; set; }
        //public DbSet<Registrar> Registrar { get; set; }
        //public DbSet<Dean> Dean { get; set; }
        //public DbSet<Faculty> Faculty { get; set; }
        //public DbSet<LeaveHistory> LeaveHistory { get; set; }
        public DbSet<Leave_Management_System.Models.ViewModel.DeleteLeave> DeleteLeave { get; set; }
    }
}
