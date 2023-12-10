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
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(i => i.Description).IsRequired();
            builder.Property(i => i.Description).HasMaxLength(500);

            builder.Property(i=>i.AppUserId).IsRequired();

            builder.Property(i => i.State).IsRequired();
        }
    }
}
