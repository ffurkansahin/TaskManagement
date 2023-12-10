﻿using FurkanSahin.TaskManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Persistance.Configurations
{
    public class TaskReportConfiguration : IEntityTypeConfiguration<TaskReport>
    {
        public void Configure(EntityTypeBuilder<TaskReport> builder)
        {
            builder.Property(i => i.Detail).IsRequired();

            builder.Property(i => i.Definition).IsRequired();
            builder.Property(i => i.Definition).HasMaxLength(500);
            
            builder.Property(i=>i.AppTaskId).IsRequired();



        }
    }
}
