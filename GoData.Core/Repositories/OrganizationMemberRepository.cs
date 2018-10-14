using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GoData.Entities.Entities;

namespace GoData.Core.Repositories
{
    public class OrganizationMemberRepository : IRepository<OrganizationMember>
    {
        public Task<OrganizationMember> AddItemAsync(OrganizationMember item)
        {
            throw new NotImplementedException();
        }

        public bool AddItemsAsync(IEnumerable<OrganizationMember> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganizationMember> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public OrganizationMember GetItemById<IDType>(IDType Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganizationMember> GetItems(Expression<Func<OrganizationMember, bool>> condition)
        {
            throw new NotImplementedException();
        }
    }
}
