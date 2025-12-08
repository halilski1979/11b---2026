using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Employee
{
    public class FullTimeEmployee : BaseEmployee
    {
        public string employeePosition { get; set; }
        public string employeeDepartment { get; set; }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment) 
            : base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {employeePosition} \n Department: {employeeDepartment}");
        }


        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
           return employeeDepartment;
        }
    }
}
