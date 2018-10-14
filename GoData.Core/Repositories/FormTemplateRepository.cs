using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GoData.Entities.Entities;

namespace GoData.Core.Repositories
{
    public class FormTemplateRepository : IRepository<FormTemplate>
    {
        public Task<FormTemplate> AddItemAsync(FormTemplate item)
        {
            throw new NotImplementedException();
        }

        public bool AddItemsAsync(IEnumerable<FormTemplate> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FormTemplate> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public FormTemplate GetItemById<IDType>(IDType Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FormTemplate> GetItems(Expression<Func<FormTemplate, bool>> condition)
        {
            throw new NotImplementedException();
        }
    }
}
