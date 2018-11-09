// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OfficeView.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the OfficeView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.Views
{
    using System;

    using Assets.Scripts.Objects;

    using UnityEngine;

    public class OfficeView : MonoBehaviour
    {
        public int OfficeId;

        public string OfficeName;

        public int EmployeeNumber;

        public int EmployeeLimit;

        public Office Office;

        private GameView gameView;

        public int CostOfNewEmployee;

        // Use this for initialization
        void Start()
        {
            this.gameView = GameObject.FindWithTag("GameView").GetComponent<GameView>();
            this.Office = this.gameView.GetOffice(this.OfficeId);
        }

        // Update is called once per frame
        void Update()
        {
            this.EmployeeNumber = this.Office.EmployeeNum;
            this.EmployeeLimit = this.Office.EmployeeLimit;
            this.CostOfNewEmployee = this.gameView.GetOffice(this.OfficeId).CostOfNewEmployee;
        }

        public void AddEmployee()
        {
            Boolean employeeAdded = false;
            if (this.gameView.Score >= this.CostOfNewEmployee)
            {
                employeeAdded = this.Office.AddEmployee();
            }

            if (employeeAdded)
            {

                this.gameView.Score -= this.CostOfNewEmployee;
            }
           
        }

        public void RemoveEmployee()
        {
            this.Office.RemoveEmployee();
        }
    }
}
