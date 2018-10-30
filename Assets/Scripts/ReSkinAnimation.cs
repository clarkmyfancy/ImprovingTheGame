using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class ReSkinAnimation : MonoBehaviour
    {

        public string SpriteSheetName;

        void LateUpdate()
        {
            var subSprites = Resources.LoadAll<Sprite>("Characters/" + SpriteSheetName);

            foreach (var renderer in GetComponentsInChildren<SpriteRenderer>())
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
