using Calculator;
using WritingToFile;

namespace Week11Test
{
    [TestClass]
    public class WritingToFileTest
    {
        /// <summary>
        /// This unit test checks the annual salary calculations of the salary calculator 
        /// </summary>
        [TestMethod]
        public void StandardWriteTest()
        {
            // Arrange
            StandardWrite standardWrite = new StandardWrite();
            standardWrite.WriteNumbersToFile(10);

            // Act


            // Assert


        }
    }
}
