using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LightWAP.Services.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task InsertAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task DeleteAsync(TEntity existing);
        Task<IList<TEntity>> GetAllAsync();
        Task SaveAsync();
    }
}
