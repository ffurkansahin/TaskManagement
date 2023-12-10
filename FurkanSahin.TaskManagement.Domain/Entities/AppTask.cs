using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Domain.Entities
{
    public class AppTask : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int AppUserId { get; set; }
        public int PriorityId { get; set; }
        //Lookup Table ?
        public bool State { get; set; }

        //Navigation Properties
        public AppUser? AppUser { get; set; }
        public Priority? Priority { get; set; }
        public List<TaskReport>? TaskReports { get; set; }
    }
}
