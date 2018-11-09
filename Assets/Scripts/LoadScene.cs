// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoadScene.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the LoadScene type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class LoadScene : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void GoToScene(int sceneNumber)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}

