// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetEmployeeActive.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the SetEmployeeActive type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts
{
    using Assets.Scripts.Views;

    using UnityEngine;

    public class SetEmployeeActive : MonoBehaviour
    {
        public int employeeNumber;

        private OfficeView officeView;

        // Use this for initialization
        void Start()
        {
            this.officeView = GameObject.FindWithTag("OfficeView").GetComponent<OfficeView>();
        }

        // Update is called once per frame
        void Update()
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(this.employeeNumber <= this.officeView.EmployeeNumber);
        }
    }

}

