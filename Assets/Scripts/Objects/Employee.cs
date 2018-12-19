// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the Employee type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Objects
{
    using System;
    using System.Collections.Generic;

    using Assets.Scripts.Helpers.Employee;
    using Assets.Scripts.Services;
    using Assets.Scripts.Services.Interfaces;

    using Services;

    public class Employee
    {
        private Random rand;

        public string Name { get; set; }

        public string Portrait { get; set; }

        public double Revenue { get; set; }

        public double Rate { get; set; }

        public double Expense { get; set; }

        public SkillSet SkillSet { get; set; }

        public Employee()
        {
            this.rand = new Random(DateTime.Now.Second);
            var isMale = this.rand.Next(2) == 0;
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
                portraitGen = new FemalePortraitGeneratorService();
            }

            this.Name = employeeNameGenerator.NewName(nameGen);
            this.Portrait = employeePortraits.NewPortrait(portraitGen);
            this.Revenue = 40;
            this.Rate = 1;
            this.Expense = 20;
            this.SkillSet = new SkillSet();
            this.SkillSet.SetBaseSkillSet(3);
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
