using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Employee
{
    public abstract class BaseEmployee
    {
       

        public string employeeID { get; set; }
        public string employeeName { get; set; }
        public string employeeAddress { get; set; }

        protected BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public virtual void Show()
        {
            Console.WriteLine($"ID: {employeeID} \n Name:{employeeName} \n Adress: {employeeAddress}");
        }

        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();

    }
}
