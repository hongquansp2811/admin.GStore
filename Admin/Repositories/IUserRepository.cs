using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        IQueryable<User> GetUser();
    }

    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository()
        {
            this._dbContext = base._dbContext;
        }

        public IQueryable<User> GetUser()
        {
            return _dbContext.Users;
        }
    }
}