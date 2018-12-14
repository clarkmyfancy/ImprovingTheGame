// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateSelectedOffice.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the UpdateSelectedOffice type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace UI
{
    using UnityEngine;
    using UnityEngine.UI;

    public class UpdateSelectedOffice : MonoBehaviour
    {
        private OfficeListView officeListView;

        private Text selectedOfficeText;

        void Start()
        {
            this.officeListView = GameObject.FindWithTag("OfficeListView").GetComponent<OfficeListView>();
            this.selectedOfficeText = this.gameObject.GetComponent<Text>();
        }
        void Update()
        {
            this.gameObject.GetComponent<Text>().text = this.officeListView.GetSelectedOffice();
        }
    }
}

