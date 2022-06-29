using Domain;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    private static IDbContextProgram<Model> _dbContextProgram;
    public static void Main()
    {
        var services = new ServiceCollection();
        services.AddDbContext<EfCore>();
        services.AddScoped(typeof(IDbContextProgram<>), typeof(DbContextProgram<>));
        
        var serviceProvider = services.BuildServiceProvider();
        _dbContextProgram = serviceProvider.GetService<IDbContextProgram<Model>>();
        _dbContextProgram.Add(new Model()
        {
            Name = "arek",
            Id = 1
        });

        var result = _dbContextProgram.GetModelById(1);
        Console.WriteLine(result.Name);
    }
}