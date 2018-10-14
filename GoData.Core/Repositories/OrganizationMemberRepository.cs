using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GoData.Entities.Entities;

namespace GoData.Core.Repositories
{
    public class OrganizationMemberRepository : IRepository<User>
    {
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
            throw new NotImplementedException();
        }
    }
}
