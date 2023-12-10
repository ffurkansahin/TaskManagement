using FurkanSahin.TaskManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Persistance.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(i => i.Name).IsRequired(true);
            builder.Property(i => i.Name).HasMaxLength(200);

            builder.Property(i => i.Surname).IsRequired(true);
            builder.Property(i => i.Surname).HasMaxLength(200);

            builder.Property(i=>i.Password).IsRequired(true);
            builder.Property(i=>i.Password).HasMaxLength(200);

            builder.HasIndex(i=>i.Username).IsUnique(true);
            builder.Property(i=>i.Username).HasMaxLength(200);
            builder.Property(i => i.Username).IsRequired(true);

            builder.Property(i=>i.AppRoleId).IsRequired(true);

            builder.HasMany(i => i.Tasks).WithOne(i => i.AppUser).HasForeignKey(i => i.AppUserId);
            builder.HasMany(i => i.Notifications).WithOne(i => i.AppUser).HasForeignKey(i => i.AppUserId);
        }
    }
}
