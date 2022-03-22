namespace InterviewQuestions.GeotabQuestions;

public class ThrowVsThrowEx
{
    public static void Method2()
    {
        try
        {
            Method1();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Method1()
    {
        try
        {
            throw new Exception("Exception thrown inside method 1");
        }
        catch (Exception)
        {
            throw;
        }
    }
}