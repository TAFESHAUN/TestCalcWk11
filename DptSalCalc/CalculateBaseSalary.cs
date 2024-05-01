using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DptSalCalc
{
    public class CalculateBaseSalary
    {
        decimal mangerBonus = 0.2m;
        decimal devBonus = 0.1m;
        decimal salesPerson = (decimal)0.15;

        string empType = "";
        public decimal CalcBaseSalary(decimal baseSalary, string passType)
        {
            //decimal bonus;

            //if(passType == "manager")
            //{
            //    bonus = mangerBonus;
            //}
            return baseSalary + (baseSalary * 0.2m);
        }

        public decimal CalcBaseSalary2(decimal baseSalary, string passType)
        {

            return baseSalary + (baseSalary * 0.1m);
        }

        //public decimal CalculateManagerBaseSalary(decimal baseWagePassed)
        //{

        //    return 0;
        //}

        //public decimal CalculateDeveloperBaseSalary(decimal baseWagePassed)
        //{

        //    return 0;
        //}
        //public decimal CalculateSalesBaseSalary(decimal baseWagePassed)
        //{

        //    return 0;
        //}
    }
}
