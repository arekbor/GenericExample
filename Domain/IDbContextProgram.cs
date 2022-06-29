namespace Domain;

public interface IDbContextProgram<T>
    where T:class
{
    void Add(T model);
    void Remove(T model);
    T GetModelById(int id);
    IReadOnlyList<T> GetAllModels();
}