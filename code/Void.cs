namespace FunctionalProgramming;
using Unit = System.ValueTuple;

public class Void
{
    public static async Task Store(Employee employee)
    {
        if (employee.Id > 10)
            await SaveToDatabase(employee);
        else
            await SaveToMemory(employee);
    }
    
    public static async Task<Unit> Store_2(Employee employee) =>
        employee.Id > 10
            ? await SaveToDatabase(employee)
            : await SaveToMemory(employee);

    public static async Task<Unit> SaveToDatabase(Employee employee)
    {
        // Do something
        return new Unit();
    }

    public static async Task<Unit> SaveToMemory(Employee employee)
    {
        // Do something
        return new Unit();
    }

    public record Employee(int Id);
}