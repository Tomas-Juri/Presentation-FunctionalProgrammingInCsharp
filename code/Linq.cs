namespace FunctionalProgramming;

public class Linq
{   
    public static void Run()
    {
        var list = new List<int> { 1, 2, 3 };
        var next = list
            .Where(IsValid)
            .ToList();

        var response = new Response
        {
            From = default,
            To = default,
            Duration = 0
        };


        var a = response with
        {
            Duration = 20
        };

        var isValid = Validate(value, IsNotEmpty, IsAllUppercase);
    }

    private static bool IsNotEmpty(string value)
        => false;

    private static bool IsAllUppercase(string value)
        => false;

    private class Model
    {
        public static Model Empty => new();
    }
    
    public record Response
    {
        public required DateOnly From { get; init; }
			
        public required DateOnly To { get; init; }
			
        public required int Duration { get; init; }
    }
    
    private static bool IsValid(int input) 
        => true;

    private static bool Validate(string input, params Func<string, bool>[] validations)
        => validations.All(x => x(input));
}