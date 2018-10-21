using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoData.Core.Repositories
{
    public interface IRepository<T>
    {
        Task<T> AddItemAsync(T item);

        IEnumerable<T> GetAllItems();

        T GetItemById<IDType>(IDType Id);

        bool AddItemsAsync(IEnumerable<T> items);

        IEnumerable<T> GetItems(Expression<Func<T, bool>> condition);

        T UpdateItemAsync(T item);
    }
}
