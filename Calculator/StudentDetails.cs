
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public class StudentDetails
    {

        public string SendStudentObjDetails(Student passedStudent)
        {
            string output = $"Hello {passedStudent.Name}. Your Id is {passedStudent.Id}. {passedStudent.Description} ";
            return output;
        }

        public int FoundStudentId(List<Student> passedStudentsList) //List of students
        {
            //Filter for the id of the found student
            //passedStudentsList 

            int id = 0;
            return id ;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
