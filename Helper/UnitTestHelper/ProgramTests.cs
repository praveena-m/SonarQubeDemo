using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helper.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetStatusTest()
        {
            Assert.IsNull(Program.GetStatus());
        }
    }
}