using UnityEngine;

namespace Assets.Scripts
{
    public class ScoreController : MonoBehaviour {

        public double Score;

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
        // Use this for initialization
        void Start () {
        
        }
	
        // Update is called once per frame
        void Update () {
            Score = GameObject.FindWithTag("GameTracker").GetComponent<GameController>().Score;
            gameObject.GetComponent<UnityEngine.UI.Text>().text = ((int)Score).ToString();
        }
    }
}
