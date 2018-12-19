// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsultantGeneratorService.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the ConsultantGeneratorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Services
{
    using System;
    using System.Runtime.InteropServices;

    using Objects;

    using Services.Interfaces;

    public class ConsultantGeneratorService : IEmployeeGeneratorService
    {
        private readonly Random rand = new Random(DateTime.Now.Millisecond);

        public Employee MakeEmployee()
        {
            var consultant = new Employee();
            consultant.SkillSet.SetBaseSkillSet(3);
            return consultant;
        }
    }
}
