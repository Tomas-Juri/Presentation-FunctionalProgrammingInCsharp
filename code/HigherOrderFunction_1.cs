using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace FunctionalProgramming;

public class HigherOrderFunction_1
{
    public static int? CalculateSalary()
    {
        var employee = GetEmployee();
        if (employee == null)
            return null;

        return employee.Name == "Tom" 
            ? 0 
            : int.MaxValue;
    }

    public static int? CalculateSalary_2() =>
        GetEmployee()
            .Map(employee => employee.Name == "Tom"
                ? 0
                : int.MaxValue);
    
    public static int? CalculateSalary_3() =>
        GetEmployee().Map(ToSalary);

    private static int ToSalary(Employee employee)
        => employee.Name == "Tom" ? 0 : int.MaxValue;
    
    private static Employee? GetEmployee() => new("");
    
    private record Employee(string Name);
}

file static class F
{
    public static TOut? Map<TIn, TOut>(this TIn? input, Func<TIn, TOut> map) where TOut : struct
        => input == null ? null : map(input);
    
    public static T? Filter<T>(this T? input, Func<T, bool> predicate) where T : struct
        => input == null ? null : predicate(input.Value) ? input : null;
}