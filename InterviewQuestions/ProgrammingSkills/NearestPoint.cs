namespace InterviewQuestions.ProgrammingSkills;

/// <summary>
/// Find the nearest point that has the same x and y coordinate. The link to the complete question can be found here
/// https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/
/// </summary>
public class NearestPoint
{
    public int NearestValidPoint(int x, int y, int[][] points) {   
        
        // return all the index location of valid points.
        var validIndexes = ValidIndexes(x, y, points);
        
        // if no valid points exist.
        if(validIndexes.Length == 0){
             return -1;
        }
        
        Dictionary<int, int> manhattanDistances = new  Dictionary<int, int>();

        
        // calculate the manhattan distance.
        // for each of the points and add them to a list
        
        for(int i = 0; i< validIndexes.Length; i++){
            manhattanDistances.Add(validIndexes[i], ManhattanD(validIndexes[i], x, y, points));
        }
        
        var result = manhattanDistances.OrderBy(md => md.Value).First();
        
       
        return result.Key;
    }
    
    // Take the index location of a valid point and then calculate the manhanttan distance
    // return manhattanD as integer.
    private int ManhattanD(int validPointIndex, int x, int y, int[][] points ){
        
       return Math.Abs(points[validPointIndex][0] - x) + Math.Abs(points[validPointIndex][1] - y);
    }
    
    // Find valid points.
    // Iterate throughout the entire array.
    // Determine which points are valid
    // Get the index location of the valid points
    // Store the index location into a string
    // returns the string containing all the index locations of the valid points
    // Time and space complexity analysis O(N) + O(points.Length)
    private int[] ValidIndexes(int x, int y, int[][] points){
        
        // create a list to contain all valid indexes
        // the reason for stringBuilder is I don't know before looping throughout the entire
        // array how many valid points exit.
        List<int> validIndexes = new List<int>();
        
        // iterate through the first dimension of the array to give me 
        // access to the index location of the points
        for(int i =0; i<points.Length; i++){
            
            // If it meets a condition determined later on 
            if(points[i][0].Equals(x) || points[i][1].Equals(y)){
                validIndexes.Add(i);
            }
           
        }
        
        return validIndexes.ToArray();
    }
}