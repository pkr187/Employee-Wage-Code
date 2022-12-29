using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCode
{
    internal class companyEmpWage
    {
        public String Company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public companyEmpWage(string company, int empRatePerHour, int numofWorking, int maxHoursPerMonth)
        {
            this.Company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total Emp Wage for Company:" + this.Company + "is:" + this.totalEmpWage;
        }
    }
}
    

