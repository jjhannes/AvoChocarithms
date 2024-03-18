
namespace AvoChocarithms.SectionA.DataStructures1.Tests
{
    [TestClass]
    public class TestPalindromes
    {
        [TestMethod]
        [DataRow("omo")]
        [DataRow("aba")]
        [DataRow("aa")]
        [DataRow("abcba")]
        [DataRow("abccba")]
        [DataRow("abba")]
        [DataRow("dcbabcd")]
        [DataRow("dcbaabcd")]
        public void ValidPalindromes_ShouldReturnTrue(string Input)
        {
            Assert.IsTrue(Palindrome.IsPalindrome(Input));
        }

        [TestMethod]
        [DataRow("abcd")]
        [DataRow("ab")]
        [DataRow("abcdef")]
        [DataRow("abcdcb")]
        [DataRow("abcdba")]
        public void InvalidPalindromes_ShouldReturnFalse(string Input)
        {
            Assert.IsFalse(Palindrome.IsPalindrome(Input));
        }
    }
}