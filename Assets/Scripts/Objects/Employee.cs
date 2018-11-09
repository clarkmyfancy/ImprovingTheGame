// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the Employee type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.Objects
{
    using System;

    using Assets.Scripts.Helpers.Employee;
    using Assets.Scripts.Services;
    using Assets.Scripts.Services.Interfaces;

    public class Employee
    {
        private static Random rand;

        public string Name { get; set; }

        public string Portrait { get; set; }

        public double Revenue { get; set; }

        public double Rate { get; set; }

        public double Expense { get; set; }

        public Employee()
        {
            rand = new Random(DateTime.Now.Second);
            var isMale = rand.Next(1) == 0;
            EmployeeNameGenerator employeeNameGenerator = new EmployeeNameGenerator();
            EmployeePortraits employeePortraits = new EmployeePortraits();

            INameGeneratorService nameGen;
            IPortraitGeneratorService portraitGen;

            if (isMale)
            {
                nameGen = new MaleNameGeneratorService();
                portraitGen = new MalePortraitGeneratorService();
            }
            else
            {
                nameGen = new FemaleNameGeneratorService();
                portraitGen = new MalePortraitGeneratorService();
            }

            this.Name = employeeNameGenerator.NewName(nameGen);
            this.Portrait = employeePortraits.NewPortrait(portraitGen);
            this.Revenue = 40;
            this.Rate = 1;
            this.Expense = 20;
        }

        public Employee(string name, string portrait, double p, double r, double c)
        {
            this.Name = name;
            this.Portrait = portrait;
            this.Revenue = p;
            this.Rate = r;
            this.Expense = c;
        }

        public double Income()
        {
            return (this.Revenue * this.Rate) - this.Expense;
        }
    }
}
