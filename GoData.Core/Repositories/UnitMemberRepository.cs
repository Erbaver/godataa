using GoData.Data.Contexts;
using GoData.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoData.Core.Repositories
{
    public class UnitMemberRepository : IRepository<UnitMember>
    {
        private readonly DefaultContext _context;

        public UnitMemberRepository(DefaultContext context)
        {
            _context = context;
            
        }

        public Task<UnitMember> AddItemAsync(UnitMember item)
        {
            throw new NotImplementedException();
        }

        public bool AddItemsAsync(IEnumerable<UnitMember> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UnitMember> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public UnitMember GetItemById<IDType>(IDType Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UnitMember> GetItems(Expression<Func<UnitMember, bool>> condition)
        {
            return _context.UnitMembers.Where(condition).Include(u => u.Unit);
        }

        public UnitMember UpdateItemAsync(UnitMember item)
        {
            throw new NotImplementedException();
        }
    }
}
