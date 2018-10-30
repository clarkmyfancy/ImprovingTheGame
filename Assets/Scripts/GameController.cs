using System.Collections.Generic;
using Assets.Scripts.Objects;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour {

        public double Score;
        public double NetIncome;
        public string Employees;
        public List<Office> Offices;

        private GameObject _gameTracker;

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        // Use this for initialization
        void Start () {
            Employees = "";
            Score = 0;
            Offices = new List<Office>();
            Offices.Add(new Office("College Station", 1, 6));
            InvokeRepeating("AddRevenue", 0, 1);
        }
	
        // Update is called once per frame
        void Update ()
        {
            string temp = "";
            foreach (Employee e in Offices[0].Employees)
            {
                temp += e.Name + ", ";
            }
            Employees = temp;
        }

        public Office GetOffice(int id)
        {
            return Offices[id];
        }

        void AddRevenue()
        {
            NetIncome = CalculateNetIncome();
            Score += NetIncome;
        }

        double CalculateNetIncome()
        {
            double income = 0;
            foreach (Office o in Offices)
            {
                income += o.Income();
            }
            return income;
        }
    }
}
