using Calculator;
using WritingToFile;

namespace Week11Test
{
    [TestClass]
    public class WritingToFileTest
    {
        /// <summary>
        /// This unit test Writting to file
        /// </summary>
        [TestMethod]
        public void StandardWriteNumberTest()
        {
            // Arrange
            StandardWrite standardWrite = new StandardWrite();
            standardWrite.WriteNumbersToFile(10);

            // Act


            // Assert


        }
    }
}
