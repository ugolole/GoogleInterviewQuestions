
using static System.Console;
namespace InterviewQuestions.TopInterviewQuestions;

/// <summary>
/// A set of solutions based on the following questions found on the link
/// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/
/// </summary>
internal class TopInterviewQuestions
{
    public static void Initialize()
    {
        // Rotate a given array k number of steps
        // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
        var rotateArray = new RotateArrayQuestion();
        var array = new int[] {1, 2, 4, 5, 6, 7};
        const int numberOfSteps = 4;
        WriteLine("###### Rotate a give array {1, 2, 4, 5, 6, 7} with the following number of steps "  + $"{numberOfSteps}");
        rotateArray.Rotate(array, numberOfSteps);
        foreach (var items in array)
        {
            Write(items + ",");
        }
        WriteLine();
    }
}