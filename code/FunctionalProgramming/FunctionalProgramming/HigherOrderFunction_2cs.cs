namespace FunctionalProgramming;

public class HigherOrderFunction_2
{
    public static void Main()
    {
        var employees = new List<Employee>();

        var toms = employees.Where(NameContains("tom"));
        var romans = employees.Where(NameContains("roman"));
    }

    private static Func<Employee, bool> NameContains(string keyword)
        => employee => employee.Name.Contains(keyword);

    public class Employee
    {
        public required string Name { get; init; }
    }
}