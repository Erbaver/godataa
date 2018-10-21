using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GoData.Data.Contexts;
using GoData.Entities.Entities;

namespace GoData.Core.Repositories
{
    public class OrganizationRepository : IRepository<Organization>
    {
        private readonly DefaultContext _context;

        public OrganizationRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Organization> AddItemAsync(Organization item)
        {
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public bool AddItemsAsync(IEnumerable<Organization> items)
        {
            throw new System.NotImplementedException();
        }


        public Organization GetItemById<IDType>(IDType Id)
        {
            var id = Int32.Parse(Id.ToString());
            return _context.Organizations.Single(o => o.Id == id);

        }

        public IEnumerable<Organization> GetAllItems()
        {
            return _context.Organizations;
        }

     
        public IEnumerable<Organization> GetItems(Expression<Func<Organization, bool>> condition)
        {
           return  _context.Organizations.Where(condition);
        }

        public Organization UpdateItemAsync(Organization item)
        {
            throw new NotImplementedException();
        }
    }
}
