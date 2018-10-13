using System.Collections.Generic;

namespace GoData.Data.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        T AddItemAsync(T item);

        IEnumerable<T> GetAllItems();

        T GetItemById<IDType>(IDType Id);

        bool AddItemsAsync(IEnumerable<T> items);
    }
}
