namespace LeetCode
{
    public class _009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {

            if (x < 0)
            {
                return false;
            }
            if (x < 10)
            {
                return true;
            }

            var temp = x;
            var output = 0;
            var digit = 0;
            while (temp != 0)
            {
                digit = temp % 10;
                output = output * 10 + digit;
                temp = temp / 10;
            }
            return output == x;

        }
    }
}
