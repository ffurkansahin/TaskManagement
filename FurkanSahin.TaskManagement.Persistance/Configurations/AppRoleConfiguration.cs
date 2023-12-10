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
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.Property(i => i.Definition).IsRequired(true);
            builder.Property(i => i.Definition).HasMaxLength(150);

            builder.HasMany(i => i.Users).WithOne(i => i.Role).HasForeignKey(i => i.AppRoleId);
        }
    }
}
