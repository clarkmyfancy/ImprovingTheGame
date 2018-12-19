// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Skill.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the Skill type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Objects
{
    public class Skill
    {
        public Skill(SkillType skillType, int skillValue)
        {
            this.SkillType = skillType;
            this.Value = skillValue;
        }

        public SkillType SkillType { get; set; }

        public int Value { get; set; }
    }
}
