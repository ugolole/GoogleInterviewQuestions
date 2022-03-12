namespace InterviewQuestions.ProgrammingSkills;

public class LargestPerimeterTriangle
{
    // The perimeter can be obtained by adding the lengths
    // a + b + c = perimeter.
    // Some values don't make a triangle.
    // we to find the values that don't make a triangle.
    public static int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);

        for (int i = nums.Length - 3; i >=0; i--)
        {
            if (nums[i] + nums[i+1] > nums[2])
            {
                return nums[i] + nums[i + 1] + nums[2];
            }
        }
        
        return default;
    }
}