using DptSalCalc;

namespace DptCalculatorTest
{
    [TestClass]
    public class BaseSalCalcTest
    {
        [TestMethod]
        public void ManagerBaseCalcTest()
        {
            //Arrange
            CalculateBaseSalary calculator = new CalculateBaseSalary();

            //Act
            decimal testWage = 55.78m;
            string testType = "manager";
            decimal actualSalary = calculator.CalcBaseSalary(testWage, testType);
            decimal expectedSalary = 66.936m;

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);

        }

        [TestMethod]
        public void DeveloperBaseCalcTest()
        {
            //Arrange
            CalculateBaseSalary calculator = new CalculateBaseSalary();

            //Act
            decimal testWage = 100m;
            string testType = "developer";
            decimal actualSalary = calculator.CalcBaseSalary2(testWage, testType);
            decimal expectedSalary = 110m;

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void SalesPersonBaseCalcTest()
        {

        }
    }
}