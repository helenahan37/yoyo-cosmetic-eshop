
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace Infrastructure.Data
{
  public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
  {
    private readonly StoreContext _context;

    public GenericRepository(StoreContext context)
    {
      this._context = context;
    }


    public async Task<T> GetByIdAsync(int id)
    {
      return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
      return await _context.Set<T>().ToListAsync();
    }
  }


}
