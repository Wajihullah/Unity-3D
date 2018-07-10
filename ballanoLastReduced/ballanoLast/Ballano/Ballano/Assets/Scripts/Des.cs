using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des : MonoBehaviour {

	// Use this for initialization
	public int i=0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("line1") != null) {
			i++;
		}
	}
}
