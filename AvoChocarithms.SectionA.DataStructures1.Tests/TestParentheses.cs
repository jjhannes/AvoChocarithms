
namespace AvoChocarithms.SectionA.DataStructures1.Tests
{
    [TestClass]
    public class TestParentheses
    {
        [TestMethod]
        [DataRow("(())")]
        [DataRow("(()()())")]
        [DataRow("(a+b)-(c-d)*(e/f)")]
        [DataRow("((a*a)+2b-c)/(r*r)")]
        [DataRow("Blah blah blah (ex why zed) blah blah blah. There.")]
        public void BalancedParentheses_ShouldReturnTrue(string Input)
        {
            Assert.IsTrue(Parentheses.IsBalanced(Input));
        }

        [TestMethod]
        [DataRow("(()")]
        [DataRow("())")]
        [DataRow(")")]
        [DataRow("(")]
        [DataRow("))((")]
        [DataRow(")()(")]
        [DataRow("(()(())")]
        [DataRow("()(())))")]
        [DataRow("))())(()")]
        [DataRow("))())(()((")]
        [DataRow("a(b+c)/(d*e")]
        [DataRow("(x*x)+(y*y)-(r*r")]
        [DataRow("(x*x)+(y*y)-r*r)")]
        [DataRow("Blah blah blah (ex why zed blah blah blah. Whoops.")]
        public void ImbalancedParentheses_ShouldReturnFalse(string Input)
        {
            Assert.IsFalse(Parentheses.IsBalanced(Input));
        }
    }
}