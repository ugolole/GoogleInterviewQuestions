// See https://aka.ms/new-console-template for more information

using GoogleInterviewQuestions;

Console.WriteLine("Hello, World!");

CountOddNumbers result = new CountOddNumbers();

const int low = 3;
const int high = 7;

var total = result.CountOdds(low, high);

Console.WriteLine(total);