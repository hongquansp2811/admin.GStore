using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Repositories
{
    internal interface ISystemRoleRepository : IBaseRepository<Role>
    {
        IQueryable<Role> GetRole();
    }

    public class SystemRoleRepository : BaseRepository<Role>, ISystemRoleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SystemRoleRepository()
        {
            this._dbContext = base._dbContext;
        }

        public IQueryable<Role> GetRole()
        {
            return _dbContext.Roles;
        }
    }
}
