using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Objects
{
    public class Employee
    {
        public string Name;
        public string Portrait;
        public double Revenue;
        public double Rate;
        public double Expense;

        public Employee()
        {
            Name = "John Smith";
            Portrait = "employee1";
            Revenue = 40;
            Rate = 1;
            Expense = 20;
        }

        public Employee(string name, string portrait, double p, double r, double c)
        {
            Name = name;
            Portrait = portrait;
            Revenue = p;
            Rate = r;
            Expense = c;
        }

        public double Income()
        {
            return Revenue * Rate - Expense;
        }

        
    }
}
