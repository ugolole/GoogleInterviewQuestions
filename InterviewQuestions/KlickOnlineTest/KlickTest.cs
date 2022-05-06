namespace InterviewQuestions.KlickOnlineTest;

public class KlickTest
{
    private int fix = 0;
    
    public int solution(string S) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int initial = S.Length;

        Segementation(initial,initial,initial, S);

        return fix;
    }
    
    public int Segementation(int first, int last, int length, string S){
        first = length - 3;

        last = length - 1;

        length = first + 1;

        if(SubString(first, last, S).Contains("X")){
            fix = fix + 1;
        }

        if(first == 0)
            return fix;

        return Segementation(first, last, length, S);
    }
    
    public int SegementationEven(int first, int last, int length, string S){
        first = length - 3;

        last = length - 1;

        length = first + 1;

        if(SubString(first, last, S).Contains("X")){
            fix = fix + 1;
        }

        if(first == 0)
            return fix;

        return Segementation(first, last, length, S);
    }

    public string SubString(int first, int last, string S)
    {
        var substring = S.Substring(first, (last - first)+ 1);
        return substring;
    }
    
    // Is the length of the string S divisible by 3
    public bool IsDivisibleByThree(string S){
        if(S.Length % 3 == 0){
            return true;
        }
        return false;
    }
}