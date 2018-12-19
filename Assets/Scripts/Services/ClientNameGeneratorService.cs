// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientNameGeneratorService.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the ClientNameGeneratorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Services
{
    using System;
    using System.Collections.Generic;

    using Assets.Scripts.Services.Interfaces;

    public class ClientNameGeneratorService : INameGeneratorService
    {
        private static readonly Random Rand = new Random(DateTime.Now.Second);

        private static readonly string[] OneOffs = { "Flex Capacitors", "DudePro Inc.", "CyberDongle", "ParisAll Umbrellas", "Damage Ink", "Kae Inc.", "Barry's Bonds", "Dike n' Hike" };
        private static readonly string[] Names = { "Pete's", "Ed's", "Bud's", "Mike's", "Bob's", "Joe's", "Gary's", "Linda's" };
        private static readonly string[] Descriptors = { "Blue", "Gorilla", "Illumination", "Hope", "Next Wave", "New World", "Patriot" };
        private static readonly string[] BusinessTypes = { "Synergistics", "Electronics.", "Information Systems", "Legal", "Agriculture", "Financing", "Travel", "Energy", "Transportation", "Catering", "Security" };

        private List<string> OneOffList = new List<string>();

        private List<string> NameList = new List<string>();

        private List<string> DescriptorList = new List<string>();

        private List<string> BusinessTypeList = new List<string>();

        public ClientNameGeneratorService()
        {
            this.OneOffList.AddRange(OneOffs);
            this.OneOffList.Shuffle(Rand);
            this.NameList.AddRange(Names);
            this.NameList.Shuffle(Rand);
            this.DescriptorList.AddRange(Descriptors);
            this.DescriptorList.Shuffle(Rand);
            this.BusinessTypeList.AddRange(BusinessTypes);
            this.BusinessTypeList.Shuffle(Rand);
        }

        string INameGeneratorService.Name()
        {
            bool oneOff = Rand.Next(4) == 0;
            if (oneOff)
            {
                
            }
            else
            {

            }
            var name = this.OneOffList[0];
            this.OneOffList.RemoveAt(0);
            return name;
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list, Random rnd)
        {
            for (var i = 0; i < list.Count; i++)
                list.Swap(i, rnd.Next(i, list.Count));
        }

        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
