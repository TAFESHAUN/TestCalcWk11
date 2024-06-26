using Calculator;

namespace Week11Test
{
    /// <summary>
    /// 
    /// Salary calculator Library Test
    /// 
    /// Salary unit test:
    /// To get hourly, divide annual salary by 2080     
    /// $100,006.40 / 2080 = $48.08  hr
    /// To get annual, multiply hourly by 2080 
    /// $48.08 * 2080 = $100,006.40
    /// 
    /// </summary>
    
    [TestClass]
    public class SalaryCalculatorTest
    {
        /// <summary>
        /// Test to check if records import
        /// </summary>
        [TestMethod]
        public void CheckIfImportedWorked()
        {
            // Arrange
            // Arrange a calculator to be tested
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            //Check IF records that are imported from our Calculator are NOT NULL
            var records = sc.ImportWages();

            //decimal? x = null;

            //records.Add((decimal)x);


            // Assert 
            //This is not Null
            Assert.IsNotNull(records);//ALL OR individual records[1]
        }

        /// <summary>
        /// This unit test checks the annual salary calculations of the salary calculator 
        /// </summary>
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            // Arrange a calculator to be tested
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            // Act on the calculator so that we can get the ACTUAL salary
            //Control 1.1
            decimal annualSalary = sc.GetAnnualSalary(50);
            //Control 1.2
            decimal annualSalary2 = sc.GetAnnualSalary(0);
            //Control 1.3
            decimal annualSalary3 = sc.GetAnnualSalary(-100);

            // Assert
            // Assert that the Expected vs Actual AreEqual to each other
            //Test 1.1
            Assert.AreEqual(104000, annualSalary);
            //Test 1.2
            Assert.AreEqual(0, annualSalary2);
            //Test 1.3
            Assert.AreEqual(-208000, annualSalary3);

        }

        /// <summary>
        /// Test if the wage imports work
        /// </summary>
        [TestMethod]
        public void TestImportRecords()
        {
            //Arrange
            //Arrange Calculator and Imported records
            SalaryCalculator sc = new SalaryCalculator();
            var records = sc.ImportWages();

            //Act
            //We could test individual records here
            //decimal record1 = records[1];

            //Assert
            //Assert.AreEqual((decimal)25.754, record1);
            Assert.IsNotNull(records);
        }

        /// <summary>
        /// This unit test checks the hourly wage of my salary calcultor
        /// </summary>
        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            // Control values are $25 an hour -> 25.754
            SalaryCalculator sc = new SalaryCalculator();
            var records = sc.ImportWages();
            //Find records with match lastnames, with or without tax index only compare either

            decimal annualSalary = sc.GetAnnualSalary(records[1]);//25 an hour to meet other conditions ->25.754
            decimal annualSalary2 = sc.GetAnnualSalary(records[2]);//25.999 is the value we are passing

            // Act
            //decimal hourlyWage = sc.GetHourlyWage(52000);//$52000 per year
            decimal hourlyWage = sc.GetHourlyWage(annualSalary);//$52000 per year
            decimal hourlyWage2 = sc.GetHourlyWage(annualSalary2);

            // Assert   
            Assert.AreEqual((decimal)25.754, hourlyWage); //Expect $25.754 an hour record at [1]
            Assert.AreEqual((decimal)25.999, hourlyWage2);//Expect this to be $25.999 an hour record at [2]
        }

        /// <summary>
        /// This unit test will find the wage with tax index calculations 
        /// </summary>
        [TestMethod]
        public void WageWithTaxIndex()
        {
            
        }

    }
}