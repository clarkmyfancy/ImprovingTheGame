// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeNameGenerator.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the EmployeeNameGenerator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.Helpers.Employee
{
    using Assets.Scripts.Services.Interfaces;

    public class EmployeeNameGenerator
    {
        public string NewName(INameGeneratorService service)
        {
            return service.Name();
        }
    }

}
