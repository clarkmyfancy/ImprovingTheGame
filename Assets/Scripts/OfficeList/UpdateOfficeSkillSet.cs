// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateSkillSet.cs" company="Improving">
//  <author>   
//    Reid Shultz
//  </author>
// </copyright>
// <summary>
//   Defines the UpdateSkillSet type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OfficeList
{
    using Objects;

    using UnityEngine;
    using UnityEngine.UI;

    using Views;

    public class UpdateOfficeSkillSet : MonoBehaviour
    {
        public SkillType SkillToTrack;

        private OfficeListView officeListView;

        private Text officeSkillLevel;

        // Use this for initialization
        void Start()
        {
            this.officeListView = GameObject.FindWithTag("OfficeListView").GetComponent<OfficeListView>();
            this.officeSkillLevel = this.gameObject.GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            switch (this.SkillToTrack)
            {
                case SkillType.Applications:
                    this.officeSkillLevel.text = this.officeListView.GetSelectedOffice().skillSet.Applications.Value.ToString();
                    break;
                case SkillType.Architecture:
                    this.officeSkillLevel.text = this.officeListView.GetSelectedOffice().skillSet.Architecture.Value.ToString();
                    break;
                case SkillType.Databases:
                    this.officeSkillLevel.text = this.officeListView.GetSelectedOffice().skillSet.Databases.Value.ToString();
                    break;
                case SkillType.Mobile:
                    this.officeSkillLevel.text = this.officeListView.GetSelectedOffice().skillSet.Mobile.Value.ToString();
                    break;
                case SkillType.Networks:
                    this.officeSkillLevel.text = this.officeListView.GetSelectedOffice().skillSet.Network.Value.ToString();
                    break;
                case SkillType.UX:
                    this.officeSkillLevel.text = this.officeListView.GetSelectedOffice().skillSet.UX.Value.ToString();
                    break;
                case SkillType.Web:
                    this.officeSkillLevel.text = this.officeListView.GetSelectedOffice().skillSet.Web.Value.ToString();
                    break;
            }
        }
    }
}
