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
    public class PriorityConfiguration : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.Property(i => i.Definition).IsRequired();
            builder.Property(i => i.Definition).HasMaxLength(250);

            builder.HasMany(i=>i.Tasks).WithOne(i=>i.Priority).HasForeignKey(i=>i.PriorityId);
        }
    }
}
