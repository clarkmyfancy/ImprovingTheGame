// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contract.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the Contract type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Objects
{
    public class Contract
    {
        public Contract(int minDifficulty, int maxDifficulty)
        {
            
        }

        public string Client { get; set; }

        public int Trust { get; set; }

        public int Duration { get; set; }

        public int Compensation { get; set; }

        public SkillSet Requirements { get; set; }
    }
}
