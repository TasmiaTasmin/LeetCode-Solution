using System.Collections.Generic;

public class PascalsTriangle
{
    public IList<IList<int>> GenerateTriangle(int rowNumber)
    {
        IList<IList<int>> triangle = new List<IList<int>>();
        if (rowNumber <= 0)
        {
            return triangle;
        }

        triangle.Add(new List<int> { 1 });
        for (int i = 1; i < rowNumber; i++)
        {
            List<int> CurrentRow = new List<int>();
            IList<int> PreviousRow = triangle[i - 1];

            CurrentRow.Add(1);

            for (int j = 1; j < PreviousRow.Count; j++)
            {
                CurrentRow.Add(PreviousRow[j - 1] + PreviousRow[j]);
            }

            CurrentRow.Add(1); //Last Element is always 1
            triangle.Add(CurrentRow);
        }
        return triangle;
    }
}
