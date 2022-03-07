namespace GoogleInterviewQuestions;

/// <summary>
/// A class that contains a method used to rotate an array.
/// </summary>
public class RotateArrayQuestion
{
    /// <summary>
    /// Rotates a given array.
    /// </summary>
    /// <param name="nums">The array for which the rotational operation will be performed.</param>
    /// <param name="k">The number of rotations to be performed.</param>
    /// <returns>A rotated array of numbers.</returns>

    // They are 3 positions that will will have to manipulate.
    // Position initial :- 0
    // Position secondary :- 1
    // Position final :- n - 1
    // Where n is the length of the array.
    
    
    
    // Exmaple        i s         f
    // Input: nums = [1,2,3,4,5,6,7], k = 3
    // Output: [5,6,7,1,2,3,4]
    // Explanation:
    // rotate 1 steps to the right: [7,1,2,3,4,5,6]
    // rotate 2 steps to the right: [6,7,1,2,3,4,5]
    // rotate 3 steps to the right: [5,6,7,1,2,3,4]
    
    // Store f in temp location
    // Replace entities in location [ f-- ]for the index > 0 
    // Replace index = 0 with temp.
    // f = 7 i == length - 1
    // replace(i, i - 1)
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        
        for(int i = 0; i<k; i++){
            Rotate(k, nums);
        }
        
    }
    
    // Swaps the current value with the next value only once.
    private void Swap(int[] nums, int current, int next ){
        int temp = 0;
        temp = nums[current];
        nums[current] = nums[next];
        nums[next] = temp;
    }
    
    private void Rotate(int numberOfRotations, int[] nums){
        for(int i = nums.Length - 1; i > 0; i--){
             
            Swap(nums, i, i-1);
        }
    }
}