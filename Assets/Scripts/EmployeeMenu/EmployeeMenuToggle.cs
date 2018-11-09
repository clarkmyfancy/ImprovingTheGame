// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeMenuToggle.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the EmployeeMenuToggle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.EmployeeMenu
{
    using UnityEngine;

    public class EmployeeMenuToggle : MonoBehaviour {

        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {

        }

        public void ToggleActive()
        {
            if (this.gameObject.activeSelf)
            {
                this.gameObject.SetActive(false);
            }
            else
            {
                this.gameObject.SetActive(true);
            }
        }
    }
}
