namespace TDD_workshop.Tests
{
    [TestClass]
    public class DummyClassTest
    {
        [TestMethod]
        public void Add_Valid_Scenario1()
        {
            var testee = new DummyClass();
            var result = testee.Add(2, 3);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_Valid_Scenario2()
        {
            var testee = new DummyClass();
            var result = testee.Add(2, -3);

            Assert.AreEqual(-1, result);
        }
    }
}