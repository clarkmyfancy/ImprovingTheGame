// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeePortraits.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the EmployeePortraits type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.Helpers.Employee
{
    using Assets.Scripts.Services.Interfaces;

    public class EmployeePortraits
    {
        public string NewPortrait(IPortraitGeneratorService service)
        {
            return service.Portrait();
        }
    }
}

