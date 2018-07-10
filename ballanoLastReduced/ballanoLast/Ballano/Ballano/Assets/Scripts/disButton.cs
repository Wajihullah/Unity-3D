using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class disButton : MonoBehaviour {
	public int i=0;
	public GameObject button;
	public GameObject button1;
	public void nextclick()
	{	
		
		if(i<4)
		i++;
		if (i == 4) {
			button.SetActive(false);

		} else {
			button.SetActive(true);
			button1.SetActive (true);
		}
	}
	public void backclick()
	{
		if(i>0)
		i--;
		if (i == 0) {
			button1.SetActive(false);

		}
		else {
			button1.SetActive(true);
			button.SetActive (true);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
