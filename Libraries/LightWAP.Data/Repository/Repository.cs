using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using LightWAP.Data;
using LightWAP.Data.Repository.Interfaces;
using System.Linq;
using LightWAP.Core.Domain;

namespace LightWAP.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Properties

        private readonly LightWAPDBContext _context;
        private readonly DbSet<TEntity> _table;

        #endregion

        #region Constructor
        public Repository(LightWAPDBContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }
        #endregion

        #region Methods
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
        public async Task DeleteAsync(TEntity existing)
        {
            _table.Remove(existing);
            await SaveAsync();
        }
        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(object id)
        { 
            return await _table.FirstOrDefaultAsync(o =>  o.Id == Convert.ToInt32(id));
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        #endregion

    }
}