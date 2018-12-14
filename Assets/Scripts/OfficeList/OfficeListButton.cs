// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OfficeListButton.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the OfficeListButton type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OfficeList
{
    using UnityEngine;
    using UnityEngine.UI;

    public class OfficeListButton : MonoBehaviour
    {
        public Text ButtonText;

        private OfficeListView officeListView;

        void Start()
        {
            this.name = "Button";
            this.officeListView = GameObject.FindWithTag("OfficeListView").GetComponent<OfficeListView>();
        }

        public void SetSelectedOffice()
        {
            this.officeListView.SetSelectedOffice(this.ButtonText.text);
        }

        public void SetText(string officeName)
        {
            this.ButtonText.text = officeName;
        }
    }
}
