using Microsoft.VisualStudio.TestTools.UnitTesting;
using Making_Anagrams;

namespace Anagram_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "abcl";

            string b = "bcah";

            int result = Make_Anagram.makeanagram(a, b);

            int expected = 2;

            Assert.AreEqual(result, expected);
        }
    }
}
