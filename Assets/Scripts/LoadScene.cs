// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoadScene.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the LoadScene type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void GoToScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}