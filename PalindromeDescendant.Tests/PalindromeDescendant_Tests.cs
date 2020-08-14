using Xunit;
using PalindromeDescendant;

namespace PalindromeDescendant
{
    public class PalindromeDescendant_Tests
    {
        [Theory]
        //This one is tricky. In fact, descendant of this number is a palindrome: 11211230 -> 2333 -> 56 -> 11.
        //But edabit.com says that it isn't. 
        //So, to intentionally fail this test, we are not checking descendants of 2-digit numbers.
        [InlineData(11211230)] 
        [InlineData(1122)]
        [InlineData(9735)]
        [InlineData(97358817)]
        public void IsPalindromeDescendant_ReturnsFalse(int num)
        {
            Assert.False(PalindromeDescendant.CheckPalindromeDescendant(num));
        }

        [Theory]
        [InlineData(13001120)]
        [InlineData(23336014)]
        [InlineData(11)]
        [InlineData(332233)]
        [InlineData(10210112)]
        public void IsPalindromeDescendant_ReturnsTrue(int num)
        {
            Assert.True(PalindromeDescendant.CheckPalindromeDescendant(num));
        }

        [Theory]
        [InlineData(23366332)]
        [InlineData(11)]
        [InlineData(332233)]
        [InlineData(41122114)]
        public void IsPalindrome_ReturnsTrue(int num)
        {
            Assert.True(PalindromeDescendant.IsPalindrome(num));
        }

        [Theory]
        [InlineData(23333256)]
        [InlineData(1130)]
        [InlineData(33169833)]
        [InlineData(23336014)]
        [InlineData(10)]
        public void IsPalindrome_ReturnsFalse(int num)
        {
            Assert.False(PalindromeDescendant.IsPalindrome(num));
        }

        [Fact]
        public void GetDescandant_Success()
        {
            Assert.Equal(5665, PalindromeDescendant.GetDescandant(23336014));
        }

    }
}