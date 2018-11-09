// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MaleNameGeneratorService.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the MaleNameGeneratorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
// ReSharper disable StringLiteralTypo
namespace Assets.Scripts.Services
{
    using System;
    using System.Collections.Generic;

    using Assets.Scripts.Services.Interfaces;

    public class MaleNameGeneratorService : INameGeneratorService
    {
        private static readonly Random Rand = new Random(DateTime.Now.Second);

        private static readonly string[] MaleNames = { "Bob", "John", "Zack", "Mike", "Chris", "James", "Ned", "Andy", "Gary", "Brad" };
        private static readonly string[] LastNames = { "Dean", "Elton", "Wang", "Smith", "Kenway", "Lion", "Mathers", "Montez", "Steele", "Tanaka" };

        private static readonly List<string> NameList = new List<string>();

        string INameGeneratorService.Name()
        {
            var name = MaleNames[Rand.Next(9)] + " " + LastNames[Rand.Next(9)];
            if (NameList.Contains(name))
            {
                return ((INameGeneratorService)this).Name();
            }

            NameList.Add(name);
            return name;
        }
    }
}
