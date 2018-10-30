using Assets.Scripts.Objects;
using UnityEngine;

namespace Assets.Scripts
{
    public class OfficeController : MonoBehaviour {
        public int OfficeId;
        public string OfficeName;
        public Office Office;

        private GameController _gameCtrl;
        // Use this for initialization
        void Start ()
        {
            Office = new Office();
        }
	
        // Update is called once per frame
        void Update () {
            _gameCtrl = GameObject.FindWithTag("GameTracker").GetComponent<GameController>();
            Office = _gameCtrl.GetOffice(OfficeId);
        }

        public void AddEmployee()
        {
            Office.AddEmployee();
        }

        public void RemoveEmployee()
        {
            Office.RemoveEmployee();
        }
    }
}
