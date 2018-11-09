// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeCount.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the EmployeeCount type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.Employees.EmployeeMenu
{
    using Assets.Scripts.Views;

    using UnityEngine;

    public class EmployeeCount : MonoBehaviour
    {
        private int employeeNumber;

        private int employeeLimit;

        private OfficeView officeView;

        // Use this for initialization
        void Start()
        {
            this.officeView = GameObject.FindWithTag("OfficeView").GetComponent<OfficeView>();
        }

        // Update is called once per frame
        void Update()
        {
            this.employeeNumber = this.officeView.EmployeeNumber;
            this.gameObject.GetComponent<UnityEngine.UI.Text>().text =
                this.officeView.EmployeeNumber + "/" + this.officeView.EmployeeLimit;
        }
    }

}

