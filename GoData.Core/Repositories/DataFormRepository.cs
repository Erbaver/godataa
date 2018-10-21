using GoData.Data.Contexts;
using GoData.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoData.Core.Repositories
{
    public class DataFormRepository : IRepository<DataForm>
    {
        private DefaultContext _context;

        public DataFormRepository(DefaultContext context)
        {
            _context = context;
        }
        public async Task<DataForm> AddItemAsync(DataForm item)
        {
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
            return GetItemById<int>(item.Id);
        }

        public bool AddItemsAsync(IEnumerable<DataForm> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DataForm> GetAllItems()
        {
            return _context.DataForms;
        }

        public DataForm GetItemById<IDType>(IDType Id)
        {
            var id = Int32.Parse(Id.ToString());
            return _context.DataForms.Single(d => d.Id == id);
        }

     
        public IEnumerable<DataForm> GetItems(Expression<Func<DataForm, bool>> condition)
        {
            return _context.DataForms.Where(condition);
        }

        public DataForm UpdateItemAsync(DataForm item)
        {
            throw new NotImplementedException();
        }
    }
}
