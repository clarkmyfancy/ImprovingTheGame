// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SKillSet.cs" company="Improving">
//  <author>
//      Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the SKillSet type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Objects
{
    using System;
    using System.Collections.Generic;

    public class SkillSet
    {
        private Random rand;

        public SkillSet()
        {
            this.rand = new Random(DateTime.Now.Second);

            this.Applications = new Skill(SkillType.Applications, 0);
            this.Architecture = new Skill(SkillType.Architecture, 0);
            this.Databases = new Skill(SkillType.Databases, 0);
            this.Mobile = new Skill(SkillType.Mobile, 0);
            this.Network = new Skill(SkillType.Networks, 0);
            this.UX = new Skill(SkillType.UX, 0);
            this.Web = new Skill(SkillType.Web, 0);
        }

        public Skill Applications { get; set; }

        public Skill Architecture { get; set; }

        public Skill Databases { get; set; }

        public Skill Mobile { get; set; }

        public Skill Network { get; set; }

        public Skill UX { get; set; }

        public Skill Web { get; set; }

        public void SetBaseSkillSet(int numberToUpgrade)
        {
            HashSet<int> randomSet = new HashSet<int>();
            for (int i = 0; i < numberToUpgrade; i++)
            {
                var skillLevel = this.rand.Next(7);
                while (randomSet.Contains(skillLevel))
                    skillLevel = this.rand.Next(7);
                switch (skillLevel)
                {
                    case 0:
                        this.Applications.Value += 30;
                        break;
                    case 1:
                        this.Architecture.Value += 30;
                        break;
                    case 2:
                        this.Databases.Value += 30;
                        break;
                    case 3:
                        this.Mobile.Value += 30;
                        break;
                    case 4:
                        this.Network.Value += 30;
                        break;
                    case 5:
                        this.UX.Value += 30;
                        break;
                    case 6:
                        this.Web.Value += 30;
                        break;
                }
            }
        }
    }
}
