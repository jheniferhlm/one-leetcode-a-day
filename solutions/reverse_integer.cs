public class Solution {
    public int Reverse(int x) {
        int reverse = 0;

        while (x != 0)
        {
            int digit = x % 10;

            x = x / 10;

            if (reverse > int.MaxValue / 10 || reverse < int.MinValue / 10)
                return 0;

            if ((reverse == int.MaxValue / 10 && digit > 7) || (reverse == int.MinValue / 10 && digit < -8))
                return 0;

            reverse = reverse * 10 + digit;
        }

        return reverse;
    }
}