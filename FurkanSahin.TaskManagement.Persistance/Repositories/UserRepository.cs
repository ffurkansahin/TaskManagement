using FurkanSahin.TaskManagement.Application.Interfaces;
using FurkanSahin.TaskManagement.Domain.Entities;
using FurkanSahin.TaskManagement.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FurkanSahin.TaskManagement.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskManagementContext _context;

        public UserRepository(TaskManagementContext context)
        {
            _context = context;
        }

        public async Task<AppUser?> GetByFilter(Expression<Func<AppUser,bool>> filter)
        {
            return await this._context.Users.SingleOrDefaultAsync(filter);
        }
    }
}
