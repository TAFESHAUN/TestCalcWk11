namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        //public decimal GetAnnualSalary(decimal hourlyWage)
        //{
        //    decimal annualSalary = hourlyWage * HoursInYear;
        //    return annualSalary;
        //    //return -1;
        //}
        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;

        public decimal GetHourlyWage(decimal annualSalary)
        {
            return annualSalary / HoursInYear;
            //return 0;
        }

        public List<decimal> ImportWages()//OR IMPORT EMPLOYEE DATA
        {
            //SOME IMPORT HERE
            List<decimal> listOfWages = new List<decimal>();
            listOfWages.Add((decimal)15.5);
            listOfWages.Add((decimal)25.754);
            listOfWages.Add((decimal)25.999);
            //Employee data


            return listOfWages;
        }

        //const int HoursInYear = 2080;

        //public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;
        //public decimal GetHourlyWage(decimal annualSalary) => annualSalary / HoursInYear;

    }
}