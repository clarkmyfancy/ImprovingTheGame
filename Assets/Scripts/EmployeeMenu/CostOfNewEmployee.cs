// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CostOfNewEmployee.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the CostOfNewEmployee type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeMenu
{
    using UnityEngine;

    using Views;

    public class CostOfNewEmployee : MonoBehaviour
    {
        // Use this for initialization
        void Start () {
        }

        // Update is called once per frame
        void Update ()
        {
            this.gameObject.GetComponent<UnityEngine.UI.Text>().text = "$" + GameObject.FindWithTag("OfficeView")
                                                                           .GetComponent<OfficeView>().CostOfNewEmployee;
        }
    }
}
