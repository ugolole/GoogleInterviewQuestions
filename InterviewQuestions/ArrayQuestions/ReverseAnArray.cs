namespace InterviewQuestions.ArrayQuestions;

/// <summary>
/// The following solution will show how one can reverse an array. The question to this solution can be
/// found in the following link : https://www.hackerrank.com/challenges/arrays-ds/problem
/// </summary>
public class ReverseAnArray
{
    private List<int> _a;

    public ReverseAnArray(List<int> a)
    {
        _a = a;
    }
    
    public List<int> ReverseArray(List<int> a)
    {
        for (var i =0; i< a.Count; i++)
        {
            var temp = a[i];
            a[i] = a[a.Count - i - 1];
            a[a.Count - i - 1] = temp;
        }

        return a;
    }

    public void PrintResult()
    {
        if(_a.Count == 0)
        {
            Console.WriteLine("Array is empty.");
        }

        foreach (var result in ReverseArray(_a))
        {
            Console.Write(result);
        }
    }
}