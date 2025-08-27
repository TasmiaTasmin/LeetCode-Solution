//Brute force solution to find two indices in an array that sum to a target value.

//int[] Array = new int[] { 2, 6, 5, 8, 11 };
//int target = 14;

////int[] result = TwoSum(Array, target);
//for (int i = 0; i < Array.Length; i++)
//{
//    for (int j = 0; j < Array.Length; j++)
//    {
//        if (i == j) 
//        {
//            continue;
//        }
//        if (Array[i] + Array[j] == target)
//        {
//            Console.WriteLine($"Indices: {i}, {j} - Values: {Array[i]}, {Array[j]}");
//            Console.WriteLine("Yes. Sum is there.");
//        }
//    }
//}

//Optimul Brute force solution to find two indices in an array that sum to a target value.

//int[] Array = new int[] { 2, 6, 5, 8, 11 };
//int target = 14;

//for (int i = 0; i < Array.Length; i++)
//{
//    for (int j = i+1; j < Array.Length; j++)
//    {
//        if (i == j)
//        {
//            continue;
//        }
//        if (Array[i] + Array[j] == target)
//        {
//            Console.WriteLine($"Indices: {i}, {j} - Values: {Array[i]}, {Array[j]}");
//            Console.WriteLine("Yes. Sum is there.");
//        }
//    }
//}

//Better solution using Dictionary to find two indices in an array that sum to a target value.

//Vector<int> Array = new Vector<int>(new int[] { 2, 6, 5, 8, 11 });

using System.Data;
using System.Numerics;

Vector<int> SumArray = new Vector<int>();
public class Solution
{    
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        int length = nums.Length;
        for (int i=0; i<length; i++)
        {
            int n = nums[i];
            int differ = target - n;
            if (keyValuePairs.Keys.Contains(differ))
            {
                return new int[] {2, 3 };
            }
            keyValuePairs.Add(differ, n);

        }
        return null;
    }
}

//AI Suggested Solution 

//public abstract class TwoSum
//{
//    public static void Main(string[] args)
//    {
//        int[] Array = new int[] { 2, 6, 5, 8, 11 };
//        int target = 14;
//        int[] result = FindTwoSum(Array, target);
//        if (result != null)
//        {
//            Console.WriteLine($"Indices: {result[0]}, {result[1]} - Values: {Array[result[0]]}, {Array[result[1]]}");
//            Console.WriteLine("Yes. Sum is there.");
//        }
//        else
//        {
//            Console.WriteLine("No two indices found that sum to the target.");
//        }
//    }
//    public static int[] FindTwoSum(int[] nums, int target)
//    {
//        var numDict = new Dictionary<int, int>();

//        for (int i = 0; i < nums.Length; i++)
//        {
//            int complement = target - nums[i];
//            if (numDict.ContainsKey(complement))
//            {
//                return new int[] { numDict[complement], i };
//            }
//            numDict[nums[i]] = i;
//        }

//        return null;
//    }
//}

