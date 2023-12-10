using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Domain.Entities
{
    public class AppUser : BaseEntity
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int AppRoleId { get; set; }
        //Navigation Properties
        public AppRole? Role { get; set; }
        public List<AppTask>? Tasks { get; set; }
        public List<Notification>? Notifications { get; set; }
    }
}
