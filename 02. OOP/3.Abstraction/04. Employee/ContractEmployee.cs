using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Employee
{
    public class ContractEmployee : BaseEmployee
    {
        public string employeeTask { get; set; }
        public string employeeDepartment { get; set; }


        public ContractEmployee(string employeeID, string employeeName, string employeeAddress,string employeeTask,string employeeDepartment )
            : base(employeeID, employeeName, employeeAddress)
        {
            employeeTask = employeeTask;
            employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Employee task: {employeeTask} \n Department: {employeeDepartment}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
