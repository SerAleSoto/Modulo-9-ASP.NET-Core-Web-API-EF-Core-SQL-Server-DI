using CRUD_Modulo9.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Modulo9.Repositories;

public class GenericRepository<T>: IRepository<T> where T : class
{
    protected readonly AppDbContext _context;

    protected readonly DbSet<T> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

}
