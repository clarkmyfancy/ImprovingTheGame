using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconPreview : MonoBehaviour {
	public Sprite[] icons;
	GameObject icon;


	// Use this for initialization
	void Awake () {
		for (int i = 0; i < this.icons.Length; i++) {
		    this.icon = new GameObject ("icon" + i);
		    this.icon.transform.SetParent(this.gameObject.transform);
		    this.icon.AddComponent<RectTransform> ();
		    this.icon.AddComponent<Image> ();
		    this.icon.GetComponent<Image> ().sprite = this.icons [i];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
