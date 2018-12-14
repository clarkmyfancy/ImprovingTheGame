// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FixToCamera.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the FixToCamera type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace UI
{
    using UnityEngine;

    public class FixToCamera : MonoBehaviour
    {
        private GameObject mainCamera;

        // Use this for initialization
        void Start()
        {
            this.mainCamera = GameObject.FindWithTag("MainCamera");
            this.transform.parent = this.mainCamera.transform;
        }
    }
}
