//using System.Collections.Generic;

//public class Solution
//{
//    public IList<IList<int>> Generate(int numRows)
//    {
//        IList<IList<int>> triangle = new List<IList<int>>();

//        if (numRows == 0)
//        {
//            return triangle;
//        }

//        // Add the first row
//        triangle.Add(new List<int> { 1 });

//        for (int i = 1; i < numRows; i++)
//        {
//            List<int> currentRow = new List<int>();
//            IList<int> prevRow = triangle[i - 1];

//            currentRow.Add(1); // First element is always 1

//            for (int j = 1; j < prevRow.Count; j++)
//            {
//                currentRow.Add(prevRow[j - 1] + prevRow[j]);
//            }

//            currentRow.Add(1); // Last element is always 1
//            triangle.Add(currentRow);
//        }

//        return triangle;
//    }
//}
