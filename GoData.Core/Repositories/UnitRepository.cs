using GoData.Data.Contexts;
using GoData.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoData.Core.Repositories
{
    public class UnitRepository : IRepository<Unit>
    {
        private DefaultContext _context;

        public UnitRepository(DefaultContext context)
        {
            _context = context;
        }
        public async Task<Unit> AddItemAsync(Unit item)
        {
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public bool AddItemsAsync(IEnumerable<Unit> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unit> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Unit GetItemById<IDType>(IDType Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unit> GetItems(Expression<Func<Unit, bool>> condition)
        {
            return _context.Units.Where(condition);
        }
    }
}
