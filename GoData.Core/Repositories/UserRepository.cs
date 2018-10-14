using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GoData.Data.Contexts;
using GoData.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoData.Core.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private DefaultContext _context;

        public UserRepository(DefaultContext context)
        {
            _context = context;
        }
        public Task<User> AddItemAsync(User item)
        {
            throw new NotImplementedException();
        }

        public bool AddItemsAsync(IEnumerable<User> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public User GetItemById<IDType>(IDType Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetItems(Expression<Func<User, bool>> condition)
        {
            return _context.Users.Where(condition).Include(u => u.Roles);
        }
    }
}
