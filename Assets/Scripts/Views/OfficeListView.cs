
using System.Linq;

using Objects;

using UnityEngine;

using Views;

public class OfficeListView : MonoBehaviour
{
    private Office selectedOffice;

    public GameView gameView;

    // Use this for initialization
    void Start()
    {
        this.gameView = GameObject.FindWithTag("GameView").GetComponent<GameView>();
    }

    public string GetSelectedOffice()
    {
        return this.selectedOffice.OfficeName;
    }

    public void SetSelectedOffice(string office)
    {
        this.selectedOffice = this.gameView.Offices.SingleOrDefault(o => o.OfficeName == office);
    }
}
