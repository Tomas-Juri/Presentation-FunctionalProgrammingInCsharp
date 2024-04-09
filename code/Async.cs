namespace FunctionalProgramming;

public class Async
{
    public static async Task<int?> CalculateSalary()
    {
        var employee = await GetEmployee();
        if (employee == null)
            return null;

        return employee.Name == "Tom"
            ? 0
            : int.MaxValue;
    }

    public static async Task<int?> CalculateSalary_2()
    {
        var employee = await GetEmployee();
        return employee.Map(employee => employee.Name == "Tom" ? 0 : int.MaxValue);
    }

    public static async Task<int?> CalculateSalary_3() =>
        await GetEmployee().Map(ToSalary);

    public static async Task<(int, string)?> CalculateSalary_4()
    {
        var employee = await GetEmployee();
        return employee == null 
            ? null 
            : (ToSalary(employee), ToSomethingElse(employee));
    }

    public static async Task<(int, string)?> CalculateSalary_5() =>
        await
            from employee in GetEmployee()
            from salary in ToSalary(employee)
            from somethingElse in ToSomethingElse(employee)
            select (salary, somethingElse);

    private static int ToSalary(Employee employee)
        => employee.Name == "Tom" ? 0 : int.MaxValue;
    
    private static string ToSomethingElse(Employee employee)
        => "";

    private static async Task<Employee?> GetEmployee() => new("");

    private record Employee(string Name);
}

file static class F
{
    public static TOut? Map<TIn, TOut>(this TIn? input, Func<TIn, TOut> map) where TOut : struct
        => input == null ? null : map(input);

    public static async Task<TOut?> Map<TIn, TOut>(this Task<TIn?> input, Func<TIn, TOut> map) where TOut : struct =>
        await input switch
        {
            null => null,
            var value => map(value)
        };

    public static async Task<T3> SelectMany<T1, T2, T3>(this Task<T1> source, Func<T1, T2> bind, Func<T1, T2, T3> project) =>
        await source switch
        {
            var t1 => project(t1, bind(t1))
        };
}