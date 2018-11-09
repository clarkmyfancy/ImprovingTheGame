// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameView.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the GameView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Assets.Scripts.Views
{
    using System.Collections.Generic;
    using System.Linq;

    using Assets.Scripts.Objects;

    using UnityEngine;

    public class GameView : MonoBehaviour {

        public double Score;
        public double NetIncome;
        public List<Office> Offices;

        private GameObject gameView;

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);

            if (FindObjectsOfType(GetType()).Length > 1)
            {
                Destroy(this.gameObject);
            }
        }

        // Use this for initialization
        void Start () {
            this.Score = 0;
            this.Offices = new List<Office>();
            this.Offices.Add(new Office("College Station", 1, 6, 500));
            this.InvokeRepeating("AddRevenue", 0, 1);
        }

        // Update is called once per frame
        void Update ()
        {
            
        }

        public Office GetOffice(int id)
        { 
            return this.Offices[id];
        }

        void AddRevenue()
        {
            this.NetIncome = this.CalculateNetIncome();
            this.Score += this.NetIncome;
        }

        double CalculateNetIncome()
        {
            return this.Offices.Sum(o => o.Income());
        }
    }
}
