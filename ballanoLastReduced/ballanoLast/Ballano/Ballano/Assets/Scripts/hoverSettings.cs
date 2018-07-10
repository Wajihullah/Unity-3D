using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hoverSettings : MonoBehaviour{
	public Image x;
	public Image y;
	int i=0;
	public int j=0;
	Image z;

	// Use this for initialization
	void Start () {
		z = this.GetComponent<Image>();
	}
	
	// Update is called once per frame
	public void setJ()
	{
		j = 1;
	}
	void OnMouseDown()
	{
		z.sprite = x.sprite;
	}
	void Update () {
		if (Input.GetMouseButtonDown (0)&& j==1) {
			
			j = 0;
		}
	}
	 
}
