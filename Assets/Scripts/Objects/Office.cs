// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Office.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the Office type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Objects
{
    using System.Collections.Generic;
    using System.Linq;

    using UnityEngine;
    using UnityEngine.UI;

    public class Office
    {
        public string OfficeName;
        public int EmployeeNum;
        public int EmployeeLimit;
        public int CostOfNewEmployee;
        public List<Employee> Employees;

        public Office()
        {
            this.OfficeName = string.Empty;
            this.EmployeeNum = 0;
            this.EmployeeLimit = 0;
            this.Employees = new List<Employee>();
            this.CostOfNewEmployee = 500;
        }

        public Office(string officeName, int eNum, int eLim, int costOfNewEmployee)
        {
            this.OfficeName = officeName;
            this.EmployeeNum = eNum;
            this.EmployeeLimit = eLim;
            this.Employees = new List<Employee>();
            for(int i = 0; i < this.EmployeeNum; i++)
            {
                this.Employees.Add(new Employee());
            }

            this.CostOfNewEmployee = costOfNewEmployee;
        }

        public double Revenue()
        {
            return this.Employees.Sum(e => e.Revenue);
        }

        public double Expenses()
        {
            return this.Employees.Sum(e => e.Expense);
        }

        public double Income()
        {
            return this.Employees.Sum(e => e.Income());
        }

        public Employee GetEmployee(int id)
        {
            if (id >= this.EmployeeNum || this.EmployeeNum == 0)
            {
                Debug.Log("This employee id does not exist");
                return null;
            }

            return this.Employees[id];
        }

        public bool AddEmployee()
        {
            if (this.EmployeeNum < this.EmployeeLimit)
            {
                this.Employees.Add(new Employee());
                this.CostOfNewEmployee = Mathf.CeilToInt(this.CostOfNewEmployee * 1.1f);
                this.EmployeeNum++;
                return true;
            }

            Debug.Log("Attempt to add employee when employee limit reached");
            return false;
        }

        public void AddEmployee(string name, Image img, int income, int rate, int expense)
        {
            this.Employees.Add(new Employee());
        }

        public void RemoveEmployee()
        {
            if (this.EmployeeNum > 0)
            {
                this.Employees.RemoveAt(this.EmployeeNum - 1);
                this.EmployeeNum--;
            }
        }

        public void RemoveEmployee(int id)
        {

        }
    }
}
