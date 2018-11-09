using UnityEngine;

namespace Assets.Scripts
{
    using Assets.Scripts.Views;

    using UnityEngine.UI;

    public class ScoreController : MonoBehaviour
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
}
