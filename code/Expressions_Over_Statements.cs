namespace FunctionalProgramming;

public class Expressions_Over_Statements_Imperative
{
    public static Risk CalculateRisk(int age, Gender gender)
    {
        var treshold = 0;
        if (gender == Gender.Female)
            treshold = 62;
        else
            treshold = 60;

        if (treshold > age)
            return Risk.Low;
        
        return Risk.Medium;
    }

    public enum Gender { Male, Female }
    
    public enum Risk { Low, Medium }
}

public class Expressions_Over_Statements_Functional
{
    public static Risk CalculateRisk(int age, Gender gender) => 
        Treshold(age, gender) > age ? Risk.Low : Risk.Medium;

    private static int Treshold(int age, Gender gender) =>
        gender == Gender.Female ? 62 : 60;

    public enum Gender { Male, Female }
    
    public enum Risk { Low, Medium }
}