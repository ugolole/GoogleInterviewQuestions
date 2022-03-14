namespace InterviewQuestions.ProgrammingSkills;

/// <summary>
/// Return the largest perimeter of a triangle with a non-zero area. The complete questions can be found in the link
/// show here: https://leetcode.com/problems/largest-perimeter-triangle/
/// </summary>
internal  class LargestPerimeterTriangle
{
    // The perimeter can be obtained by adding the lengths
    // a + b + c = perimeter.
    // Some values don't make a triangle.
    // we to find the values that don't make a triangle.
    public int LargestPerimeter(int[] nums)
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