using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceScorer : MonoBehaviour {

	// Use this for initialization
	public GameObject point;
	void Start () {
		Instantiate(point,this.gameObject.transform.GetChild(0).position,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
