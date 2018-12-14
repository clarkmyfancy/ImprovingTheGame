// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoadVariableScene.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the LoadVariableScene type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace UI
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class LoadVariableScene : MonoBehaviour
    {
        public int SceneNumber;

        void OnMouseDown()
        {
            SceneManager.LoadScene(this.SceneNumber);
        }
    }
}
