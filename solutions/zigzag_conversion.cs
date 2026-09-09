public class Solution {
    public string Convert(string s, int numRows) {
        int currentRow = 0;
        bool goingDown = true;
        List<string> rows = new List<string>();

        if (numRows == 1) return s;

        for (int i = 0; i < numRows; i++)
            rows.Add("");

        for (int j = 0; j < s.Length; j++)
        {
            rows[currentRow] += s[j];

            if (goingDown)
            {
                if (currentRow != numRows - 1)
                    currentRow++;
                else
                {
                    goingDown = false;
                    currentRow--;
                }
            }
            else
            {
                if (currentRow != 0)
                    currentRow--;
                else
                {
                    goingDown = true;
                    currentRow++;
                }
            }
        }

        return string.Join("", rows);
    }
}