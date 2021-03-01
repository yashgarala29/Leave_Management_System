using Leave_Management_System.Models.Class;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Leave_Management_System.Models.ViewModel;


namespace Leave_Management_System.Models.Context
{
    public class LeaveDbContext : IdentityDbContext
    {
        public LeaveDbContext(DbContextOptions<LeaveDbContext> options)
            : base(options)
        {

        }
        public DbSet<AllUser> AllUser { get; set; }
        public DbSet<LeaveHistory> LeaveHistory { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<leaveType> leaveType { get; set; }
        public DbSet<LeaveAllocation> leaveAllocation { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }



       
    }
}
