public class Solution {
    public string LongestPalindrome(string s) {
        string palindrome = "";

        for (int i = 0; i < s.Length; i++) {
            for (int j = s.Length - 1; j >= i; j--) {
                if ((j - i + 1) <= palindrome.Length) break;
                int left = i;
                int right = j;
                bool isPalindrome = true;

                while (left < right) {
                    if (s[left] != s[right]) {
                        isPalindrome = false;
                        break;
                    }
                    left++;
                    right--;
                }

                if (isPalindrome) {
                    string current = s.Substring(i, j - i + 1);
                    if (current.Length > palindrome.Length) {
                        palindrome = current;
                    }
                }
            }
        }

        return palindrome;
    }
}
