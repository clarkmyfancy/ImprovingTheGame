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
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using Constants;

    using UnityEngine;
    using UnityEngine.UI;

    [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
    public class Office
    {
        public string OfficeName;
        public int EmployeeNum;
        public int EmployeeLimit;
        public int CostOfNewEmployee;
        public List<Employee> Employees;
        public SkillSet skillSet;

        public Office()
        {
            this.OfficeName = string.Empty;
            this.EmployeeNum = 0;
            this.EmployeeLimit = 0;
            this.CostOfNewEmployee = 500;
            this.Employees = new List<Employee>();
            this.skillSet = new SkillSet();
        }

        public Office(string officeName, int eNum, int eLim, int costOfNewEmployee)
        {
            this.OfficeName = officeName;
            this.EmployeeNum = eNum;
            this.EmployeeLimit = eLim;
            this.CostOfNewEmployee = costOfNewEmployee;
            this.Employees = new List<Employee>();
            for (int i = 0; i < this.EmployeeNum; i++)
            {
                this.Employees.Add(new Employee());
            }

            this.skillSet = new SkillSet();
            this.SumEmployeeSkillsSets();
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
                this.SumEmployeeSkillsSets();
                return true;
            }

            if (GlobalConstants.DebugMode)
                Debug.Log("Attempt to add employee when employee limit reached");
            return false;
        }

        public void AddEmployee(string name, Image img, int income, int rate, int expense)
        {
            this.Employees.Add(new Employee());
            this.SumEmployeeSkillsSets();
        }

        public void RemoveEmployee()
        {
            if (this.EmployeeNum > 0)
            {
                this.Employees.RemoveAt(this.EmployeeNum - 1);
                this.EmployeeNum--;
                this.SumEmployeeSkillsSets();
            }
        }

        public void SumEmployeeSkillsSets()
        {
            this.skillSet.Applications.Value = this.Employees.Sum(e => e.SkillSet.Applications.Value);
            this.skillSet.Architecture.Value = this.Employees.Sum(e => e.SkillSet.Architecture.Value);
            this.skillSet.Databases.Value = this.Employees.Sum(e => e.SkillSet.Databases.Value);
            this.skillSet.Mobile.Value = this.Employees.Sum(e => e.SkillSet.Mobile.Value);
            this.skillSet.Network.Value = this.Employees.Sum(e => e.SkillSet.Network.Value);
            this.skillSet.UX.Value = this.Employees.Sum(e => e.SkillSet.UX.Value);
            this.skillSet.Web.Value = this.Employees.Sum(e => e.SkillSet.Web.Value);
            if (GlobalConstants.DebugMode)
                Debug.Log("SkillSet:" +
                      "\n Applications: " + this.skillSet.Applications.Value +
                      "\n Architecture: " + this.skillSet.Architecture.Value +
                      "\n Databases: " + this.skillSet.Databases.Value +
                      "\n Mobile: " + this.skillSet.Mobile.Value +
                      "\n Network: " + this.skillSet.Network.Value +
                      "\n UX: " + this.skillSet.UX.Value +
                      "\n Web: " + this.skillSet.Web.Value);
        }
    }
}
