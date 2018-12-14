// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HoverColorChange.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the HoverColorChange type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Coloring
{
    using System.Diagnostics.CodeAnalysis;

    using UnityEngine;

    public class HoverColorChange : MonoBehaviour
    {

        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Suppression is OK here.")]
        public Color MouseOverColor;

        private SpriteRenderer spriteRenderer;
        private Color originalColor;

        // Use this for initialization
        void Start()
        {
            this.spriteRenderer = this.GetComponent<SpriteRenderer>();
            this.originalColor = this.spriteRenderer.color;
        }

        void OnMouseOver()
        {
            this.spriteRenderer.color = this.MouseOverColor;
        }

        void OnMouseExit()
        {
            this.spriteRenderer.color = this.originalColor;
        }
    }
}
