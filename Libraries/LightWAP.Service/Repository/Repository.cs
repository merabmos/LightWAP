using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using LightWAP.Data;

namespace WebStore.Services.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        private readonly LightWAPDBContext _context;
        private readonly DbSet<TEntity> _table;
        public Repository(LightWAPDBContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }
    
        public async Task InsertAsync(TEntity obj)
        {
            await _table.AddAsync(obj);
            await SaveAsync();
        }
        public async Task UpdateAsync(TEntity obj)
        {
            if (obj != null)
            {
                _table.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await SaveAsync();
            }
        }

        // Delete Record
        public async Task DeleteAsync(TEntity existing)
        {
            _table.Remove(existing);
            await SaveAsync();
        }
        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}