using Domain;

namespace Infrastructure;

public class DbContextProgram<T>:IDbContextProgram<T>
    where T:class
{
    private readonly EfCore _dbContext;
    public DbContextProgram(EfCore dbContext)
    {
        _dbContext = dbContext;
    }
    public void Add(T model)
    {
        _dbContext.Set<T>().Add(model);
        _dbContext.SaveChanges();
    }

    public void Remove(T model)
    {
        _dbContext.Set<T>().Remove(model);
        _dbContext.SaveChanges();
    }

    public T GetModelById(int id)
    {
        return _dbContext.Set<T>().Find(id);
    }

    public IReadOnlyList<T> GetAllModels()
    {
        return _dbContext.Set<T>().ToList();
    }
}