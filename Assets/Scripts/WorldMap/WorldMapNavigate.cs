// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorldMapNavigate.cs" company="Improving">
//   Reid Shultz
// </copyright>
// <summary>
//   Defines the WorldMapNavigate type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
// ReSharper disable All
using UnityEngine;

namespace Assets.Scripts.WorldMap
{
    public class WorldMapNavigate : MonoBehaviour
    {
        public string direction;

        private GameObject mainCamera;

        private Vector3 velocity = Vector3.zero;

        // private readonly fields
        private readonly float smoothTime = 0.4F;
        private readonly float cameraPanSpeed = 2.0f;
        private readonly float minX = 7.92f;
        private readonly float maxX = 20.55f;
        private readonly float minY = -8.87f;
        private readonly float maxY = -2f;

        private readonly float xOffset = 1.5f;
        private readonly float yOffset = 0.8f;

        void Start()
        {
            this.mainCamera = GameObject.FindWithTag("MainCamera");
        }

        void OnMouseOver()
        {
            Vector3 directionVector = CheckDirectionAndBounds(this.direction);
            var targetPosition = this.mainCamera.transform.position + directionVector;
            this.mainCamera.transform.position = Vector3.SmoothDamp(this.mainCamera.transform.position, targetPosition, ref this.velocity, this.smoothTime);
        }

        private Vector3 CheckDirectionAndBounds(string direction)
        {
            switch (this.direction)
            {
                case "up":
                    return this.mainCamera.transform.position.y + this.yOffset < this.maxY
                               ? this.cameraPanSpeed * Vector3.up
                               : Vector3.zero;
                case "down":
                    return this.mainCamera.transform.position.y - this.yOffset > this.minY
                               ? this.cameraPanSpeed * Vector3.down
                               : Vector3.zero;
                case "right":
                    return this.mainCamera.transform.position.x + this.xOffset < this.maxX
                               ? this.cameraPanSpeed * Vector3.right
                               : Vector3.zero;
                case "left":
                    return this.mainCamera.transform.position.x - this.xOffset > this.minX
                               ? this.cameraPanSpeed * Vector3.left
                               : Vector3.zero;
                default:
                    Debug.Log("Invalid Direction String");
                    return Vector3.zero;
            }
        }
    }
}

