using Calculator; //USE THE PROJECT LIBS REFERENCE

namespace Week11Test
{
    [TestClass]
    public class StudentDetailsTest
    {
        [TestMethod]
        public void SendStudentObjDetailsTest()
        {
            //Arrange
            StudentDetails studentDetails = new StudentDetails();
            Student student = new Student();
            student.Id = 1;
            student.Name = "David";
            student.Description = "David started year 10 yesterday";

            //Act
            string studentObjDetails = studentDetails.SendStudentObjDetails(student);

            //Assert
            Assert.IsNotNull(studentObjDetails);
            Assert.AreEqual("Hello David. Your Id is 1. David started year 10 yesterday ", studentObjDetails);

        }

        [TestMethod]
        public void FoundStudentTest()
        {
            //Default is that it passes.
        }
    }
}
