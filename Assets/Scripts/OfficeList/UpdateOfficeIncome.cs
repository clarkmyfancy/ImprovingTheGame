// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateOfficeIncome.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the UpdateOfficeIncome type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OfficeList
{
    using UnityEngine;
    using UnityEngine.UI;

    using Views;

    public class UpdateOfficeIncome : MonoBehaviour
    {
        private OfficeListView officeListView;

        void Start()
        {
            this.officeListView = GameObject.FindWithTag("OfficeListView").GetComponent<OfficeListView>();
        }

        void Update()
        {
            this.gameObject.GetComponent<Text>().text = "$" + this.officeListView.GetSelectedOffice().Income().ToString();
        }
    }
}
