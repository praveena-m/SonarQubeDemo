using Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelper
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Helper.Program myProgram = new Program();
            var result = myProgram.Add(1, 3);

            Assert.AreEqual(4, result);
        }
    }
}
