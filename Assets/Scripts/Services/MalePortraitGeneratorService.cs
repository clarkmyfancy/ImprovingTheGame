// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MalePortraitGeneratorService.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the MalePortraitGeneratorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.Services
{
    using System;

    using Assets.Scripts.Services.Interfaces;

    public class MalePortraitGeneratorService : IPortraitGeneratorService
    {
        private static Random rand;

        private readonly string[] portraitNames = { "employee1", "employee2", "employee3", "martin", "camden", "matt" };

        public string Portrait()
        {
            rand = new Random();
            var portrait = this.portraitNames[rand.Next(5)];
            return portrait;
        }
    }
}
