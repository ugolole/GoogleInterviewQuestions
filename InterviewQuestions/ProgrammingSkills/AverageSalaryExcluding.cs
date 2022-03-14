namespace InterviewQuestions.ProgrammingSkills;

/// <summary>
/// Determine the average salary excluding the minimum and maximum.
/// https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
/// </summary>
public class AverageSalaryExcluding
{

    public double Average(int[] salary)
    {
        double total = 0.0;
        int numberOfElement = 0;
        var sortedSalary = SortSalary(salary);

        for (int i = 1; i< sortedSalary.Length - 1; i++)
        {
            total = total + sortedSalary[i];
            numberOfElement = numberOfElement + 1;
        }

        return total / numberOfElement;
    }
    
    public int[] SortSalary(int[] salary)
    {

        for (int i = 0; i<salary.Length - 1; i++)
        {
            for(int indexPositionOfSalary = 0; indexPositionOfSalary<salary.Length -  i - 1; indexPositionOfSalary++){
                if(salary[indexPositionOfSalary] > salary[indexPositionOfSalary + 1]){
                    int temp = salary[indexPositionOfSalary];
                    salary[indexPositionOfSalary] = salary[indexPositionOfSalary + 1];
                    salary[indexPositionOfSalary + 1] = temp;
                }
            }
        }
        
        return salary;
    }
}