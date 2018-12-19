// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SkillType.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the SkillType type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Objects
{
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:EnumerationItemsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    public enum SkillType
    {
        
        Applications,
        Architecture,
        Databases,
        Mobile,
        Networks,
        UX,
        Web
    }
}
