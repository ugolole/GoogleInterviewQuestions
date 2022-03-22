namespace InterviewQuestions.GeotabQuestions;

public static class GeotabQuestions
{
    public static void Initialize()
    {
        Console.WriteLine();
        Console.WriteLine("####### Determine if there is a difference between throw and throw ex.");
        // Determine if there is a difference between throw and throw ex.
        try
        {
            ThrowVsThrowEx.Method2();
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace.ToString());
            Console.ReadLine();
        }
    }
}