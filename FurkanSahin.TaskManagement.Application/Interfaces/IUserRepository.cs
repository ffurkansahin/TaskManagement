using FurkanSahin.TaskManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<AppUser?> GetByFilter(Expression<Func<AppUser, bool>> filter);
    }
}
