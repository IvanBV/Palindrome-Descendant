using System;
using System.Text;

namespace PalindromeDescendant
{
    public class PalindromeDescendant
    {
        public static bool CheckPalindromeDescendant(int num) 
        {
            var numberString = num.ToString();
            
            if (numberString.Length % 2 == 1)
                return false;

            if (IsPalindrome(num))
                return true;

            // Get descendant
            return CheckPalindromeDescendant(GetDescandant(num));
        }

        public static bool IsPalindrome(int num)
        {
            var numberString = num.ToString();

            for(int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - i - 1])
                    return false;
            }

            return true;
        }

        public static int GetDescandant(int num)
        {
            var numberString = num.ToString();

            // Force check to intentionally fail first test (described in PalindromeDescendant_Tests.cs)
            if (numberString.Length <= 2)
                return 0;

            var descendant = new StringBuilder();
            for(int i = 0; i < numberString.Length; i += 2)
            {
                descendant.Append(char.GetNumericValue(numberString[i]) + char.GetNumericValue(numberString[i + 1]));
            }
            return Convert.ToInt32(descendant.ToString());
        }

    }
}
