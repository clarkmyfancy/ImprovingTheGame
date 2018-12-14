// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScoreKeeper.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the ScoreKeeper type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI;

using Views;

public class ScoreKeeper : MonoBehaviour
{
    public double Score;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.Score = GameObject.FindWithTag("GameView").GetComponent<GameView>().Score;
        this.gameObject.GetComponent<Text>().text = ((int)this.Score).ToString();
    }
}