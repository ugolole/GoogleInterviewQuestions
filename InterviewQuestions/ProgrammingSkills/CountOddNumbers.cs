namespace InterviewQuestions.ProgrammingSkills;

/// <summary>
/// https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
/// A class that contains a method used to count odd number between a given range.
/// </summary>
internal class CountOddNumbers
{
    /// <summary>
    /// Count the number of odd numbers in between a low and high number.
    /// </summary>
    /// <param name="low">A number where the counting starts.</param>
    /// <param name="high">A number where the counting ends.</param>
    /// <returns>The</returns>
    public int CountOdds(int low, int high)
    {
        return NumberOfOdds(low, high);
    }

    /// <summary>
    /// Creates an array of numbers that are odd.
    /// </summary>
    /// <returns>An array of number that are odd. </returns>
    private int NumberOfOdds(int low, int high)
    {
        int numberOfOdds = 0; // index to the oddNumber array.
        
        
        for (int start = low; start<=high; start++ )
        {
            if (IsOdd(start))
            {
                numberOfOdds = numberOfOdds + 1;
            }
        }

        return numberOfOdds;
    }
    
    // Determines if the number is odd
    private bool IsOdd(int number)
    {
        if (number % 2 != 0)
        {
            return true;
        }
        return false;
    }
}