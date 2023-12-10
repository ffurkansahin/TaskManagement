using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Domain.Entities
{
    public class Priority : BaseEntity
    {
        public string Definition { get; set; } = null!;
        //Navigation property
        public List<AppTask>? Tasks { get; set; }
    }
}
