using FurkanSahin.TaskManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Persistance.Context
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext(DbContextOptions<TaskManagementContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppRole>().Property(i=>i.Definition).HasMaxLength(100);
            


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<AppTask> Tasks { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<TaskReport> TaskReports { get; set; }
    }
}
