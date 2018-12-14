// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FemalePortraitGeneratorService.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the FemalePortraitGeneratorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Services
{
    using System;

    using Assets.Scripts.Services.Interfaces;

    public class FemalePortraitGeneratorService : IPortraitGeneratorService
    {
        private static Random rand;

        private readonly string[] portraitNames = { "employeeF1", "employeeF2", "employeeF3", "employeeF4", "employeeF5", "employeeF6" };

        public string Portrait()
        {
            rand = new Random();
            var portrait = this.portraitNames[rand.Next(this.portraitNames.Length)];
            return portrait;
        }
    }
}
