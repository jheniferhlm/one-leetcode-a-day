public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> letters = new HashSet<char>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (letters.Contains(s[right]))
            {
                letters.Remove(s[left]);
                left++;
            }

            letters.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}