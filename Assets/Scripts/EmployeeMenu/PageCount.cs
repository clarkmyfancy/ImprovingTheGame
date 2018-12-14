// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PageCount.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the PageCount type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.EmployeeMenu
{
    using global::EmployeeMenu;

    using UnityEngine;

    public class PageCount : MonoBehaviour
    {
        private EmployeePagination paginator;

        // Use this for initialization
        void Start()
        {
            this.paginator = GameObject.FindWithTag("EmployeePagination").GetComponent<EmployeePagination>();
        }

        // Update is called once per frame
        void Update()
        {
            this.gameObject.GetComponent<UnityEngine.UI.Text>().text =
                (this.paginator.Page + 1) + "/" + (this.paginator.PageLimit + 1);
        }
    }
}
