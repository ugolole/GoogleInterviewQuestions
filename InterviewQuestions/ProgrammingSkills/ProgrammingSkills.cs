using static System.Console;

namespace InterviewQuestions.ProgrammingSkills;

/// <summary>
/// A set of solutions based on https://leetcode.com/study-plan/programming-skills/?progress=dnn4p23 assessment
/// found in www.leetcode.com
/// </summary>
public class ProgrammingSkills
{
    public void Initial()
    {
        // Count Odd numbers in an interval range
        // https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
        var countOddNumber = new CountOddNumbers();
        WriteLine("Result of counting odd numbers: " + countOddNumber.CountOdds(0,10));
    }
}