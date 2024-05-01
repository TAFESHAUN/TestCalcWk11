using Calculator;

namespace wk11calctest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            SalaryCalculator sc = new SalaryCalculator();
        }

        /// <summary>
        /// XML COMMENTS ON THEM LIKE A NORMAL METHOD
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}