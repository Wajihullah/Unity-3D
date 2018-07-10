using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickInstantiate : MonoBehaviour {

	// Use this for initialization
	public GameObject stick;
	public GameObject car;
	public GameObject hook;
	void Start () {
		Instantiate(stick, (car.transform.position+hook.transform.position)*0.5f,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
