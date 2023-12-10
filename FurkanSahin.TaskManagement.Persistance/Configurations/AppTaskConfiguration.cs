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
    public class AppTaskConfiguration : IEntityTypeConfiguration<AppTask>
    {
        public void Configure(EntityTypeBuilder<AppTask> builder)
        {
            builder.Property(i => i.Priority).IsRequired(true);

            builder.Property(i=>i.AppUserId).IsRequired(true);

            builder.Property(i=>i.Description).IsRequired(true);

            builder.Property(i=>i.Title).IsRequired(true);
            builder.Property(i => i.Title).HasMaxLength(200);


            builder.HasMany(i => i.TaskReports).WithOne(i => i.AppTask).HasForeignKey(i => i.AppTaskId);
        }
    }
}
