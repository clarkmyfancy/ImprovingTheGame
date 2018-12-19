// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateSelectedOffice.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the UpdateSelectedOffice type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OfficeList
{
    using UnityEngine;
    using UnityEngine.UI;

    using Views;

    public class UpdateSelectedOffice : MonoBehaviour
    {
        private OfficeListView officeListView;

        void Start()
        {
            this.officeListView = GameObject.FindWithTag("OfficeListView").GetComponent<OfficeListView>();
        }
        void Update()
        {
            this.gameObject.GetComponent<Text>().text = this.officeListView.GetSelectedOffice().OfficeName;
        }
    }
}
