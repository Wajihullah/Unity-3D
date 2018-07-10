using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollow : MonoBehaviour {

	// Use this for initialization
	public Transform target;
	private Vector3 offset;
	void Start () {
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(target.position.x,target.position.y,-0.5f);
		//transform.position = target.position+offset;
	}
}
