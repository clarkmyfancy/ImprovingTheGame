using System;
using UnityEngine;

namespace Assets.Scripts
{
    using Assets.Scripts.Views;

    public class ReSkinAnimation : MonoBehaviour
    {
        public int EmployeeNumber;

        void LateUpdate()
        {
            string spriteSheetName = string.Empty;
            if (this.EmployeeNumber == -1)
            {
                spriteSheetName = "boss";
            }
            else
            {
                spriteSheetName = GameObject.FindWithTag("OfficeView").GetComponent<OfficeView>().Office
                    .Employees[this.EmployeeNumber].Portrait;
            }
            var subSprites = Resources.LoadAll<Sprite>("Characters/" + spriteSheetName);

            foreach (var renderer in this.GetComponentsInChildren<SpriteRenderer>())
            {
                string spriteName = renderer.sprite.name;
                var newSprite = Array.Find(subSprites, item => item.name == spriteName);

                if (newSprite)
                    renderer.sprite = newSprite;
            }
        }

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
		
        }
    }
}
