// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FemaleNameGeneratorService.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the FemaleNameGeneratorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
// ReSharper disable StringLiteralTypo
namespace Assets.Scripts.Services
{
    using System;
    using System.Collections.Generic;

    using Assets.Scripts.Services.Interfaces;

    public class FemaleNameGeneratorService : INameGeneratorService
    {
        private static readonly Random Rand = new Random(DateTime.Now.Second);

        private static readonly string[] FemaleNames = { "Alice", "Amy", "Betty", "Barb", "Julie", "Kat", "Karen", "Lucy", "Maria", "Rita" };
        private static readonly string[] LastNames = { "Dean", "Elton", "Wang", "Smith", "Kenway", "Lion", "Mathers", "Montez", "Steele", "Tanaka" };

        private static readonly List<string> nameList = new List<string>();

        string INameGeneratorService.Name()
        {
            var name = FemaleNames[Rand.Next(9)] + " " + LastNames[Rand.Next(9)];
            if (nameList.Contains(name))
            {
                return ((INameGeneratorService)this).Name();
            }

            nameList.Add(name);
            return name;
        }
    }
}
