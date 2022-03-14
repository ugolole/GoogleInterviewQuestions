using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InterviewQuestions.TopInterviewQuestions;

/// <summary>
/// A set of solutions based on the following questions found on the link
/// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/
/// </summary>
public class TopInterviewQuestions
{
    public void Initialize()
    {
        // Rotate a given array k number of steps
        // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
        var rotateArray = new RotateArrayQuestion();
        var array = new int[] {1, 2, 4, 5, 6, 7};
        var numberOfStesp = 4;
        rotateArray.Rotate(array, numberOfStesp);
        foreach (var items in array)
        {
            Console.Write(items + ",");
        }
        Console.WriteLine();
    }
}