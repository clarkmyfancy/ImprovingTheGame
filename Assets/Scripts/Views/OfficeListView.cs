// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OfficeListView.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the OfficeListView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Views
{
    using System.Linq;

    using Objects;

    using UnityEngine;

    public class OfficeListView : MonoBehaviour
    {
        private Office selectedOffice;

        private GameView gameView;

        // Use this for initialization
        void Start()
        {
            this.gameView = GameObject.FindWithTag("GameView").GetComponent<GameView>();
            this.selectedOffice = new Office();
        }

        public Office GetSelectedOffice()
        {
            return this.selectedOffice;
        }

        public void SetSelectedOffice(string office)
        {
            this.selectedOffice = this.gameView.Offices.SingleOrDefault(o => o.OfficeName == office);
        }
    }
}
