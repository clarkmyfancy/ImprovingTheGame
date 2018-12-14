// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OfficeListScrollView.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the OfficeListScrollView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OfficeList
{
    using Objects;

    using UnityEngine;

    using Views;

    public class OfficeListScrollView : MonoBehaviour
    {

        public GameObject OfficeButtonPrefab;

        private GameView gameView;

        // Use this for initialization
        void Start()
        {
            this.gameView = GameObject.FindWithTag("GameView").GetComponent<GameView>();

            foreach (Office office in this.gameView.Offices)
            {
                Debug.Log(office.OfficeName);
                GameObject buttonObject = Instantiate(this.OfficeButtonPrefab);
                buttonObject.SetActive(true);
                buttonObject.transform.SetParent(this.gameObject.transform);
                buttonObject.transform.localScale = Vector3.one;
                OfficeListButton officeButton = buttonObject.GetComponent<OfficeListButton>();
                officeButton.SetText(office.OfficeName);
            }
        }
    }
}
