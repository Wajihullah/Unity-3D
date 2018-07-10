using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour {

	public GameObject []  hooks;
	public GameObject unitPrefab;
	public int num_hooks = 10;
	public int currY = 8;
	// Use this for initialization
	void Start () {
		hooks = new GameObject[num_hooks];
		for(int i = 0; i< num_hooks ; i++){
			Vector3 unitPos = new Vector3 (Random.Range(-12,12),currY + 20,-1);
			currY += 20;
			hooks [i] = Instantiate (unitPrefab, this.transform.position + unitPos, Quaternion.identity) as GameObject;
		}
	}

	void update () {

	}
}
