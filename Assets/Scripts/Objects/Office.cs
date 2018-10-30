using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.Objects
{
    public class Office
    {
        public string OfficeName;
        public int EmployeeNum;
        public int EmployeeLimit;
        public List<Employee> Employees;

        public Office()
        {
            OfficeName = "";
            EmployeeNum = 0;
            EmployeeLimit = 0;
            Employees = new List<Employee>();
        }
        public Office(string name, int eNum, int eLim)
        {
            OfficeName = name;
            EmployeeNum = eNum;
            EmployeeLimit = eLim;
            Employees = new List<Employee>();
            for(int i = 0; i < EmployeeNum; i++)
            {
                Employees.Add(new Employee());
            }
        }

        public double Revenue()
        {
            double revenue = 0;
            foreach(Employee e in Employees)
            {
                revenue += e.Revenue;
            }
            return revenue;
        }

        public double Expenses()
        {
            double expense = 0;
            foreach(Employee e in Employees)
            {
                expense += e.Expense;
            }
            return expense;
        }

        public double Income()
        {
            double income = 0;
            foreach(Employee e in Employees)
            {
                income += e.Income();
            }
            return income;
        }

        public Employee GetEmployee(int id)
        {
            if (id >= EmployeeNum || EmployeeNum == 0)
            {
                Debug.Log("This employee id does not exist");
                return null;
            }

            return Employees[id];
        }

        public void AddEmployee()
        {
            if (EmployeeNum < EmployeeLimit)
            {
                Employees.Add(new Employee());
                EmployeeNum++;
            }
            else { Debug.Log("Attempt to add employee when employee limit reached"); }
        }

        public void AddEmployee(string name, UnityEngine.UI.Image img, int income, int rate, int expense)
        {
            Employees.Add(new Employee());
        }

        public void RemoveEmployee()
        {
            if (EmployeeNum > 0)
            {
                Employees.RemoveAt(EmployeeNum-1);
                EmployeeNum--;
            }
        }

        public void RemoveEmployee(int id)
        {

        }
    }
}
