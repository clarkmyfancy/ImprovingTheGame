// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeePagination.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the EmployeePagination type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeMenu
{
    using Assets.Scripts.EmployeeMenu;

    using Objects;

    using UnityEngine;

    using Views;

    public class EmployeePagination : MonoBehaviour
    {
        public int Page;
        public int PageLimit;

        private Office office;

        // Use this for initialization
        void Start ()
        {
            this.Page = 0;
            this.PageLimit = 0;
        }

        // Update is called once per frame
        void FixedUpdate ()
        {
            this.office = GameObject.FindWithTag("OfficeView").GetComponent<OfficeView>().Office;
            this.PageLimit = this.CalculatePageLimit();

            for (int i = 0; i <= 3; i++)
            {
                if (this.gameObject.transform.GetChild(i).GetComponent<EmployeeDisplay>().EmployeeId
                    >= this.office.EmployeeNum)
                {
                    this.DisableEmployee(i);
                }
                else
                {
                    this.EnableEmployee(i);
                }
            }
        }

        public void PrevPage()
        {
            if (this.Page > 0)
                this.Page--;
        }

        public void NextPage()
        {
            if (this.Page < this.PageLimit)
                this.Page++;
        }

        private int CalculatePageLimit()
        {
            int pageLimit = Mathf.FloorToInt(this.office.EmployeeNum / 4.0f);
            if (this.office.EmployeeNum > 1 && this.office.EmployeeNum % 4 == 0)
                pageLimit--;
            return pageLimit;
        }

        private void DisableEmployee(int childNumber)
        {
            this.gameObject.transform.GetChild(childNumber).transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().enabled = false;
            this.gameObject.transform.GetChild(childNumber).transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().enabled = false;
            this.gameObject.transform.GetChild(childNumber).transform.GetChild(2).GetComponent<UnityEngine.UI.Text>().enabled = false;
        }

        private void EnableEmployee(int childNumber)
        {
            this.gameObject.transform.GetChild(childNumber).transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().enabled = true;
            this.gameObject.transform.GetChild(childNumber).transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().enabled = true;
            this.gameObject.transform.GetChild(childNumber).transform.GetChild(2).GetComponent<UnityEngine.UI.Text>().enabled = true;
        }

    }
}
