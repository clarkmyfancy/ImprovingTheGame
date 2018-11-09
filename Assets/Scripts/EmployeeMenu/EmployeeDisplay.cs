// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeDisplay.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the EmployeeDisplay type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.EmployeeMenu
{
    using System.Diagnostics.CodeAnalysis;

    using Assets.Scripts.EmployeeMenu;
    using Assets.Scripts.Objects;
    using Assets.Scripts.Views;

    using UnityEngine;
    using UnityEngine.UI;

    [SuppressMessage("ReSharper", "StyleCop.SA1400")]
    public class EmployeeDisplay : MonoBehaviour
    {
        public int ListPosition;
        public int EmployeeId;

        private int page;
        private Office office;
        private Employee employee;

        // Use this for initialization
        void Start()
        {
            this.page = 0;
            this.office = null;
            this.employee = null;
        }

        // Update is called once per frame
        void Update ()
        {
            this.page = GameObject.FindWithTag("EmployeePagination").GetComponent<EmployeePagination>().Page;
            this.EmployeeId = (this.page * 4) + this.ListPosition;
            this.office = GameObject.FindWithTag("OfficeView").GetComponent<OfficeView>().Office;

            if (this.IsValidEmployeeId())
            {
                this.employee = this.office.GetEmployee(this.EmployeeId);
                this.gameObject.transform.GetChild(0).GetComponent<Text>().text = this.employee.Name;
                this.gameObject.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Characters/" + this.employee.Portrait + "portrait");
                var income = this.employee.Income() < 0 ? "-$" + this.employee.Income() + "/s" : "+$" + this.employee.Income() + "/s";
                this.gameObject.transform.GetChild(2).GetComponent<Text>().text = income;
            }
        }

        public bool IsValidEmployeeId()
        {
            return this.EmployeeId < this.office.EmployeeNum;
        }
    }
}
