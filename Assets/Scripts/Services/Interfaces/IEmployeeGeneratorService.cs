// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeGeneratorService.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the IEmployeeGeneratorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Services.Interfaces
{
    using Objects;

    public interface IEmployeeGeneratorService
    {
        Employee MakeEmployee();
    }
}
