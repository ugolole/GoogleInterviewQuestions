// See https://aka.ms/new-console-template for more information

using System.Text;
using InterviewQuestions;

var count = new CountOddNumbers();
const int low = 3;
const int high = 7;
var total = count.CountOdds(low, high);

Console.WriteLine($"the number of odd between {total}", total);

var averageSalaries = new AverageSalaryExcluding();
var av = averageSalaries.Average(new []{ 6000,5000,4000,3000,2000,1000});

Console.WriteLine(av);


Console.WriteLine("Determine the largest perimeter of a triangle.");
var largestPerimeter = new LargestPerimeterTriangle();
Console.WriteLine($"The result of the largest triangle" +
                  $" {LargestPerimeterTriangle.LargestPerimeter(new[] {1, 3, 5, 6})}" );

Console.WriteLine("");
Console.WriteLine("Rotate a given array n number of items");
var numbers = new[] {1, 2, 3, 4, 5};
var rotateArrayQuestion = new RotateArrayQuestion();
rotateArrayQuestion.Rotate(numbers, 3);
var result = new StringBuilder();
foreach (var number in numbers)
{
    result.Append(number);
}
Console.WriteLine($" result of rotating array {result.ToString()}");




