using System.Net.Sockets;
using static System.Console;

namespace InterviewQuestions.ProgrammingSkills;

/// <summary>
/// A set of solutions based on https://leetcode.com/study-plan/programming-skills/?progress=dnn4p23 assessment
/// found in www.leetcode.com
/// </summary>
public class ProgrammingSkills
{
    public static void Initialize()
    {
        // Count Odd numbers in an interval range
        // https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
        var countOddNumber = new CountOddNumbers();
        const int low = 0;
        const int high = 10;
        WriteLine($"###### Count odd number in an interval range from {low} to {high}");
        WriteLine("Result of counting odd numbers: " + countOddNumber.CountOdds(0,10));
        WriteLine();
        
        // Average salaries excluding the minimum and maximum salaries 
        // https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
        var averageSalaries = new AverageSalaryExcluding();
        var salaries = new int[] {100, 535, 151, 51515, 3};
        WriteLine("####### Determine the average salaries of the given array {100, 535, 151, 51515, 3} ");
        WriteLine("The average is : " + averageSalaries.Average(salaries));
        WriteLine();

        // Return the largest perimeter of a triangle with a non zero area formed from 3 lengths.
        var numbers = new[] {2, 1, 2};
        var largestPerimeter = new LargestPerimeterTriangle();
        WriteLine("####### Return the largest perimeter of a triangle with a non zero area formed from 3 lengths.");
        WriteLine("The large area of the triangle  {2, 1, 2} is " + largestPerimeter.LargestPerimeter(numbers));
        WriteLine();
        
        // Find the nearest point that has the same x and y coordinate
        var nearestPoint = new NearestPoint();
        int x = 3;
        int y = 4;
        int[,] points = new int[,] { {1,2},{3,1},{2,4},{2,3},{4,4} } ;

        //var result = nearestPoint.NearestValidPoint(x, y, points);
        Stack<int> stack = new Stack<int>();

        int start = 0;
        int end = 10;

        int number = 2;

        while (start < end)
        {
            stack.Push(number);
            start++;
            number++;
        }

        stack.Pop();
        
        WriteLine("Result of using a stack "+number);
        WriteLine("The size of the stack " + stack.Count);
    }
}