// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateEmployeeCount.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the UpdateEmployeeCount type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OfficeList
{
    using UnityEngine;
    using UnityEngine.UI;

    using Views;

    public class UpdateEmployeeCount : MonoBehaviour
    {
        private OfficeListView officeListView;

        // Use this for initialization
        void Start()
        {
            this.officeListView = GameObject.FindWithTag("OfficeListView").GetComponent<OfficeListView>();
        }
         
        // Update is called once per frame
        void Update()
        {
            this.gameObject.GetComponent<Text>().text = this.officeListView.GetSelectedOffice().EmployeeNum + "/" + this.officeListView.GetSelectedOffice().EmployeeLimit;
        }
    }
}
